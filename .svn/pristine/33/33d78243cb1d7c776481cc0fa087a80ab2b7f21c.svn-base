using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Chapy
{
    
    public partial class FrmStaffsSelect : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmStaffsSelect()
        {
            InitializeComponent();
        }

        private void FrmStaffsSelect_Load(object sender, EventArgs e)
        {
            #region load datagriview
            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;
            var list_staffs = from st in db.CpStaffs where st.SchoolId == school_id select st;

            if (list_staffs.Any())
            {
                int i = 1;
                if (VariableGlobal.Codes.Count > 0)
                {
                    foreach (var st in list_staffs)
                    {
                        int check = 0;
                        for (int j = 0; j < VariableGlobal.Codes.Count; j++)
                        {
                            string code = VariableGlobal.Codes[j] as string;
                            if (st.Code == code)
                            {
                                check = 1;
                            }
                        }

                        if (check == 0)
                        {
                            dataGridViewX1.Rows.Add(st.Code, st.Name, st.Gender, st.Id);
                            i++;
                        }
                    }
                }
                else
                {
                    foreach (var st in list_staffs)
                    {
                        dataGridViewX1.Rows.Add(st.Code, st.Name, st.Gender,st.Id);
                        i++;
                    }
                }
                
            }
            #endregion
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
           // VariableGlobal.building_id = Convert.ToInt32(item.Cells[3].Value.ToString());
            FrmGroup group = new FrmGroup();
            group.Show();
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                   //VariableGlobal.data_staffs.Add(new string[] { VariableGlobal.Names[item.Cells[1].Value.ToString()].ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString() });

                    VariableGlobal.Codes.Add(item.Cells[0].Value);
                    VariableGlobal.Names.Add(item.Cells[1].Value);
                    VariableGlobal.Sexs.Add( item.Cells[2].Value.ToString());
                    //VariableGlobal.Birthdays.Add(item.Cells[3].Value.ToString());
                    VariableGlobal.StaffIds.Add(item.Cells[3].Value);

                    dataGridViewX1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {
                    //VariableGlobal.data_staffs.Add(new string[] { VariableGlobal.Names[item.Cells[1].Value.ToString()].ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString() });

                    VariableGlobal.Codes.Add(item.Cells[0].Value);
                    VariableGlobal.Names.Add(item.Cells[1].Value);
                    VariableGlobal.Sexs.Add(item.Cells[2].Value.ToString());
                   // VariableGlobal.Birthdays.Add(item.Cells[3].Value.ToString());
                    VariableGlobal.StaffIds.Add(item.Cells[3].Value);

                    dataGridViewX1.Rows.RemoveAt(item.Index);
                }
            }
        }
    }
}
