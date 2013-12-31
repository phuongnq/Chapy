using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model;
using System.Net;
using System.Xml.Linq;


namespace Chapy
{
    public partial class FrmHoliday : Form
    {
        private Int32 D_SCHOOL_ID = 0;
        static List<DateTime> listHolidays;
        chapyEntities db = new chapyEntities();
        public FrmHoliday()
        {
            InitializeComponent();
            #region khoi tao combobox
            int year_now = DateTime.Now.Year;
            Dictionary<int, string> dataSource = new Dictionary<int, string>();
            dataSource.Add(0, "-----------------");
            dataSource.Add((year_now - 2), (year_now - 2).ToString());
            dataSource.Add((year_now - 1), (year_now - 1).ToString());
            dataSource.Add(year_now, year_now.ToString());
            dataSource.Add((year_now + 1), (year_now + 1).ToString());
            dataSource.Add((year_now + 2), (year_now + 2).ToString());
            dataSource.Add((year_now + 3), (year_now + 3).ToString());
            cb_year.DataSource = new BindingSource(dataSource, null);
            cb_year.DisplayMember = "Value";
            cb_year.ValueMember = "Key";

            #endregion
            D_SCHOOL_ID = VariableGlobal.school_id;
        }

        private void advTree1_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            int year = int.Parse(cb_year.SelectedValue.ToString());
            if (year == 0)
            {
                year = DateTime.Now.Year;
            }

