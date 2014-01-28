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
    public partial class FrmStaffGroupSelect : Form
    {
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);

        public FrmStaffGroupSelect()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowGroup)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowGroup()
        {
            FrmGroup group = new FrmGroup();
            group.ShowDialog();

        }

        private void FrmStaffGroupSelect_Load(object sender, EventArgs e)
        {
            #region load datagriview
            dgv_ListStaff.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_staffs = from st in db.CpStaffs where st.SchoolId == school_id select st;

            /*if (list_staffs.Any())
            {
                int i = 1;
                foreach (var st in list_staffs)
                {
                    dgv_ListStaff.Rows.Add(st.Code, st.Name, st.Gender, st.BirthDay);
                    i++;
                }
            }
            #endregion
            */
            dgv_ListStaff.RowCount = list_staffs.Count();
            int i = 0;
            if (list_staffs.Any())
            {
                //dgv_ListStaff.RowCount = list_staffs.Count;
                foreach (var st in list_staffs)
                {
                    //dgv_ListStaff[0, i].Value = false;
                    dgv_ListStaff[1, i].Value = st.Code;
                    dgv_ListStaff[2, i].Value = st.Name;
                    dgv_ListStaff[3, i].Value = st.Gender;
                    dgv_ListStaff[4, i].Value = st.BirthDay;

                    i++;
                }
            }

            #endregion
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < dgv_ListStaff.RowCount; i++)
            {
                if (dgv_ListStaff[0, i].Value != null && dgv_ListStaff[0, i].Value.ToString().Equals("True"))
                {
                    total++;
                }
            }

        }

        private void dgv_ListStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dgv_ListStaff.RowCount - 1;
            for (int i = 0; i < dgv_ListStaff.RowCount; i++)
            {
                if (dgv_ListStaff[0, i].Value.ToString().Equals("True"))
                {
                }
            }

        }
    }
}
