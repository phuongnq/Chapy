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
    public partial class FrmGroupList : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmGroupList()
        {
            InitializeComponent();
        }

        private void FrmGroupList_Load(object sender, EventArgs e)
        {
            //load school for combobox
            load_combobox_school();

            #region load datagriview
            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_groups = from g in db.CpGroups where g.SchoolId == school_id select g;

            if (list_groups.Any())
            {
                int i = 1;
                foreach (var g in list_groups)
                {
                    dataGridViewX1.Rows.Add(g.Code, g.Name, g.Abbreviation, g.Id);
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
            VariableGlobal.groupe_id = 0;
            FrmGroup group = new FrmGroup();
            group.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaintain main_tain = new FrmMaintain();
            main_tain.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                   
                    VariableGlobal.groupe_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    this.Hide();
                    FrmGroup group = new FrmGroup();
                    group.Show();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    int group_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    var obj_group = (from g in db.CpGroups where g.Id == group_id select g).Single();
                    try
                    {
                        db.CpGroups.Remove(obj_group);
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


    }
}
