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
    public partial class FrmBuildingList : Form
    {
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);

        public FrmBuildingList()
        {
            InitializeComponent();
        }

        private void FrmBuildingList_Load(object sender, EventArgs e)
        {
            //load school for combobox
            load_combobox_school();

            #region load datagriview
            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_buildings = from bd in db.CpBuildings orderby bd.Code where bd.SchoolId == school_id select bd;

            if (list_buildings.Any())
            {
                int i = 1;
                foreach (var bd in list_buildings)
                {
                    dataGridViewX1.Rows.Add(bd.Code, bd.Name, bd.Abbreviation, bd.Id);
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
            VariableGlobal.building_id = 0;
            FrmBuilding building = new FrmBuilding();
            building.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    this.Hide();
                    VariableGlobal.building_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    FrmBuilding building = new FrmBuilding();
                    building.Show();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    int building_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    var obi_building = (from bd in db.CpBuildings where bd.Id == building_id select bd).Single();
                    try
                    {
                        db.CpBuildings.Remove(obi_building);
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
            Thread thread = new Thread(new ThreadStart(ShowFormMainTain)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowFormMainTain()
        {
            FrmMaintain main_tain = new FrmMaintain();
            main_tain.ShowDialog();

        }

    }
}
