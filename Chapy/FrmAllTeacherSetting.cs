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
    public partial class FrmAllTeacherSetting : Form
    {
        //database access
        chapyEntities db = new chapyEntities();
        Hashtable jaWeekday, staffAvaiDate;

        public FrmMakeShift frmMakeShift;
        public DateTime fromDate_, toDate_; 

        public int[] staffIds;

        public FrmAllTeacherSetting(FrmMakeShift frm, DateTime fDate, DateTime tDate)
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

            this.frmMakeShift = frm;
            this.fromDate_ = fDate;
            this.toDate_ = tDate;
            this.staffIds = null;
            this.staffAvaiDate = this.frmMakeShift.staffAvaiDate;

            initForm();

            //event
            dgvStaff.CellMouseClick += dgvStaff_CellMouseClick;
        }

        /*
         * Set staffids array and load their name to datagird
         */
        public void setStaffIds(int[] staffId)
        {
            this.staffIds = staffId;

            // Read Staffs from parent form
            dgvStaff.Rows.Clear();
            for (int i = 0; i < this.staffIds.Length; i++)
            {
                dgvStaff.Rows.Add(this.frmMakeShift.staffName[this.staffIds[i]], "O", "X");
            }
        }

        /*
         * Load all chosen staff available date which is saved in "staffAvaiDate" to datagrid
         * (Call after setStaffIds)
         */
        public void loadStaffDate()
        {
            
            if (this.staffAvaiDate == null) return;
            for (int i = 0; i < this.staffIds.Length; i++) if (this.staffAvaiDate[this.staffIds[i]] != null)
            {
                String avaiDate = (String)this.staffAvaiDate[this.staffIds[i]];
                for (int j = 0; j < avaiDate.Length; j++) if (avaiDate[j]=='X' && dgvStaff[j + 3, i] != null)
                    {
                        dgvStaff[j + 3, i].Value = "" + avaiDate[j];
                    }
            }
        }

        //Click
        void dgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.RowIndex < 0 || e.RowIndex >= dgvStaff.RowCount - 1) return;

            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                String tick = e.ColumnIndex == 1 ? null : "X";
                for (int i = 3; i < dgvStaff.ColumnCount; i++)
                {
                    dgvStaff[i, e.RowIndex].Value = tick;
                }
            }

            if (e.ColumnIndex > 2)
            {
                String cval = dgvStaff[e.ColumnIndex, e.RowIndex].Value == null ?
                    "" : ((String)dgvStaff[e.ColumnIndex, e.RowIndex].Value).Trim();
                dgvStaff[e.ColumnIndex, e.RowIndex].Value = cval == "X" ? "O" : "X";
            }
        }

        private void initForm()
        {

            String rangeTimeStr = "平成" + (this.fromDate_.Year - 1988) + "年" + this.fromDate_.Month + "月"
                + this.fromDate_.Day + "日" + "(" + jaWeekday["" + this.fromDate_.DayOfWeek] + ")";
            rangeTimeStr += " ~ " + this.toDate_.Month + "月"
                + this.toDate_.Day + "日" + "(" + jaWeekday["" + this.toDate_.DayOfWeek] + ")";

            lbTimeRange.Text = rangeTimeStr;

            //Add day
            DateTime date = this.fromDate_;
            while (date <= this.toDate_)
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

                dgvStaff.Columns.Add(cl);

                date = date.AddDays(1);
            }
        }

        //back
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.frmMakeShift.Show();
            this.frmMakeShift.frmallst = null;
            this.Dispose();
        }

        //save
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.staffAvaiDate == null) this.staffAvaiDate = new Hashtable();
            for (int i = 0; i < this.staffIds.Length; i++)
            {
                String avaiDate = "";
                for (int j = 3; j < dgvStaff.ColumnCount; j++)
                {
                    avaiDate += dgvStaff[j, i].Value == null ? "O" : (String)dgvStaff[j, i].Value;
                }
                this.staffAvaiDate[this.staffIds[i]] = avaiDate;
            }
            
            this.frmMakeShift.staffAvaiDate = this.staffAvaiDate;
            this.frmMakeShift.Show();
            this.frmMakeShift.frmallst = null;
            this.Dispose();
        }

        //clear
        private void clearGrid()
        {

        }

        // Close equal to Back
        private void onClose(object sender, FormClosingEventArgs e)
        {
            //buttonX2_Click(sender, e);
            this.frmMakeShift.frmallst = null;
        }
    }
}
