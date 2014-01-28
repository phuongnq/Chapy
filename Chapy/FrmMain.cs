using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Chapy
{
    public partial class FrmMain : Form
    {
        const string ERROR_MESSAGEBOX_CAPTION = "エラーメッセージ";
        const string ERROR_SCHOOL_NOTFOUND = "法人マスタ及び施設マスタを登録してください。";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void load_label_school()
        {
            lblSchool.Text = "施設：" + VariableGlobal.school_name;
        }

        private void btn_MakeBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_MakeSchedule_Click(object sender, EventArgs e)
        {
            chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
            var terms = (from t in db.CpTerms where t.SchoolId == VariableGlobal.school_id select t).SingleOrDefault();
            if (terms != null)
            {
                Thread thread = new Thread(new ThreadStart(ShowFormMakeShift)); //Tạo luồng mới
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)

            }
            else
            {
                MessageBox.Show("法人マスタ及び、施設マスタを登録することが必要です。");
            }
        }

        private void ShowFormMakeShift()
        {
            FrmMakeShift makeShift_Screen = new FrmMakeShift();
            makeShift_Screen.ShowDialog();
        }
        private void btn_Maintain_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormMainTain)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowFormMainTain()
        {
            FrmMaintain maintain_Screen = new FrmMaintain();
            maintain_Screen.ShowDialog();
        }

        private void btn_MakeSetting_Click(object sender, EventArgs e)
        {
            if (VariableGlobal.school_id == 0)
            {
                MessageBox.Show(ERROR_SCHOOL_NOTFOUND, ERROR_MESSAGEBOX_CAPTION);
            }
            else
            {
                Thread thread = new Thread(new ThreadStart(ShowFormStaffRegister)); //Tạo luồng mới
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)

            }
        }

        private void ShowFormStaffRegister()
        {
            FrmStaffRegister staff_register_Screen = new FrmStaffRegister();
            staff_register_Screen.ShowDialog();
        }

        private void btn_MakeStaff_Click(object sender, EventArgs e)
        {
            chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
            var terms = (from t in db.CpTerms where t.SchoolId == VariableGlobal.school_id select t).SingleOrDefault();
            if (terms != null)
            {
                Thread thread = new Thread(new ThreadStart(ShowFormWorkArrangement)); //Tạo luồng mới
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)
            }
            else
            {
                MessageBox.Show("Please register term for school");
            }
        }

        private void ShowFormWorkArrangement()
        {
            FrmWorkArrangement frmwa = new FrmWorkArrangement();
            frmwa.ShowDialog();
        }

        private void btnSwitchSchool_Click(object sender, EventArgs e)
        {
            chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
            if (db.CpSchools.Count() > 0)
            {

                Thread thread = new Thread(new ThreadStart(ShowFormSchoolSelect)); //Tạo luồng mới
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)

            }
            else
            {
                MessageBox.Show("Please create schools first");
            }
        }

        private void ShowFormSchoolSelect()
        {
            FrmSchoolSelect select = new FrmSchoolSelect();
            select.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.load_label_school();
        }

        private void btn_MakeTimeZone_Click(object sender, EventArgs e)
        {
            chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
            var terms = (from t in db.CpTerms where t.SchoolId == VariableGlobal.school_id select t).SingleOrDefault();
            if (terms != null)
            {
                Thread thread = new Thread(new ThreadStart(ShowFrmShiftYotei)); //Tạo luồng mới
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)
            }
            else
            {
                MessageBox.Show("Please register term for school");
            }
        }

        private void ShowFrmShiftYotei()
        {
            (new FrmShiftYotei(null)).ShowDialog();
            //FrmShiftYotei frmShiftYotei = new FrmShiftYotei();
            //frmShiftYotei.Show();
        }


    }


}
