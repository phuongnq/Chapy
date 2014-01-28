using System;
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
    public partial class FrmShiftYotei : Form
    {
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
        FrmSchedule frmp;

        public int getTermID()
        {
            return (int)this.cmbTerm.SelectedValue;
        }

        int[] scheduleIDs = new int[100];
        int scheduleNum;

        public FrmShiftYotei(FrmSchedule frm)
        {
            InitializeComponent();

            this.frmp = frm;
            initData();
            if (frm != null)
            {
                // lay taninid tu man hinh make schedule
                cmbTerm.SelectedValue = this.frmp.frmp.getTermID();
            }

            int termID = (int)cmbTerm.SelectedValue;

            loadSchedules(termID);

            dgvYotei.CellDoubleClick += dgvYotei_CellDoubleClick;
        }

        void dgvYotei_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            (new FrmScheduleEdit(this, scheduleIDs[e.RowIndex])).Show();
            //MessageBox.Show("View/Edit " + scheduleIDs[e.RowIndex]);
        }

        void initData()
        {
            
            //school name
            int school_id = VariableGlobal.school_id;
            var school = (from p in db.CpSchools where p.Id == school_id select p).SingleOrDefault();
            this.lblSchoolName.Text = school.Code.Trim() + ". " + school.Name;

            // load schedule trong hoc ky nay
            Dictionary<int, string> objterm = new Dictionary<int, string>();
            var terms = from p in db.CpTerms where p.SchoolId == school_id select p;
            foreach (var term in terms)
            {
                objterm.Add(term.Id, term.Name);
                //cmbTanin.Items.Add(new { Value = tanin.Name, Key = tanin.Id });
            }
            cmbTerm.DataSource = new BindingSource(objterm, null);
            cmbTerm.DisplayMember = "Value";
            cmbTerm.ValueMember = "Key";

            cmbTerm.SelectedIndexChanged += cmbTanin_SelectedIndexChanged;
        }

        void cmbTanin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            clearSchedules();
            loadSchedules((int)cmbTerm.SelectedValue);
        }

        void loadSchedules(int termID)
        {
            this.scheduleNum = 0;
            var schedules = from p in db.CpSchedules where p.TermID == termID select p;
            foreach (var schedule in schedules)
            {
                DateTime start = (DateTime)schedule.StartDate,
                    end = (DateTime)schedule.EndDate;
                String chosen = schedule.Chosen == 1 ? "〇" : "";
                dgvYotei.Rows.Add(false, start.Year + "年" + start.Month + "月",
                    start.Month + "月" + start.Day + "日 / " + end.Month + "月" + end.Day + "日", chosen);

                scheduleIDs[scheduleNum] = schedule.Id;
                scheduleNum++;
            }
        }

        void clearSchedules()
        {
            dgvYotei.Rows.Clear();
        }

        void reloadSchedules()
        {
            clearSchedules();
            loadSchedules((int)cmbTerm.SelectedValue);
        }


        //back
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (this.frmp != null)
            {
                this.frmp.Show();
            }
            else
            {
                (new FrmMain()).Show();
            }

            this.Dispose();
        }

        //Select
        private void buttonX3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvYotei.Rows.Count; i++)
            {
                if ((bool)dgvYotei[0, i].Value == true)
                {
                    int schID = scheduleIDs[i];
                    var schedule = (from p in db.CpSchedules where p.Id == schID select p).SingleOrDefault();
                    if (schedule == null) continue;
                    if (schedule.Chosen == 1)
                    {
                        schedule.Chosen = 0;
                        dgvYotei[3, i].Value = "";
                    }
                    else
                    {
                        schedule.Chosen = 1;
                        dgvYotei[3, i].Value = "〇";
                    }
                }
            }

            db.SaveChanges();
        }

        //delete schedules
        private void btnDel_Click(object sender, EventArgs e)
        {
            List<int> selectList = new List<int>();
            String selectIDStr = "";
            for (int i = 0; i < dgvYotei.Rows.Count; i++)
            {
                if ((bool)dgvYotei[0, i].Value == true)
                {
                    selectList.Add(scheduleIDs[i]);
                    selectIDStr += scheduleIDs[i] + ", ";
                }
            }

            if (selectList.Count > 0 && MessageBox.Show("削除してよろしでしょうか " + selectIDStr, "Validate", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                // A 'DialogResult.Yes' value was returned from the MessageBox
                delSchedules(selectList);

            }
        }

        private void delSchedules(List<int> selectIDs)
        {
            foreach (int scheduleID in selectIDs)
            {
                var scheD = from p in db.CpScheduleDetails where p.ScheduleID == scheduleID select p;
                foreach (var sched in scheD)
                {
                    db.CpScheduleDetails.Remove(sched);
                }

                var sche = (from p in db.CpSchedules where p.Id == scheduleID select p).SingleOrDefault();
                db.CpSchedules.Remove(sche);

            }

            db.SaveChanges();
            reloadSchedules();

            MessageBox.Show("Deleted!");
        }
    }
}
