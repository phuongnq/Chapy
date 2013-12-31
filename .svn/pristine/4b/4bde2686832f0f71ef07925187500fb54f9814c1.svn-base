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
    public partial class FrmEachTeacherSetting : Form
    {
        FrmMakeShift frmMakeShift;
        int[] staffIds;
        DateTime fromDate_, toDate_;
        int DayNumber, curStaffID = 0;
        Hashtable WeekDay, JaWeekday, staffAvaiDate;

        public FrmEachTeacherSetting(FrmMakeShift frm)
        {
            InitializeComponent();

            WeekDay = new Hashtable();
            WeekDay["Sunday"] = 6;
            WeekDay["Monday"] = 0;
            WeekDay["Tuesday"] = 1;
            WeekDay["Wednesday"] = 2;
            WeekDay["Thursday"] = 3;
            WeekDay["Friday"] = 4;
            WeekDay["Saturday"] = 5;

            JaWeekday = new Hashtable();
            JaWeekday["Sunday"] = "日";
            JaWeekday["Monday"] = "月";
            JaWeekday["Tuesday"] = "火";
            JaWeekday["Wednesday"] = "水";
            JaWeekday["Thursday"] = "木";
            JaWeekday["Friday"] = "金";
            JaWeekday["Saturday"] = "土";

            this.frmMakeShift = frm;
            this.fromDate_ = frm.getFromDate();
            this.toDate_ = frm.getToDate();
            if (frm.getStaffAvaiDate() != null)
            { this.staffAvaiDate = (Hashtable)frm.getStaffAvaiDate().Clone(); }

            DayNumber = this.toDate_.Subtract(this.fromDate_).Days + 1;

            initFrm();

        }

        /*
         * 
         */
        public void setStaffIds(int[] staffId)
        {
            this.staffIds = staffId;

            // Read Staffs from parent form
            dgvStaff.Rows.Clear();
            for (int i = 0; i < this.staffIds.Length; i++)
            {
                dgvStaff.Rows.Add(this.frmMakeShift.staffName[this.staffIds[i]]);
            }
        }

        void initFrm()
        {
            String rangeTimeStr = "平成" + (this.fromDate_.Year - 1988) + "年" + this.fromDate_.Month + "月"
                + this.fromDate_.Day + "日" + "(" + JaWeekday["" + this.fromDate_.DayOfWeek] + ")";
            rangeTimeStr += " ~ " + this.toDate_.Month + "月"
                + this.toDate_.Day + "日" + "(" + JaWeekday["" + this.toDate_.DayOfWeek] + ")";

            lbDate.Text = rangeTimeStr;
            dgvStaff.ClearSelection();
            dgvStaff.CellMouseClick += dgvStaff_Click;
            dgvDate.CellMouseClick += dgvDate_CellMouseClick;
            if (this.staffAvaiDate == null) this.staffAvaiDate = new Hashtable();
        }

        void dgvDate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //throw new NotImplementedException();
            DataGridViewButtonCell btc = (DataGridViewButtonCell)dgvDate[e.ColumnIndex, e.RowIndex];
            if (btc.Style.BackColor == Color.FromArgb(255, 128, 128))
            {
                btc.Style.BackColor = Color.FromArgb(128, 255, 128);
            }
            else
            {
                btc.Style.BackColor = Color.FromArgb(255, 128, 128);
            }
            

            DateTime date = this.fromDate_;
            int stR = 0, stC = (int)WeekDay[date.DayOfWeek + ""], cnt = 0;
            String avaiDate = "";
            while (cnt < DayNumber)
            {
                btc = (DataGridViewButtonCell)dgvDate[stC, stR];
                avaiDate += btc.Style.BackColor == Color.FromArgb(255, 128, 128) ? "X" : "O";
                cnt++;
                stC++;
                if (stC > 6)
                {
                    stC = 0;
                    stR++;
                }
            }

            if (this.staffAvaiDate == null) this.staffAvaiDate = new Hashtable();
            this.staffAvaiDate[curStaffID] = avaiDate;

            dgvDate.ClearSelection();
        }

        void dgvStaff_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            //throw new NotImplementedException();
            
            curStaffID = staffIds[e.RowIndex];
            viewStaff(curStaffID);
        }

        void viewStaff(int id)
        {
            dgvDate.Rows.Clear();

            for (int i = 0; i < dgvDate.Columns.Count; i++)
            {
                DataGridViewButtonColumn cl = (DataGridViewButtonColumn)dgvDate.Columns[i];
                cl.FlatStyle = FlatStyle.Popup;
                if (i == 6)
                {
                    cl.HeaderCell.Style.ForeColor = Color.Red;
                }
                else if (i == 5)
                {
                    cl.HeaderCell.Style.ForeColor = Color.Blue;
                }
            }



            lbStaff.Text = this.frmMakeShift.staffName[id];
            String avaiDate = null;
            if (this.staffAvaiDate != null && this.staffAvaiDate.ContainsKey(id))
            {
                avaiDate = (String)staffAvaiDate[id];
            }

            DateTime date = this.fromDate_;
            int stR = 0, stC = (int)WeekDay[date.DayOfWeek + ""], cnt = 0;
            dgvDate.Rows.Add("");
            int curm = 0;
            while (date <= this.toDate_)
            {
                if (date.Month == curm)
                {
                    dgvDate[stC, stR].Value = date.Day;
                }
                else
                {
                    curm = date.Month;
                    dgvDate[stC, stR].Value = curm + "月/" + date.Day;
                }

                if (avaiDate != null && cnt < avaiDate.Length && avaiDate[cnt] == 'X')
                {
                    dgvDate[stC, stR].Style.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    dgvDate[stC, stR].Style.BackColor = Color.FromArgb(128, 255, 128);
                }

                date = date.AddDays(1);
                cnt++;
                stC++;
                if (stC > 6)
                {
                    stC = 0;
                    stR++;
                    dgvDate.Rows.Add("");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmMakeShift.Show();
            this.Dispose();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.frmMakeShift.staffAvaiDate = this.staffAvaiDate;
            this.frmMakeShift.Show();
            this.Dispose();
        }
    }

}
