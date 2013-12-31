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

using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace Chapy
{
    public partial class FrmWorkArrangementDetail : Form
    {
        String wACode = null;
        chapyEntities db = new chapyEntities();
        String[] Weekdays = { "月", "火", "水", "木", "金", "土", "日" };

        Boolean[] isClass = new Boolean[100];
        FrmWorkArrangement frmlst;
        public FrmWorkArrangementDetail(FrmWorkArrangement frmlst, String codeId)
        {
            InitializeComponent();
            this.frmlst = frmlst;
            if (codeId != null) this.wACode = codeId.Trim();

            tbCode.KeyDown += tbCode_KeyDown;

            initFormData();
        }

        // Press Enter on Code
        void tbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                wACode = tbCode.Text.Trim();
                clearForm();
                initFormData();
            }
        }

        // Init form
        void initFormData()
        {
            //school id
            int school_id = VariableGlobal.school_id;

            Hashtable applyCl = null;
            if (wACode != null)
            {
                tbCode.Text = wACode;

                //read timezone
                var wt = (from p in db.CpTimeZones where wACode == p.Code.Trim() && p.SchoolId == school_id
                          select p).FirstOrDefault();
                if (wt == null) return;

                txtName.Text = wt.Name;
                txtShortName.Text = wt.Abbreviation;
                btnColor.BackColor = System.Drawing.ColorTranslator.FromHtml(wt.Color);

                for (int i = 0; i < wt.DayOfWeeks.Length && i < 7; i++) if (wt.DayOfWeeks[i] == '1')
                    {
                        CheckBox cb = (CheckBox)this.Controls.Find("cbWday" + i, true)[0];
                        cb.Checked = true;
                    }

                //WorkTime
                txtStartTimeh.Text = ((DateTime)wt.StartTime).ToString("HH");
                txtStartTimem.Text = ((DateTime)wt.StartTime).ToString("mm");

                txtEndTimeh.Text = ((DateTime)wt.EndTime).ToString("HH");
                txtEndTimem.Text = ((DateTime)wt.EndTime).ToString("mm");

                //RestTime 1
                txtSRtimeh1.Text = ((DateTime)wt.RestStartTime1).ToString("HH");
                txtSRtimem1.Text = ((DateTime)wt.RestStartTime1).ToString("mm");

                txtERtimeh1.Text = ((DateTime)wt.RestEndTime1).ToString("HH");
                txtERtimem1.Text = ((DateTime)wt.RestEndTime1).ToString("mm");

                //RestTime 2
                txtSRtimeh2.Text = ((DateTime)wt.RestStartTime2).ToString("HH");
                txtSRtimem2.Text = ((DateTime)wt.RestStartTime2).ToString("mm");

                txtERtimeh2.Text = ((DateTime)wt.RestEndTime2).ToString("HH");
                txtERtimem2.Text = ((DateTime)wt.RestEndTime2).ToString("mm");

                //read class
                applyCl = new Hashtable();
                foreach (String cl in ((String)wt.ApplyClassed).Split(',')) if (cl != "")
                    {
                        String[] a = cl.Split(':');
                        applyCl.Add(a[0], a[1]);
                    }
            }
            

            for (int i = 0; i < 100; i++) isClass[i] = false;
            var GradeCodes = from p in db.CpGradeCodes select p;
            dgvClassList.Rows.Add(false, "全学年クラス");
            foreach (var gc in GradeCodes)
            {
                dgvClassList.Rows.Add(false,"     " + gc.Code.Trim() + " " + gc.Name + " 全クラス");
                var classes = from p in db.CpClasses where p.GradeCodeId == gc.Id && p.SchoolId == school_id select p;
                foreach (var cl in classes)
                {
                    String code = cl.Code.Trim();
                    int ind = dgvClassList.Rows.Add(false, "          " + code + " " + cl.Name);
                    isClass[ind] = true;

                    if (applyCl != null && applyCl.ContainsKey(code))
                    {
                        ((DataGridViewCheckBoxCell)dgvClassList[0, ind]).Value = true;
                        ((DataGridViewComboBoxExCell)dgvClassList[2, ind]).Value = applyCl[code];
                    }
                }
            }
        }

        // Clear
        void clearForm()
        {
            dgvClassList.DataSource = null;
            dgvClassList.Rows.Clear();
        }

        //Code change
        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            wACode = tbCode.Text.Trim();
        }

        /*
         * Button Clear
         */
        private void buttonX3_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        // Save to DB - Insert/Update
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime startTime = new DateTime(2000, 1, 1,
                Convert.ToInt16(txtStartTimeh.Text), Convert.ToInt16(txtStartTimem.Text), 0),
                endTime = new DateTime(2000, 1, 1,
                Convert.ToInt16(txtEndTimeh.Text), Convert.ToInt16(txtEndTimem.Text), 0),
                srtime1 = new DateTime(2000, 1, 1,
                Convert.ToInt16(txtSRtimeh1.Text), Convert.ToInt16(txtSRtimem1.Text), 0),
                ertime1 = new DateTime(2000, 1, 1,
                Convert.ToInt16(txtERtimeh1.Text), Convert.ToInt16(txtERtimem1.Text), 0),
                srtime2 = new DateTime(2000, 1, 1,
                Convert.ToInt16(txtSRtimeh2.Text), Convert.ToInt16(txtSRtimem2.Text), 0),
                ertime2 = new DateTime(2000, 1, 1,
                Convert.ToInt16(txtERtimeh2.Text), Convert.ToInt16(txtERtimem2.Text), 0);

            Color clr = btnColor.BackColor;

            String wdStr = "";
            for (int i = 0; i < 7; i++)
            {
                wdStr += ((CheckBox)this.Controls.Find("cbWday" + i, true)[0]).Checked ? '1':'0' ;
            }

            //Apply Classes
            String applyClasses = "";
            for (int i = 0; i < dgvClassList.RowCount; i++) if (isClass[i])
                {
                    String strClass = ((String)dgvClassList[1, i].Value).Trim();
                    String classCode = strClass.Split(' ')[0];
                    int number = Convert.ToInt16(dgvClassList[2, i].Value);
                    if (number > 0)
                    {
                        applyClasses += classCode + ":" + number + ",";
                    }
                }


            var wt = (from p in db.CpTimeZones where wACode == p.Code.Trim() select p).FirstOrDefault();

            if (wt == null)
            {   //Insert
                CpTimeZone wa = new CpTimeZone();
                wa.Code = tbCode.Text;
                wa.Name = txtName.Text;
                wa.Abbreviation = txtShortName.Text;
                wa.Color = String.Format("#{0:X2}{1:X2}{2:X2}", clr.R, clr.G, clr.B);
                wa.DayOfWeeks = wdStr;
                wa.StartTime = startTime;
                wa.EndTime = endTime;
                wa.RestStartTime1 = srtime1;
                wa.RestEndTime1 = ertime1;
                wa.RestStartTime2 = srtime2;
                wa.RestEndTime2 = ertime2;
                wa.ApplyClassed = applyClasses;
                wa.SchoolId = VariableGlobal.school_id;

                db.CpTimeZones.Add(wa);
            }
            else
            {   //Update
                wt.Code = tbCode.Text;
                wt.Name = txtName.Text;
                wt.Abbreviation = txtShortName.Text;
                wt.Color = String.Format("#{0:X2}{1:X2}{2:X2}", clr.R, clr.G, clr.B);
                wt.DayOfWeeks = wdStr;
                wt.StartTime = startTime;
                wt.EndTime = endTime;
                wt.RestStartTime1 = srtime1;
                wt.RestEndTime1 = ertime1;
                wt.RestStartTime2 = srtime2;
                wt.RestEndTime2 = ertime2;
                wt.ApplyClassed = applyClasses;
                wt.SchoolId = VariableGlobal.school_id;
            }

            try
            {
                db.SaveChanges();
                //this.frmlst.reload();
                /*ToastNotification.Show(this,
                "更新しました！",
                null,
                3000,
                (eToastGlowColor)(eToastGlowColor.Blue),
                (eToastPosition)(eToastPosition.TopCenter));*/
                (new FrmWorkArrangement()).Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDlg.Color;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new FrmWorkArrangement()).Show();
            this.Dispose();
        }

    }
}
