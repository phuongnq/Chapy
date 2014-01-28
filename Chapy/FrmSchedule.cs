using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace Chapy
{
    public partial class FrmSchedule : Form
    {
        //database access
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
        public FrmMakeShift frmp;
        Hashtable jaWeekday;

        int[] classIDs, timezoneIDs;
        int[][] classTeacher;
        DateTime fromDate, toDate;
        String[] tzColors, tzShortName;
        int[][] results;

        int selecting;
        int[] saved = new int[4]{0, 0, 0, 0};

        public FrmSchedule(FrmMakeShift frm)
        {
            InitializeComponent();

            jaWeekday = new Hashtable();
            jaWeekday["Sunday"] = "日";
            jaWeekday["Monday"] = "月";
            jaWeekday["Tuesday"] = "火";
            jaWeekday["Wednesday"] = "水";
            jaWeekday["Thursday"] = "木";
            jaWeekday["Friday"] = "金";
            jaWeekday["Saturday"] = "土";

            this.frmp = frm;
            this.fromDate = frm.getFromDate();
            this.toDate = frm.getToDate();
            CreateSchedule cs = new CreateSchedule(frm);
            this.classIDs = cs.getClassIDs();
            this.classTeacher = cs.getClassTeacher();
            initForm();
            results = cs.getResult(4);
            selecting = 0;
            applyResult(results[0]);
        }

        private void initForm()
        {
            //school name
            int school_id = VariableGlobal.school_id;
            var school = (from p in db.CpSchools where p.Id == school_id select p).SingleOrDefault();
            this.lblSchoolName.Text = school.Code.Trim() + ". " + school.Name;

            //Add day
            DateTime date = this.fromDate;
            while (date <= this.toDate)
            {
                //datagridview
                DataGridViewLabelXColumn cl = new DataGridViewLabelXColumn();
                cl.HeaderText = date.Day + "\n" + "(" + jaWeekday["" + date.DayOfWeek] + ")";
                cl.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                cl.HeaderCell.Style.Font = new Font("Meiryo", 7.5F, FontStyle.Bold);
                cl.Width = 35;

                String wday = date.DayOfWeek.ToString();
                if (wday == "Saturday")
                {
                    cl.HeaderCell.Style.ForeColor = Color.Blue;
                    cl.HeaderCell.Style.BackColor = Color.Blue;
                }
                else if (wday == "Sunday")
                {
                    cl.HeaderCell.Style.ForeColor = Color.Red;
                    cl.HeaderCell.Style.BackColor = Color.Red;
                    cl.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#D4C1D0");
                }

                dgvSchedule.Columns.Add(cl);

                date = date.AddDays(1);
            }

            //timezone color
            tzColors = new String[100];
            tzShortName = new String[100];
            timezoneIDs = this.frmp.getSelectedTzId();
            for (int i = 0; i < timezoneIDs.Length; i++)
            {
                int tzind = timezoneIDs[i];
                var tz = (from p in db.CpTimeZones where p.Id == tzind select p).FirstOrDefault();
                tzColors[i] = tz.Color;
                tzShortName[i] = tz.Abbreviation;
                int ind = dgvTimezone.Rows.Add("", tz.Abbreviation,
                    ((DateTime)tz.StartTime).ToString("t") + "~" + ((DateTime)tz.EndTime).ToString("t"));
                dgvTimezone.Rows[ind].Cells[0].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(tz.Color);
            }

            this.Width = 1000;
            this.Height = 600;
            dgvTimezone.ClearSelection();

            //Schedule click
            dgvSchedule.CellMouseClick += dgvSchedule_CellMouseClick;
        }

        void dgvSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!editMode) return;

            int row = e.RowIndex, col = e.ColumnIndex;
            if (col < 2) return;
            col -= 2;

            // tim ra la ind bao nhieu trong mang schedule
            int classInd = 0, startRow = 0;
            while (startRow + classTeacher[classInd].Length <= row)
            {
                startRow += classTeacher[classInd].Length;
                classInd++;
            }

            //so ngay
            int dayNumber = (int)toDate.Subtract(fromDate).TotalDays + 1;
            int scheInd = startRow * dayNumber + classTeacher[classInd].Length * col + row - startRow;

            tmpSchedule[scheInd] += 1;
            if (tmpSchedule[scheInd] == timezoneIDs.Length)
            {
                tmpSchedule[scheInd] = -1;
                ((DataGridViewLabelXCell)dgvSchedule[col + 2, row]).Style.BackColor = Color.White;
                dgvSchedule[col + 2, row].Value = "";
            }
            else
            {
                ((DataGridViewLabelXCell)dgvSchedule[col + 2, row]).Style.BackColor =
                                   System.Drawing.ColorTranslator.FromHtml(tzColors[tmpSchedule[scheInd]]);
                dgvSchedule[col + 2, row].Value = tzShortName[tmpSchedule[scheInd]];
            }
            dgvSchedule.ClearSelection();
        }

        private void applyResult(int[] schedule){
            int school_id = VariableGlobal.school_id;
            // Classes Name, Teachers Name
            String[] ClassNames = new String[100];
            String[] TeacherNames = new String[200];
            var cpclass = from p in db.CpClasses where p.SchoolId == school_id select p;
            foreach (var cl in cpclass)
            {
                ClassNames[cl.Id] = cl.Name;
            }
            var cpstaff = from p in db.CpStaffs where p.SchoolId == school_id select p;
            foreach (var staff in cpstaff)
            {
                TeacherNames[staff.Id] = staff.Name;
            }

            for (int i = 0; i < classIDs.Length; i++)
            {
                for (int j = 0; j < classTeacher[i].Length; j++)
                {
                    if (j == 0)
                    {
                        dgvSchedule.Rows.Add(ClassNames[classIDs[i]], TeacherNames[classTeacher[i][j]]);
                    }
                    else
                    {
                        dgvSchedule.Rows.Add("", TeacherNames[classTeacher[i][j]]);
                    }
                }
            }

            int dayNumber = (int)this.toDate.Subtract(this.fromDate).TotalDays + 1;
            int cnt = 0;
            int startRow = 0;
            for (int classcnt = 0; classcnt < classIDs.Length; classcnt++)
            {
                for (int daycnt = 0; daycnt < dayNumber; daycnt++)
                {
                    for (int staffcnt = 0; staffcnt < classTeacher[classcnt].Length; staffcnt++)
                    {
                        if (schedule[cnt] >= 0)
                        {
                            int col = daycnt + 2;
                            int row = startRow + staffcnt;
                            
                            ((DataGridViewLabelXCell)dgvSchedule[col, row]).Style.BackColor =
                                   System.Drawing.ColorTranslator.FromHtml(tzColors[schedule[cnt]]);
                            dgvSchedule[col, row].Value = tzShortName[schedule[cnt]];
                       
                        }
                        cnt++;
                    }
                }
                startRow += classTeacher[classcnt].Length;
            }
        }

        private void clearSchedule()
        {
            dgvSchedule.Rows.Clear();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        // Solution click
        private void btnMethod_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt16(((ButtonX)sender).Name[9] + "");
            if (sel == selecting) return;

            clearSchedule();
            for (int i = 0; i < 4; i++) if (i != sel)
                {
                    ButtonX btn = (ButtonX)this.Controls.Find("btnMethod" + i, true)[0];
                    btn.ColorTable = eButtonColor.BlueWithBackground;
                }

            ((ButtonX)sender).ColorTable = eButtonColor.Office2007WithBackground;

            applyResult(results[sel]);
            selecting = sel;

            // saved?
            if (saved[sel] == 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        //back
        private void buttonX9_Click(object sender, EventArgs e)
        {
            this.frmp.Show();
            this.Dispose();
        }

        // luu trang thai edit
        Boolean editMode = false;
        int[] tmpSchedule;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                editMode = false;
                dgvSchedule.Cursor = Cursors.Default;
                btnCancel.Enabled = false;
                btnEdit.Text = "編集";
                //btnEdit.Symbol = 
                //save
                results[selecting] = tmpSchedule;

                return;
            }

            tmpSchedule = (int[])results[selecting].Clone();
            editMode = true;
            btnCancel.Enabled = true;
            btnEdit.Text = "保存";
            dgvSchedule.Cursor = Cursors.Hand;
        }

        //cancel edit
        private void btnCancel_Click(object sender, EventArgs e)
        {
            editMode = false;
            dgvSchedule.Cursor = Cursors.Default;
            btnCancel.Enabled = false;
            btnEdit.Text = "編集";
            
            //undo edit
            clearSchedule();
            applyResult(results[selecting]);

            return;
        }

        //save schedule to db
        private void btnSave_Click(object sender, EventArgs e)
        {
            // save vao bang CpSchedule, lay ScheduleID
            CpSchedule CpSchedule = new CpSchedule();
            CpSchedule.TermID = this.frmp.getTermID();
            CpSchedule.StartDate = this.fromDate;
            CpSchedule.EndDate = this.toDate;
            CpSchedule.Chosen = 0;
            db.CpSchedules.Add(CpSchedule);
            int scheduleID = CpSchedule.Id;


            // save vao bang CpScheduleDetail
            //Tinh so ngay
            int dayNumber = (int)this.toDate.Subtract(this.fromDate).TotalDays + 1;

            int[] schedule = results[selecting];
            int cnt = 0;
            for (int classcnt = 0; classcnt < classIDs.Length; classcnt++)
            {
                for (int daycnt = 0; daycnt < dayNumber; daycnt++)
                {
                    for (int staffcnt = 0; staffcnt < classTeacher[classcnt].Length; staffcnt++)
                    {
                        int classID = classIDs[classcnt];
                        int teacherID = classTeacher[classcnt][staffcnt];
                        int date = daycnt;

                        CpScheduleDetail CpScheduleD = new CpScheduleDetail();
                        CpScheduleD.ScheduleID = scheduleID;
                        CpScheduleD.ClassID = classID;
                        CpScheduleD.StaffID = teacherID;
                        CpScheduleD.Date = date;
                        // -1 nghi, >=0 dc xep vao timezone nao day
                        if (schedule[cnt] >= 0)
                        {
                            CpScheduleD.TimezoneID = timezoneIDs[schedule[cnt]];
                        }

                        db.CpScheduleDetails.Add(CpScheduleD);

                        cnt++;
                    }
                }
                //startRow += classTeacher[classcnt].Length;
            }

            try
            {
                db.SaveChanges();
                saved[selecting] = 1;
                btnSave.Enabled = false;
                MessageBox.Show("Solution saved !");
                /*ToastNotification.Show(this,
                "更新しました！",
                null,
                3000,
                (eToastGlowColor)(eToastGlowColor.Blue),
                (eToastPosition)(eToastPosition.TopCenter));*/
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnYotei_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FrmShiftYotei(this)).Show();
        }
    }
}
