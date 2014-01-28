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
    public partial class FrmStaffTypeList : Form
    {
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);

        public FrmStaffTypeList()
        {
            InitializeComponent();
        }

        private void FrmStaffTypeList_Load(object sender, EventArgs e)
        {
            //load school for combobox
            load_combobox_school();

            #region load datagriview
            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_staff_types = from st in db.CpStaffTypes orderby st.Code where st.SchoolId == school_id select st;

            if (list_staff_types.Any())
            {
                int i = 1;
                foreach (var p in list_staff_types)
                {
                    dataGridViewX1.Rows.Add(p.Code, p.Name, p.Abbreviation, p.Id);
                    i++;
                }
            }
            #endregion
        }

        private void load_combobox_school()
        {
            #region load combox school
            Dictionary<int, string> obj_schools = new Dictionary<int, string>();
            obj_schools.Add(VariableGlobal.school_id, VariableGlobal.school_name);

            cbb_Schools.DataSource = new BindingSource(obj_schools, null);
            cbb_Schools.DisplayMember = "Value";
            cbb_Schools.ValueMember = "Key";

            #endregion
        }

        private void btn_Creat_Click(object sender, EventArgs e)
        {
            this.Hide();
            VariableGlobal.staff_type_id = 0; 
            FrmStaffType staff_type = new FrmStaffType();
            staff_type.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    this.Hide();
                    VariableGlobal.staff_type_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    FrmStaffType staff_type = new FrmStaffType();
                    staff_type.Show();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    int staff_type_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    var obi_staff_type = (from st in db.CpStaffTypes where st.Id == staff_type_id select st).Single();
                    try
                    {
                        db.CpStaffTypes.Remove(obi_staff_type);
                        db.SaveChanges();
                        dataGridViewX1.Rows.RemoveAt(item.Index);
                        MessageBox.Show("保存完了しました");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("you can delete this record because it was used in other process");
                    }

                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this._btnBackClick();
        }

        private void _btnBackClick()
        {         

            Thread thread = new Thread(new ThreadStart(ShowMainTain)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowMainTain()
        {
            
            FrmMaintain main_tain = new FrmMaintain();
            main_tain.ShowDialog();
        }
    }
}