            try
            {

                if (e.Node.Name == "node_weeken")
                {

                    List<DateTime> weekensInYear = getAllWeekDates(year);

                    int count = 0;
                    foreach (DateTime dt in weekensInYear)
                    {


                        DateTime sunday = dt;
                        DateTime saturday = dt.AddDays(-1);
                        var check_sunday = (from h in db.CpHolidays where h.Date == sunday select h).SingleOrDefault();
                        var check_saturday = (from h in db.CpHolidays where h.Date == saturday select h).SingleOrDefault();

                        if (saturday.Year == year && (check_saturday == null))
                        {
                            AddAppointment("Saturday", saturday, saturday, "#FF0000", "");
                            CpHoliday holiday = new CpHoliday();
                            holiday.Date = saturday;
                            holiday.Reason = "Saturday";
                            holiday.SchoolId = D_SCHOOL_ID;
                            db.CpHolidays.Add(holiday);
                            db.SaveChanges();
                            count++;
                        }

                        if (check_sunday == null)
                        {
                            AddAppointment("Sunday", sunday, sunday, "#FF0000", "");
                            CpHoliday holiday = new CpHoliday();
                            holiday.Date = sunday;
                            holiday.Reason = "Sunday";
                            holiday.SchoolId = D_SCHOOL_ID;
                            db.CpHolidays.Add(holiday);
                            db.SaveChanges();
                            count++;
                        }

                    }


                } if (e.Node.Name == "holiday")
                {

                    var listJanpanHolidays = (from jh in db.JapanHolidays where jh.Year == year select jh).ToList();

                    int c = 1;
                    foreach (var holiday in listJanpanHolidays)
                    {
                        var check_holiday = (from h in db.CpHolidays where h.Date == holiday.Date && h.SchoolId == D_SCHOOL_ID select h).SingleOrDefault();

                        if (check_holiday == null)
                        {
                            AddAppointment(holiday.Name.ToString(), (DateTime)holiday.Date, (DateTime)holiday.Date, "", "");
                            CpHoliday new_holiday = new CpHoliday();
                            new_holiday.Date = holiday.Date;
                            new_holiday.Reason = holiday.Name;
                            new_holiday.SchoolId = D_SCHOOL_ID;
                            db.CpHolidays.Add(new_holiday);
                            db.SaveChanges();
                            c++;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        /// <summary>
        /// Adds the specified appointment to the model
        /// </summary>
        /// <param name="s">Appointment subject</param>
        /// <param name="startTime">Appointment start time</param>
        /// <param name="endTime">Appointment end time</param>
        /// <param name="color">Appointment color</param>
        /// <param name="marker">Appointment marker</param>
        private bool AddAppointment(string s,
            DateTime startTime, DateTime endTime, string color, string marker)
        {

            Appointment appointment = new Appointment();
            appointment.Subject = s;
            appointment.StartTime = startTime;
            appointment.EndTime = endTime;
            calendarView.CalendarModel.Appointments.Add(appointment);

            return true;

        }


        ///
        /// This function will return all the dates of sundays in a Year 
        /// for example if you pass if year is 2009 
        /// it will return all the dates of sundays in the year in form of list 
        ///

        /// Year 
        /// List all dates of sundays in form of list string 
        public List<DateTime> getAllWeekDates(int Year)
        {
            if (Year == 0)
            {
                Year = DateTime.Now.Year;
            }
            List<DateTime> strDates = new List<DateTime>();
            for (int month = 1; month <= 12; month++)
            {
                DateTime dt = new DateTime(Year, month, 1);

                int firstSundayOfMonth = (int)dt.DayOfWeek;

                if (firstSundayOfMonth != 0)
                {
                    dt = dt.AddDays((6 - firstSundayOfMonth) + 1);
                }


                while (dt.Month == month)
                {
                    strDates.Add(dt);

                    dt = dt.AddDays(7);
                }


            }
            return strDates;
        }

        private void calendarView_YearViewDrawDayBackground(object sender, YearViewDrawDayBackgroundEventArgs e)
        {
            Graphics g = e.Graphics;
            if (e.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                g.FillRectangle(Brushes.Aquamarine, e.Bounds);
            }
            else if (e.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                g.FillRectangle(Brushes.Red, e.Bounds);
            }
        }

        private void FrmHoliday_Load(object sender, EventArgs e)
        {
            int year_now = DateTime.Now.Year;

            calendarView.YearViewStartDate = new DateTime(year_now, 01, 01);
            calendarView.YearViewEndDate = new DateTime(year_now, 12, 31);

            var holidays = (from h in db.CpHolidays where h.Date.Value.Year == year_now select h).ToList();

            //listHolidays.Clear();
            foreach (var h in holidays)
            {
                //listHolidays.Add((DateTime)h.Date);
                AddAppointment(h.Reason, (DateTime)h.Date, (DateTime)h.Date, "", "");
            }
        }

        private void cb_year_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_year.SelectedIndex > 0)
            {
                int year = ((KeyValuePair<int, string>)cb_year.SelectedItem).Key;
                calendarView.YearViewStartDate = new DateTime(year, 01, 01);
                calendarView.YearViewEndDate = new DateTime(year, 12, 31);
            }
        }

        private void calendarView_ItemClick(object sender, EventArgs e)
        {
            DateTime startDate = calendarView.DateSelectionStart.GetValueOrDefault();

            Appointment appointment = (from ap in calendarView.CalendarModel.Appointments where ap.StartTime == startDate select ap).SingleOrDefault();

            if (appointment != null)
            {
                txt_Name.Text = appointment.Subject;
            }
            else
            {
                txt_Name.Text = "";
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DateTime startDate = calendarView.DateSelectionStart.GetValueOrDefault();
            DateTime endDate = calendarView.DateSelectionEnd.GetValueOrDefault();

            if (txt_Name.Text != "")
            {
                int insert = 0;
                int update = 0;
                for (DateTime date = startDate; date < endDate; date = date.AddDays(1.0))
                {
                    Appointment appointment = (from ap in calendarView.CalendarModel.Appointments where ap.StartTime == date select ap).SingleOrDefault();

                    //create new appointment
                    if (appointment == null)
                    {
                        AddAppointment(txt_Name.Text, date, date, "", "");

                        CpHoliday holiday = new CpHoliday();
                        holiday.Date = date;
                        holiday.Reason = txt_Name.Text;

                        db.CpHolidays.Add(holiday);
                        db.SaveChanges();

                        
                        insert++;

                    }
                    else if (txt_Name.Text != appointment.Subject)
                    {
                        appointment.Subject = txt_Name.Text;
                        CpHoliday holiday = (from h in db.CpHolidays where h.Date == date select h).SingleOrDefault();
                        holiday.Reason = txt_Name.Text;
                        db.SaveChanges();
                        update++;

                    }
                }
                if (insert > 0)
                {
                    MessageBox.Show("Create holiday successfull");
                    txt_Name.Text = "";
                }
                else if (update > 0)
                {
                    MessageBox.Show("Update holiday successfull");
                }
                //string wACode = "haha";
                //var a = from p in db.CpTimeZones where wACode == p.Code.Trim() select p;
            }
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close this form! Data will be loose ??", "Confirm Close!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
