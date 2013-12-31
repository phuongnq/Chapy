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

namespace Chapy
{
    public partial class FrmMakeShift : Form
    {
        //database access
        chapyEntities db = new chapyEntities();
        String[] Weekdays = { "月", "火", "水", "木", "金", "土", "日" };

        public FrmAllTeacherSetting frmallst = null;
        FrmEachTeacherSetting frmeachlst = null;

        public int[] staffId = new int[100];
        int[] timezoneID = new int[100];
        int[] selectedStaffId, selectedTzId;
        public string[] staffName = new String[200];

        DateTime fromDate, toDate;

        public Hashtable staffAvaiDate;    // Store available day for (chosen)teachers

        public int[] getSelectedStaffId()
        {
            return selectedStaffId;
        }
        public int[] getSelectedTzId()
        {
            return selectedTzId;
        }
        public DateTime getFromDate()
        {
            return this.fromDate;
        }
        public DateTime getToDate()
        {
            return this.toDate;
        }
        public Hashtable getStaffAvaiDate()
        {
            return this.staffAvaiDate;
        }

        public FrmMakeShift()
        {
            InitializeComponent();

            this.staffAvaiDate = null;
            initFormData();
        }

        private void initFormData()
        {
            //school name
            int school_id = VariableGlobal.school_id;
            var school = (from p in db.CpSchools where p.Id == school_id select p).SingleOrDefault();
            this.lblSchoolName.Text = school.Code.Trim() + ". " + school.Name;

            // init date
            DateTime today = DateTime.Today;
            tbFYear.Text = "" + today.Year;
            tbFMonth.Text = "" + today.Month;
            tbFDay.Text = "" + today.Day;

            DateTime aMonthAfter = today.AddMonths(1);
            tbTYear.Text = "" + aMonthAfter.Year;
            tbTMonth.Text = "" + aMonthAfter.Month;
            tbTDay.Text = "" + aMonthAfter.Day;


            //read staffType
            var stafftype = from p in db.CpStaffTypes select p;
            cmbStaffType.DisplayMember = "Text";
            cmbStaffType.ValueMember = "Value";
            cmbStaffType.Items.Add(new { Text = "全員", Value = 0 });
            foreach (var type in stafftype)
            {
                cmbStaffType.Items.Add(new { Text = type.Name, Value = type.Id });
            }

            //read staff
            var staffs = from p in db.CpStaffs where p.SchoolId == school_id select p;
            foreach (var staff in staffs)
            {
                int ind = dgvStaff.Rows.Add(false, staff.Name);
                staffId[ind] = staff.Id;
                staffName[staff.Id] = staff.Name;
            }

            //Read Work Arrangment (timezone)
            var was = from p in db.CpTimeZones where p.SchoolId == school_id select p;
            foreach (var wa in was)
            {
                int ind = dgvWA.Rows.Add(false, wa.Name);
                timezoneID[ind] = wa.Id;
            }
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        //check all
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                ((DataGridViewCheckBoxCell)dgvStaff[0, i]).Value = true;
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                ((DataGridViewCheckBoxCell)dgvStaff[0, i]).Value = false;
            }
        }

        private void btnSettingAll_Click(object sender, EventArgs e)
        {
            this.fromDate = new DateTime(Convert.ToInt16(tbFYear.Text), Convert.ToInt16(tbFMonth.Text),
                Convert.ToInt16(tbFDay.Text));
            this.toDate = new DateTime(Convert.ToInt16(tbTYear.Text), Convert.ToInt16(tbTMonth.Text),
                Convert.ToInt16(tbTDay.Text));

            int count = 0;
            for (int i = 0; i < dgvStaff.RowCount; i ++){
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvStaff[0,i];
                if ( (Boolean)a.Value == true ) count++;
            }
            selectedStaffId = new int[count];
            count = 0;
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvStaff[0, i];
                if (a.Value != null && (Boolean)a.Value)
                {
                    selectedStaffId[count] = staffId[i];
                    count++;
                }
            }

            if (this.frmallst == null)
            {
                this.frmallst = new FrmAllTeacherSetting(this, fromDate, toDate);
            }

            this.Hide();
            this.frmallst.setStaffIds(selectedStaffId);
            this.frmallst.loadStaffDate();
            this.frmallst.Show();
            //frmallst.getStaffAvaiDate();
        }

        private void btnMakeSchedule_Click(object sender, EventArgs e)
        {
            //Selected Staff ID
            int count = 0;
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvStaff[0, i];
                if ((Boolean)a.Value == true) count++;
            }
            selectedStaffId = new int[count];
            count = 0;
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvStaff[0, i];
                if (a.Value != null && (Boolean)a.Value)
                {
                    selectedStaffId[count] = staffId[i];
                    count++;
                }
            }

            //Selected Timezone ID
            count = 0;
            for (int i = 0; i < dgvWA.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvWA[0, i];
                if ((Boolean)a.Value == true) count++;
            }
            selectedTzId = new int[count];
            count = 0;
            for (int i = 0; i < dgvWA.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvWA[0, i];
                if (a.Value != null && (Boolean)a.Value)
                {
                    selectedTzId[count] = timezoneID[i];
                    count++;
                }
            }

            this.fromDate = new DateTime(Convert.ToInt16(tbFYear.Text), Convert.ToInt16(tbFMonth.Text),
                Convert.ToInt16(tbFDay.Text));
            this.toDate = new DateTime(Convert.ToInt16(tbTYear.Text), Convert.ToInt16(tbTMonth.Text),
                Convert.ToInt16(tbTDay.Text));

            this.Hide();
            (new FrmSchedule(this)).Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            (new FrmMain()).Show();
        }

        private void btnSettingPer_Click(object sender, EventArgs e)
        {
            //Selected Staff ID
            int count = 0;
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvStaff[0, i];
                if ((Boolean)a.Value == true) count++;
            }
            selectedStaffId = new int[count];
            count = 0;
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                DataGridViewCheckBoxCell a = (DataGridViewCheckBoxCell)dgvStaff[0, i];
                if (a.Value != null && (Boolean)a.Value)
                {
                    selectedStaffId[count] = staffId[i];
                    count++;
                }
            }

            this.fromDate = new DateTime(Convert.ToInt16(tbFYear.Text), Convert.ToInt16(tbFMonth.Text),
                Convert.ToInt16(tbFDay.Text));
            this.toDate = new DateTime(Convert.ToInt16(tbTYear.Text), Convert.ToInt16(tbTMonth.Text),
                Convert.ToInt16(tbTDay.Text));
            this.Hide();

            this.frmeachlst = new FrmEachTeacherSetting(this);
            this.frmeachlst.setStaffIds(selectedStaffId);
            this.frmeachlst.Show();
        }
    }
}
