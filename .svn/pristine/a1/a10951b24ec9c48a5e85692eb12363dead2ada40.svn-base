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
        chapyEntities db = new chapyEntities();
        FrmMakeShift frmp;
        Hashtable jaWeekday;

        int[] classIDs;
        int[][] classTeacher;
        DateTime fromDate, toDate;
        String[] tzColors, tzShortName;
        int[][] results;

        int selecting;
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
            results = cs.getResult();
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
            var cptz = from p in db.CpTimeZones select p;
            foreach (var tz in cptz)
            {
                tzColors[tz.Id] = tz.Color;
                tzShortName[tz.Id] = tz.Abbreviation;
                int ind = dgvTimezone.Rows.Add("", tz.Abbreviation,
                    ((DateTime)tz.StartTime).ToString("t") + "~" + ((DateTime)tz.EndTime).ToString("t"));
                dgvTimezone.Rows[ind].Cells[0].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(tz.Color);
            }

            this.Width = 1000;
            this.Height = 600;
            dgvTimezone.ClearSelection();
        }

        private void applyResult(int[] schedule){
            // Classes Name, Teachers Name
            String[] ClassNames = new String[100];
            String[] TeacherNames = new String[200];
            var cpclass = from p in db.CpClasses select p;
            foreach (var cl in cpclass)
            {
                ClassNames[cl.Id] = cl.Name;
            }
            var cpstaff = from p in db.CpStaffs select p;
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
                        if (schedule[cnt] > 0)
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
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            this.frmp.Show();
            this.Dispose();
        }
    }
}
