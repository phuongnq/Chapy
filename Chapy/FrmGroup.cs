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
using System.Web.Script.Serialization;

namespace Chapy
{
    public partial class FrmGroup : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmGroup()
        {
            InitializeComponent();
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

        private void loadGroupEdit()
        {
            var obi_group = (from g in db.CpGroups where g.Id == VariableGlobal.groupe_id select g).Single();
            if (obi_group != null)
            {
                txt_Code.Text = obi_group.Code.ToString();
                txt_Name.Text = obi_group.Name;
                txt_Abbreviation.Text = obi_group.Abbreviation;
                txt_Code.Enabled = false;

                //check and show list staff.


                if (VariableGlobal.Codes.Count > 0)
                {
                    for (int j = 0; j < VariableGlobal.Codes.Count; j++)
                    {
                        string code = VariableGlobal.Codes[j] as string;
                        string name = VariableGlobal.Names[j] as string;
                        string sex = VariableGlobal.Sexs[j] as string;
                      //  string bithday = VariableGlobal.Birthdays[j] as string;

                        dataGridViewX1.Rows.Add(code, name, sex);

                    }

                }
                else
                {
                    if (obi_group.ListStaffId != null)
                    {
                        JavaScriptSerializer sers = new JavaScriptSerializer();
                        var JSONObjs = sers.Deserialize<Dictionary<string, string>>(obi_group.ListStaffId);
                        int total = JSONObjs.Count();
                        if (total > 0)
                        {
                            for (int i = 1; i <= total; i++)
                            {
                                int id = Convert.ToInt32(JSONObjs[Convert.ToString(i)]);
                                var st = (from s in db.CpStaffs where s.Id == id select s).Single();

                                dataGridViewX1.Rows.Add(st.Code, st.Name, st.Gender);

                                VariableGlobal.Codes.Add(st.Code);
                                VariableGlobal.Names.Add(st.Name);
                                VariableGlobal.Sexs.Add(st.Gender);
                                // VariableGlobal.Birthdays.Add(st.BirthDay);
                                VariableGlobal.StaffIds.Add(st.Id);

                            }
                        }
                    }
                }

                

            }
        }


        private void btn_ListStaff_Click(object sender, EventArgs e)
        {
            VariableGlobalGroup.Group_Code = txt_Code.Text;
            VariableGlobalGroup.Group_Name = txt_Name.Text;
            VariableGlobalGroup.Group_Abbreviation = txt_Abbreviation.Text;
            this.Hide();
            FrmStaffsSelect list_staff = new FrmStaffsSelect();
            list_staff.Show();

        }

