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
    public partial class FrmScheduleEdit : Form
    {
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
        FrmShiftYotei frmp;

        Hashtable jaWeekday;
        int[] schedule, timezoneIDs;
        String[] tzShorts, tzColors;
        int termID, tzCnt, scheduleLen;

        public FrmScheduleEdit(FrmShiftYotei frm, int scheduleID)
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
            initForm(scheduleID); // load combobox

            cmbSchedule.SelectedValue = scheduleID;
            loadSchedule(scheduleID);
        }

        void initForm(int scheduleID)
        {
            var scheduleRc = (from p in db.CpSchedules where p.Id == scheduleID select p).SingleOrDefault();
            this.termID = scheduleRc.TermID;

            Dictionary<int, string> objschedule = new Dictionary<int, string>();
            var schedules = from p in db.CpSchedules where p.TermID == this.termID select p;
            foreach (var schedule in schedules)
            {
                DateTime start = (DateTime)schedule.StartDate;
                objschedule.Add(schedule.Id, start.Year + "年" + start.Month + "月");
                //cmbTanin.Items.Add(new { Value = tanin.Name, Key = tanin.Id });
            }
            cmbSchedule.DataSource = new BindingSource(objschedule, null);
            cmbSchedule.DisplayMember = "Value";
            cmbSchedule.ValueMember = "Key";
        }

        void loadSchedule(int scheduleID)
        {
            dgvTimezone.Rows.Clear();
            dgvSchedule.Rows.Clear();

            //school name
            int school_id = VariableGlobal.school_id;
            var school = (from p in db.CpSchools where p.Id == school_id select p).SingleOrDefault();
            this.lblSchoolName.Text = school.Code.Trim() + ". " + school.Name;

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

            //doc record schedule, lay fromDate, toDate
            var scheduleRc = (from p in db.CpSchedules where p.Id == scheduleID select p).SingleOrDefault();
            DateTime fromDate = (DateTime)scheduleRc.StartDate,
                toDate = (DateTime)scheduleRc.EndDate;

            //update label time
            String rangeTimeStr = "平成" + (fromDate.Year - 1988) + "年" + fromDate.Month + "月"
                + fromDate.Day + "日" + "(" + jaWeekday["" + fromDate.DayOfWeek] + ")";
            rangeTimeStr += " ~ " + toDate.Month + "月"
                + toDate.Day + "日" + "(" + jaWeekday["" + toDate.DayOfWeek] + ")";
            lbTimeRange.Text = rangeTimeStr;

            //add them cac cot ngay vao dgvSchedule
            DateTime date = fromDate;
            while (date <= toDate)
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

            //doc tat ca cac scheduleDetail bang scheduleID
            var scheduleDetails = from p in db.CpScheduleDetails where p.ScheduleID == scheduleID orderby p.Id select p;

            //khoi tao classid trc, date trc
            int preClassID = -1, preDate = -1;

            //khoi tao mang schedule
            schedule = new int[scheduleDetails.Count()];
            scheduleLen = 0;

            //khoi tao timezoneIDs, chua biet co bao nhieu ca lam viec
            timezoneIDs = new int[20];
            tzShorts = new String[20];
            tzColors = new String[20];
            tzCnt = 0;

            // index dong dau tien cua lop hien tai, update khi sang lop moi
            int startRow = 0;

            // so dem giao vien, reset khi chuyen sang ngay moi
            int staffCnt = -1;

            foreach (var schD in scheduleDetails)
            {
                //duyet tao data cho cac bang schedule, classIDs, classTeacher, timezoneIDs

                //tim index cua timezone, neu ko ton tai gan them
                int i = -1;
                if (schD.TimezoneID >= 0)
                {
                    for (i = 0; i < tzCnt; i++)
                    {
                        if (timezoneIDs[i] == schD.TimezoneID) break;
                    }
                    if (i == tzCnt)
                    {
                        timezoneIDs[i] = (int)schD.TimezoneID;
                        var tz = (from p in db.CpTimeZones where p.Id == schD.TimezoneID select p).SingleOrDefault();
                        tzShorts[i] = tz.Abbreviation;
                        tzColors[i] = tz.Color;

                        //add vao grid timezone
                        int ind = dgvTimezone.Rows.Add("", tz.Abbreviation,
                        ((DateTime)tz.StartTime).ToString("t") + "~" + ((DateTime)tz.EndTime).ToString("t"));
                        dgvTimezone.Rows[ind].Cells[0].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(tz.Color);

                        tzCnt++;
                    }
                }

                //neu chuyen lop moi, viet ten lop o dau, update startRow
                String classStr = "" ;
                if (schD.ClassID != preClassID)
                {
                    classStr = "" + ClassNames[schD.ClassID];
                    startRow += staffCnt + 1;
                    
                }

                //neu chuyen ngay moi, reset staffCnt, neu ko, tang them 1
                staffCnt = schD.Date == preDate ? staffCnt + 1 : 0;

                //if (schD.ClassID == 4) break;//debug

                //neu la ngay 0 add them row
                if (schD.Date == 0)
                {
                    dgvSchedule.Rows.Add(classStr, TeacherNames[schD.StaffID]);
                }
                // neu ko, gan vao dgvSchedule
                else
                {
                    //dgvSchedule[schD.Date + 2, startRow + staffCnt].Value = schD.TimezoneID;
                }

                //gan ten, mau
                if (i >= 0)
                {
                    dgvSchedule[schD.Date + 2, startRow + staffCnt].Value = tzShorts[i];
                    ((DataGridViewLabelXCell)dgvSchedule[schD.Date + 2, startRow + staffCnt]).Style.BackColor =
                                       System.Drawing.ColorTranslator.FromHtml(tzColors[i]);
                }

                
                //update schedule, scheduleLen, preDate, preClassID
                schedule[scheduleLen] = i;
                scheduleLen++;
                preDate = schD.Date;
                preClassID = schD.ClassID;

                
            }

            

            //tu timezoneIDs tinh ra tzShortname, tzColors
        }
    }
}
