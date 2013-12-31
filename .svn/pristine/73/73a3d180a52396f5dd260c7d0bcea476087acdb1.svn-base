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
    public partial class FrmBuilding : Form
    {
        chapyEntities db = new chapyEntities();

        public FrmBuilding()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBuildingList list_building = new FrmBuildingList();
            list_building.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //check data exit in database?
                string code = txt_Code.Text;
                var cp_building = (from bd in db.CpBuildings where bd.Code == code select bd).SingleOrDefault();
                if (cp_building == null)
                {
                    CpBuilding building_obj_new = new CpBuilding();
                    building_obj_new.SchoolId = VariableGlobal.school_id;
                    building_obj_new.Code = txt_Code.Text;
                    building_obj_new.Name = txt_Name.Text;
                    building_obj_new.Abbreviation = txt_Abbreviation.Text;

                    db.CpBuildings.Add(building_obj_new);
                }
                else
                {
                    cp_building.Code = txt_Code.Text;
                    cp_building.Name = txt_Name.Text;
                    cp_building.Abbreviation = txt_Abbreviation.Text;
                }

                //update or insert data into db.
                try
                {
                    db.SaveChanges();
                    this.Hide();
                    FrmBuildingList list_building = new FrmBuildingList();
                    list_building.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private bool validate()
        {
            bool validate = true;

            if (!isNumber(txt_Code.Text))
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


        private void FrmBuilding_Load(object sender, EventArgs e)
        {
            //load school
            load_combobox_school();

            if (VariableGlobal.building_id != 0)
            {
                cbb_Schools.Enabled = false;
                loadBuildingEdit();
            }
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

        private void loadBuildingEdit()
        {
            var obi_building = (from bd in db.CpBuildings where bd.Id == VariableGlobal.building_id select bd).Single();
            if (obi_building != null)
            {
                txt_Code.Text = obi_building.Code.ToString();
                txt_Name.Text = obi_building.Name;
                txt_Abbreviation.Text = obi_building.Abbreviation;
                txt_Code.Enabled = false;
            }
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
                var cp_buidings = (from bd in db.CpBuildings where bd.Code == code select bd).SingleOrDefault();
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

        private void txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {

            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

    }
}