        private void FrmGroup_Load(object sender, EventArgs e)
        {
            //load school
            load_combobox_school();

            //load data text truong hop select gv back lai
            txt_Code.Text = VariableGlobalGroup.Group_Code;
            txt_Name.Text = VariableGlobalGroup.Group_Name;
            txt_Abbreviation.Text = VariableGlobalGroup.Group_Abbreviation;



            dataGridViewX1.Rows.Clear();
            int school_id = VariableGlobal.school_id;

            #region check edit or no load datagriview
            if (VariableGlobal.groupe_id != 0)
            {
                loadGroupEdit();
            }
            else
            {
                txt_Code.Text = VariableGlobalGroup.Group_Code;
                txt_Code.Enabled = true;

                if (VariableGlobal.Codes.Count > 0)
                {
                    for (int j = 0; j < VariableGlobal.Codes.Count; j++)
                    {
                        string code = VariableGlobal.Codes[j] as string;
                        string name = VariableGlobal.Names[j] as string;
                        string sex = VariableGlobal.Sexs[j] as string;
                        //string bithday = VariableGlobal.Birthdays[j] as string;

                        dataGridViewX1.Rows.Add(code, name, sex);

                    }

                }

            }
            #endregion
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewX1.SelectedRows)
            {
                if (item.Cells[0].Value != null)
                {
                    //VariableGlobal.data_staffs.Add(new string[] { VariableGlobal.Names[item.Cells[1].Value.ToString()].ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString() });
                    for (int j = 0; j < VariableGlobal.Codes.Count; j++)
                    {
                        string code = VariableGlobal.Codes[j] as string;
                        if (code == item.Cells[0].Value)
                        {
                           // string name = VariableGlobal.Names[j] as string;
                            VariableGlobal.Codes.Remove(VariableGlobal.Codes[j]);
                            VariableGlobal.Names.Remove(VariableGlobal.Names[j]);
                            VariableGlobal.Sexs.Remove(VariableGlobal.Sexs[j]);
                          //  VariableGlobal.Birthdays.Remove(VariableGlobal.Birthdays[j]);
                            VariableGlobal.StaffIds.Remove(VariableGlobal.StaffIds[j]);
                           
                            dataGridViewX1.Rows.RemoveAt(item.Index);
                        }
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            resetDataGlobal();
            this.Hide();
            FrmGroupList group_list = new FrmGroupList();
            group_list.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                JavaScriptSerializer ser = new JavaScriptSerializer();

                //check data exit in database?
                string code = txt_Code.Text;
                var cp_group = (from p in db.CpGroups where p.Code == code select p).SingleOrDefault();
                if (cp_group == null)
                {
                    CpGroup cp_group_new = new CpGroup();
                    cp_group_new.SchoolId = Convert.ToInt32(cbb_Schools.SelectedValue);
                    cp_group_new.Code = txt_Code.Text;
                    cp_group_new.Name = txt_Name.Text;
                    cp_group_new.Abbreviation = txt_Abbreviation.Text;

                   
                    if (VariableGlobal.StaffIds.Count > 0)
                    {
                        //xu ly add them id cua staff vao DB.
                        var data_staff = new Dictionary<string, string>();
                        int incre_up = 0;

                        foreach (int staff_id in VariableGlobal.StaffIds)
                        {
                            incre_up++;
                            data_staff.Add(Convert.ToString(incre_up), Convert.ToString(staff_id));

                        }

                        var JSONString = ser.Serialize(data_staff); //JSON encoded
                        cp_group_new.ListStaffId = JSONString;

                    }
                    db.CpGroups.Add(cp_group_new);
                }
                else
                {
                    cp_group.Code = txt_Code.Text;
                    cp_group.Name = txt_Name.Text;
                    cp_group.Abbreviation = txt_Abbreviation.Text;

                    if (VariableGlobal.StaffIds.Count > 0)
                    {
                        //xu ly add them id cua staff vao DB.
                        var data_staff = new Dictionary<string, string>();
                        int incre_up = 0;

                        foreach (int staff_id in VariableGlobal.StaffIds)
                        {
                            incre_up++;
                            data_staff.Add(Convert.ToString(incre_up),Convert.ToString( staff_id));

                        }

                        var JSONString = ser.Serialize(data_staff); //JSON encoded
                        cp_group.ListStaffId = JSONString;

                    }

                }

                //update or insert data into db.
                try
                {
                    db.SaveChanges();
                    resetInput();
                    resetDataGlobal();
                    this.Hide();
                    FrmGroupList group_list = new FrmGroupList();
                    group_list.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void resetInput()
        {
            txt_Code.Text = "";
            txt_Name.Text = "";
            txt_Abbreviation.Text = "";
            
        }

        private void resetDataGlobal()
        {
            VariableGlobal.Codes.Clear();
            VariableGlobal.Names.Clear();
            VariableGlobal.Sexs.Clear();
           // VariableGlobal.Birthdays.Clear();
            VariableGlobal.StaffIds.Clear();

            VariableGlobalGroup.Group_Code = "";
            VariableGlobalGroup.Group_Name = "";
            VariableGlobalGroup.Group_Abbreviation = "";
        }

        private bool validate()
        {
            bool validate = true;

            if (isNullString(txt_Code.Text))
            {
                validate = false;
                txt_Code.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txt_Name.Text))
            {
                validate = false;
                txt_Name.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txt_Abbreviation.Text))
            {
                validate = false;
                txt_Abbreviation.BackColor = System.Drawing.Color.Red;
            }
            return validate;
        }

        private static bool isNullString(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        private static bool isNumber(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            return result;
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {
            if (txt_Code.Text.Length > 0 && txt_Code.BackColor == System.Drawing.Color.Red)
            {
                txt_Code.BackColor = System.Drawing.Color.White;//TextBox.DefaultBackColor;
            }

            if (txt_Code.Text.Length > 0)
            {
                //check db school_code is exits?
                string code = txt_Code.Text;
                var cp_buidings = (from bd in db.CpGroups where bd.Code == code select bd).SingleOrDefault();
                if (cp_buidings != null)
                {
                    // txt_Code.Text = cp_buidings.Code.ToString();
                    txt_Name.Text = cp_buidings.Name;
                    txt_Abbreviation.Text = cp_buidings.Abbreviation;
                }
                else
                {
                    //reset
                    // txt_Code.Text = "";
                    txt_Name.Text = "";
                    txt_Abbreviation.Text = "";
                }
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text.Length > 0 && txt_Name.BackColor == System.Drawing.Color.Red)
            {
                txt_Name.BackColor = System.Drawing.Color.White;// TextBox.DefaultBackColor;
            }
        }

        private void txt_Abbreviation_TextChanged(object sender, EventArgs e)
        {
            if (txt_Abbreviation.Text.Length > 0 && txt_Abbreviation.BackColor == System.Drawing.Color.Red)
            {
                txt_Abbreviation.BackColor = System.Drawing.Color.White;
            }
        }

    }

    public class VariableGlobalGroup
    {
        public static string Group_Code = "";
        public static string Group_Name = "";
        public static string Group_Abbreviation = "";

    }
}
