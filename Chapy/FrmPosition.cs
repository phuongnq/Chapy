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
    public partial class FrmPosition : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            //load school
            load_combobox_school();

            if (VariableGlobal.position_id != 0)
            {
                cbb_Schools.Enabled = false;
                loadPositionEdit();
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


        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //check data exit in database?
                string code = txt_Code.Text;
                var cp_position = (from p in db.CpPositions where p.Code == code select p).SingleOrDefault();
                if (cp_position == null)
                {
                    CpPosition cp_position_new = new CpPosition();
                    cp_position_new.SchoolId = Convert.ToInt32( cbb_Schools.SelectedValue);
                    cp_position_new.Code = txt_Code.Text;
                    cp_position_new.Name = txt_Name.Text;
                    cp_position_new.Abbreviation = txt_Abbreviation.Text;

                    db.CpPositions.Add(cp_position_new);
                }
                else
                {
                    cp_position.Code = txt_Code.Text;
                    cp_position.Name = txt_Name.Text;
                    cp_position.Abbreviation = txt_Abbreviation.Text;
                }

                //update or insert data into db.
                try
                {
                    db.SaveChanges();
                    resetInput();
                    this.Hide();
                    FrmPositionList position_list = new FrmPositionList();
                    position_list.Show();
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
                var cp_buidings = (from bd in db.CpPositions where bd.Code == code select bd).SingleOrDefault();
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPositionList position_list = new FrmPositionList();
            position_list.Show();
        }

        private void loadPositionEdit()
        {
            var obi_position = (from p in db.CpPositions where p.Id == VariableGlobal.position_id select p).Single();
            if (obi_position != null)
            {
                txt_Code.Text = obi_position.Code.ToString();
                txt_Name.Text = obi_position.Name;
                txt_Abbreviation.Text = obi_position.Abbreviation;
                txt_Code.Enabled = false;
            }
        }




    }
}
