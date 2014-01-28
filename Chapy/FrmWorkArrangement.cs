using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using System.Threading;

namespace Chapy
{
    public partial class FrmWorkArrangement : Form
    {
        //database access
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
        String[] Weekdays = { "月", "火", "水", "木", "金", "土", "日" };
        int termID;

        int ok;

        public FrmWorkArrangement()
        {
            InitializeComponent();
            ok = initForm();

            //event handler
            wArgtGridView.CellClick += wArgtGridView_CellClick;
            wArgtGridView.CellMouseEnter += wArgtGridView_CellMouseEnter;
        }

        private void FrmWorkArrangement_Load(object sender, EventArgs e)
        {
            if (ok != 0)
            {
                this.Dispose();
                (new FrmMain()).Show();
            }
        }

        public int getTermID()
        {
            return this.termID;
        }

        int initForm()
        {
            //school name
            int school_id = VariableGlobal.school_id;
            var school = (from p in db.CpSchools where p.Id == school_id select p).SingleOrDefault();
            if (school == null)
            {
                MessageBox.Show("施設を設定してから選択してください");
                return 1;
            }
            this.lblSchoolName.Text = school.Code.Trim() + ". " + school.Name;

            // load schedule trong hoc ky nay
            Dictionary<int, string> objterm = new Dictionary<int, string>();
            var terms = from p in db.CpTerms where p.SchoolId == school_id select p;
            if (terms.Any())
            {
                foreach (var term in terms)
                {
                    objterm.Add(term.Id, term.Name);
                    //cmbTanin.Items.Add(new { Value = tanin.Name, Key = tanin.Id });
                }
                cmbTerm.DataSource = new BindingSource(objterm, null);
                cmbTerm.DisplayMember = "Value";
                cmbTerm.ValueMember = "Key";
            }
            else
            {
                MessageBox.Show("Dang ky term truoc di");
                return 1;
            }

            wArgtGridView.Columns[2].HeaderText = "勤務形態\n名前";
            wArgtGridView.Columns[6].HeaderText = "勤務時間\n開始／終了";
            wArgtGridView.Columns[7].HeaderText = "休憩時間①\n開始／終了";
            wArgtGridView.Columns[8].HeaderText = "休憩時間②\n開始／終了";

            for (int i = 0; i < wArgtGridView.Columns.Count; i++)
            {
                wArgtGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //read staffType
            Dictionary<int, string> objtype = new Dictionary<int, string>();
            var stafftype = from p in db.CpStaffTypes where p.SchoolId == school_id select p;
            if (stafftype.Any())
            {
                foreach (var type in stafftype)
                {
                    objtype.Add(type.Id, type.Name);
                }
                cmbStaffType.DataSource = new BindingSource(objtype, null);
                cmbStaffType.DisplayMember = "Value";
                cmbStaffType.ValueMember = "Key";
            }
            else
            {
                MessageBox.Show("Dang ky staff type truoc di");
                return 1;
            }

            //this.wArgtGridView.Rows.Add("five", "six", "seven", "eight"); this.wArgtGridView.Rows.Insert(0, "one", "two", "three", "four");

            //read timezone
            var worktimes = from p in db.CpTimeZones where p.SchoolId == school_id select p;
            foreach (var wt in worktimes)
            {
                int ind = this.wArgtGridView.Rows.Add("編集", wt.Code, wt.Name, wt.Abbreviation, "", wt.DayOfWeeks,
                    ((DateTime)wt.StartTime).ToString("t") + " / " + ((DateTime)wt.EndTime).ToString("t"),
                    ((DateTime)wt.RestStartTime1).ToString("t") + " / " + ((DateTime)wt.RestEndTime1).ToString("t"),
                    ((DateTime)wt.RestStartTime2).ToString("t") + " / " + ((DateTime)wt.RestEndTime2).ToString("t"),
                    "Zenclass");

                //Color
                wArgtGridView.Rows[ind].Cells[4].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(wt.Color);

                //Weekday
                String weekdays = "";
                for (int i = 0; i < 7 && i < wt.DayOfWeeks.Length; i++) if (wt.DayOfWeeks[i] == '1')
                    {
                        weekdays += Weekdays[i] + " / ";
                    }
                wArgtGridView.Rows[ind].Cells[5].Value = weekdays;
            }

            return 0;
        }

        void wArgtGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void wArgtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == wArgtGridView.RowCount) return;

            if (e.ColumnIndex == 0)
            {   // Go to edit
                DataGridViewTextBoxCell codeCell = (DataGridViewTextBoxCell)wArgtGridView[1, e.RowIndex];
                this.termID = (int)cmbTerm.SelectedValue;
                (new FrmWorkArrangementDetail(this, (String)codeCell.Value)).Show();
                this.Dispose();
            }

            if (e.ColumnIndex == 4)
            {   // Color
                wArgtGridView.ClearSelection();
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.termID = (int)cmbTerm.SelectedValue;
            (new FrmWorkArrangementDetail(this, null)).Show();
            this.Dispose();
        }

        public void reload()
        {
            wArgtGridView.DataSource = null;
            wArgtGridView.Rows.Clear();
            initForm();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        //Delete
        private void buttonX2_Click(object sender, EventArgs e)
        {
            //Neu chua chon show message
            if (wArgtGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("勤務形態を選択してください");
                return;
            }

            int ind = wArgtGridView.SelectedCells[0].RowIndex;
            if (MessageBox.Show("削除してよろしでしょうか " + ind, "Validate", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (ind < 0 || ind >= wArgtGridView.RowCount - 1) return;

            String code = ((String)wArgtGridView[1, ind].Value).Trim();
            var wt = (from p in db.CpTimeZones where code == p.Code.Trim() select p).FirstOrDefault();
            if (wt == null) return;

            try
            {
                db.CpTimeZones.Remove(wt);
                db.SaveChanges();
                reload();
                ToastNotification.Show(this,
                "削除しました！",
                null,
                3000,
                (eToastGlowColor)(eToastGlowColor.Blue),
                (eToastPosition)(eToastPosition.TopCenter));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowFormMain)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowFormMain()
        {
            (new FrmMain()).Show();
        }



    }
}
