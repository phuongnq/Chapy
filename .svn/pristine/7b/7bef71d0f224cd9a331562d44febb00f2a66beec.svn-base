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
    public partial class FrmPositionList : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            //load school for combobox
            load_combobox_school();

            #region load datagriview
            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_positions = from p in db.CpPositions where p.SchoolId == school_id select p;

            if (list_positions.Any())
            {
                int i = 1;
                foreach (var p in list_positions)
                {
                    dataGridViewX1.Rows.Add(p.Code, p.Name, p.Abbreviation,p.Id);
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


        private void cbb_Schools_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_positions = from p in db.CpPositions where p.SchoolId == school_id select p;

            if (list_positions.Any())
            {
                int i = 1;
                foreach (var p in list_positions)
                {
                    dataGridViewX1.Rows.Add(i.ToString(), p.Name, p.Abbreviation,p.Id);
                    i++;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    int position_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    var obi_position = (from p in db.CpPositions where p.Id == position_id select p).Single();
                    try
                    {
                        db.CpPositions.Remove(obi_position);
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

        private void btn_EditPosition_Click(object sender, EventArgs e)
        {
            
              foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null){
                    this.Hide();
                    VariableGlobal.position_id = Convert.ToInt32(item.Cells[3].Value.ToString());
                    FrmPosition position = new FrmPosition();
                    position.Show();
                }
            }
           
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaintain maintain = new FrmMaintain();
            maintain.Show();
        }

        private void btn_CreatPosition_Click(object sender, EventArgs e)
        {
            this.Hide();
            VariableGlobal.position_id = 0;
            FrmPosition position = new FrmPosition();
            position.Show();
        }
    }
}
