using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread thread = new Thread(new ThreadStart(ShowCorporation)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowCorporation()
        {
            FrmCorporation corporation_Screen = new FrmCorporation();
            corporation_Screen.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            setEnviromentVariable();
            Thread thread = new Thread(new ThreadStart(ShowFormMain)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowFormMain()
        {
            FrmMain main_Screen = new FrmMain();
            main_Screen.ShowDialog();
        }

        private void btn_TermList_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormTermList)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowFormTermList()
        {
            FrmTermList termList_Screen = new FrmTermList();
            termList_Screen.ShowDialog();
        }

        private void btn_StaffType_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowStaffTypeList)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowStaffTypeList()
        {
            FrmStaffTypeList staffType_Screen = new FrmStaffTypeList();
            staffType_Screen.ShowDialog();
        }

        private void btn_Position_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowPositionList)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowPositionList()
        {
            FrmPositionList positionList_Screen = new FrmPositionList();
            positionList_Screen.ShowDialog();
        }

        private void btn_Building_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowBuildingList)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowBuildingList()
        {
            FrmBuildingList buildingList_Screen = new FrmBuildingList();
            buildingList_Screen.ShowDialog();
        }

        private void btn_Group_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowGroupList)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowGroupList()
        {
            FrmGroupList groupList_Screen = new FrmGroupList();
            groupList_Screen.ShowDialog();
        }

        private void btn_CreatSchool_Click(object sender, EventArgs e)
        {
            chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
            if (db.CpCorporations.Count() > 0)
            {
                Thread thread = new Thread(new ThreadStart(ShowSchool)); //Tạo luồng mới
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)
            }
            else
            {
                MessageBox.Show("施設を登録する前に、法人マスタを登録が必要です。");
            }
        }

        private void ShowSchool()
        {

            FrmShool school = new FrmShool();
            school.ShowDialog();
        }

        private void btn_TanninMaster_Click(object sender, EventArgs e)
        {
            //FrmTanninList tannin_list = new FrmTanninList();
            //tannin_list.Show();
            this.Close();
        }

        private void btn_Calendar_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowCalendar)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowCalendar()
        {
            FrmHoliday holiday = new FrmHoliday();
            holiday.ShowDialog();

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
            VariableGlobal.jobTypeSort = cbMaintain_JobType.Checked;

            //set variable for position type
            VariableGlobal.positionTypeSort = cbMaintain_PositionType.Checked;

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
            cbMaintain_JobType.Checked = VariableGlobal.jobTypeSort;
            cbMaintain_PositionType.Checked = VariableGlobal.positionTypeSort;

            rbMaintain_StaffCodeSort.Checked = VariableGlobal.staffCodeSort;
            rbMaintain_StaffFuriganaSort.Checked = VariableGlobal.staffFuriganaSort;
            rbMaintain_StaffBirthdaySort.Checked = VariableGlobal.staffBirthdaySort;
            rbMaintain_StaffStartWorkSort.Checked = VariableGlobal.staffStartWorkSort;

            rbMaintain_StaffMtoWSort.Checked = VariableGlobal.staffMtoWSort;
            rbMaintain_StaffWtoMSort.Checked = VariableGlobal.staffWotMSort;
            rbMaintain_StaffMWSort.Checked = VariableGlobal.staffMWSort;
        }

        private void grpBoxMaintain_YearType_Enter(object sender, EventArgs e)
        {

        }

        private void setEnviromentVariable()
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
            VariableGlobal.jobTypeSort = cbMaintain_JobType.Checked;

            //set variable for position type
            VariableGlobal.positionTypeSort = cbMaintain_PositionType.Checked;

            //set varibale for staff sort attributes
            VariableGlobal.staffCodeSort = rbMaintain_StaffCodeSort.Checked;
            VariableGlobal.staffFuriganaSort = rbMaintain_StaffFuriganaSort.Checked;
            VariableGlobal.staffBirthdaySort = rbMaintain_StaffBirthdaySort.Checked;
            VariableGlobal.staffStartWorkSort = rbMaintain_StaffStartWorkSort.Checked;

            VariableGlobal.staffMtoWSort = rbMaintain_StaffMtoWSort.Checked;
            VariableGlobal.staffWotMSort = rbMaintain_StaffWtoMSort.Checked;
            VariableGlobal.staffMWSort = rbMaintain_StaffMWSort.Checked;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vacation_Click(object sender, EventArgs e)
        {

        }


    }
}
