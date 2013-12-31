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
    public partial class FrmMaintain : Form
    {
        public FrmMaintain()
        {
            InitializeComponent();
        }

        private void btn_Corporation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCorporation corporation_Screen = new FrmCorporation();
            corporation_Screen.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main_Screen = new FrmMain();
            main_Screen.Show();
        }

        private void btn_TermList_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTermList termList_Screen = new FrmTermList();
            termList_Screen.Show();
        }

        private void btn_StaffType_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaffTypeList staffType_Screen = new FrmStaffTypeList();
            staffType_Screen.Show();
        }

        private void btn_Position_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPositionList positionList_Screen = new FrmPositionList();
            positionList_Screen.Show();
        }

        private void btn_Building_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuildingList buildingList_Screen = new FrmBuildingList();
            buildingList_Screen.Show();
        }

        private void btn_Group_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGroupList groupList_Screen = new FrmGroupList();
            groupList_Screen.Show();
        }

        private void btn_CreatSchool_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmShool school = new FrmShool();
            school.Show();
        }

        private void btn_TanninMaster_Click(object sender, EventArgs e)
        {
            FrmTanninList tannin_list = new FrmTanninList();
	        tannin_list.Show();
	        this.Close();
        }

        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            FrmHoliday holiday = new FrmHoliday();
            holiday.Show();
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMaintain_Save_Click(object sender, EventArgs e)
        {
            //set Japanese Year Global Variable
            foreach (RadioButton rb in grpBoxMaintain_YearType.Controls)
            {
                if (rb.Checked)
                {
                    if (rb.Text.Equals("和歴表示"))
                        VariableGlobal.japaneseYear = true;
                    else
                        VariableGlobal.japaneseYear = false;
                }
            }
            //set variable for job type
            VariableGlobal.jobType = cbMaintain_JobType.Checked;

            //set variable for position type
            VariableGlobal.positionType = cbMaintain_PositionType.Checked;

            //set varibale for staff sort attributes
            VariableGlobal.staffCodeSort = rbMaintain_StaffCodeSort.Checked;
            VariableGlobal.staffFuriganaSort = rbMaintain_StaffFuriganaSort.Checked;
            VariableGlobal.staffBirthdaySort = rbMaintain_StaffBirthdaySort.Checked;
            VariableGlobal.staffStartWorkSort = rbMaintain_StaffStartWorkSort.Checked;

            VariableGlobal.staffMtoWSort = rbMaintain_StaffMtoWSort.Checked;
            VariableGlobal.staffWotMSort = rbMaintain_StaffWtoMSort.Checked;
            VariableGlobal.staffMWSort = rbMaintain_StaffMWSort.Checked;

            MessageBox.Show("環境設定完了しました");
        }

        //load Maintain Screen
        //1. set default Environment Variable
        private void FrmMaintain_Load(object sender, EventArgs e)
        {
            //check Year Type
            if (VariableGlobal.japaneseYear)
            {
                rbMaintain_YearTypeJapanese.Checked = true;
            }
            else
            {
                rbMaintain_YearTypeWestern.Checked = true;
            }

            //check staff type and job type
            cbMaintain_JobType.Checked = VariableGlobal.jobType;
            cbMaintain_PositionType.Checked = VariableGlobal.positionType;

            rbMaintain_StaffCodeSort.Checked = VariableGlobal.staffCodeSort;
            rbMaintain_StaffFuriganaSort.Checked = VariableGlobal.staffFuriganaSort;
            rbMaintain_StaffBirthdaySort.Checked = VariableGlobal.staffBirthdaySort;
            rbMaintain_StaffStartWorkSort.Checked = VariableGlobal.staffStartWorkSort;

            rbMaintain_StaffMtoWSort.Checked = VariableGlobal.staffMtoWSort;
            rbMaintain_StaffWtoMSort.Checked = VariableGlobal.staffWotMSort;
            rbMaintain_StaffMWSort.Checked = VariableGlobal.staffMWSort;
        }

       
    }
}
