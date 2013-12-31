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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_MakeBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FrmSchoolSelect select_school = new FrmSchoolSelect();
           // select_school.Show();

          //  FrmShool cp_school = new FrmShool();
           // cp_school.Show();
        }

        private void btn_MakeSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMakeShift makeShift_Screen = new FrmMakeShift();
            makeShift_Screen.Show();
        }

        private void btn_Maintain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaintain maintain_Screen = new FrmMaintain();
            maintain_Screen.Show();
        }

        private void btn_MakeSetting_Click(object sender, EventArgs e)
        {
            if (VariableGlobal.school_id == 0)
            {
                MessageBox.Show("not found school, please creat new school");
            }
            else
            {
                this.Hide();
                FrmStaffRegister staff_register_Screen = new FrmStaffRegister();
                staff_register_Screen.Show();
            }
        }

        private void btn_MakeStaff_Click(object sender, EventArgs e)
        {
            FrmWorkArrangement frmwa = new FrmWorkArrangement();
            frmwa.Show();
            this.Dispose();
        }
    }


}
