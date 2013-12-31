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
    public partial class FrmShool : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmShool()
        {
            InitializeComponent();
        }

        private void FrmShool_Load(object sender, EventArgs e)
        {
            loadListSchool();
        }

        private void loadListViewSchool(object sender, EventArgs e)
        {
            #region load data staff
            lv_School.Items.Clear();
            var list_schools = from s in db.CpSchools select s;
          //  int code_number = 0;
            if (list_schools.Any())
            {
                int STT = 1;
                

                foreach (var t in list_schools)
                {
                    ListViewItem item = new ListViewItem(STT.ToString());
                   // item.Name = t.Id.ToString();
                    item.SubItems.Add(t.Code.ToString());
                    item.SubItems.Add(t.Name);
                    item.SubItems.Add(t.Id.ToString());

                    lv_School.Items.Add(item);
                    STT++;
                //    code_number = Convert.ToInt32( t.Code.ToString());
                }
            }

            //string code_text = Convert.ToString(code_number + 1);
            //txt_SchoolCode.Text = code_text;

            #endregion
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (validate())//data input okie.
            {
                //check data exit in database?
                string code = txt_SchoolCode.Text;
                var cp_school = (from s in db.CpSchools where s.Code == code select s).SingleOrDefault();
                if (cp_school == null)
                {
                    //creat new school
                    CpSchool cp_school_new = new CpSchool();
                    cp_school_new.CorporationId = 1;
                    cp_school_new.Name = txt_ShcoolName.Text;
                    cp_school_new.Code = txt_SchoolCode.Text;
                    cp_school_new.PrinceName1 = txt_PrinceName1.Text;
                    cp_school_new.PrinceName2 = txt_PrinceName2.Text;
                    cp_school_new.PostCode = txt_PostCode1.Text + txt_PostCode2.Text;
                    cp_school_new.Address1 = txt_Address1.Text;
                    cp_school_new.Address2 = txt_Address2.Text;
                    cp_school_new.Tel = txt_NumberPhone1.Text + txt_NumberPhone2.Text + txt_NumberPhone3.Text;
                    cp_school_new.Fax = txt_NumberFax1.Text + txt_NumberFax2.Text + txt_NumberFax3.Text;
                    cp_school_new.Email = txt_Email.Text;
                    cp_school_new.HomePage = txt_URL.Text;
                    if (rdb_HasPass.Checked == true)
                    {
                        cp_school_new.UsePass = 1;
                        cp_school_new.Password = txt_Pass1.Text;
                    }
                    else
                    {
                        cp_school_new.UsePass = 0;
                        cp_school_new.Password = "";
                    }

                    db.CpSchools.Add(cp_school_new);
                }
                else
                {
                    //update database.
                    cp_school.CorporationId = 1;
                    cp_school.Name = txt_ShcoolName.Text;
                    cp_school.Code = txt_SchoolCode.Text;
                    cp_school.PrinceName1 = txt_PrinceName1.Text;
                    cp_school.PrinceName2 = txt_PrinceName2.Text;
                    cp_school.PostCode = txt_PostCode1.Text + txt_PostCode2.Text;
                    cp_school.Address1 = txt_Address1.Text;
                    cp_school.Address2 = txt_Address2.Text;
                    cp_school.Tel = txt_NumberPhone1.Text + txt_NumberPhone2.Text + txt_NumberPhone3.Text;
                    cp_school.Fax = txt_NumberFax1.Text + txt_NumberFax2.Text + txt_NumberFax3.Text;
                    cp_school.Email = txt_Email.Text;
                    cp_school.HomePage = txt_URL.Text;
                    if (rdb_HasPass.Checked == true)
                    {
                        cp_school.UsePass = 1;
                        cp_school.Password = txt_Pass1.Text;
                    }
                    else
                    {
                        cp_school.UsePass = 0;
                        cp_school.Password = "";
                    }
                }

                //update or insert data into db.
                try
                {
                    db.SaveChanges();
                    resetInput();
                    loadListSchool();
                    MessageBox.Show("保存完了しました");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }

        }

        //validate input data.
        private bool validate()
        {
            bool validate = true;

            if (isNullString(txt_SchoolCode.Text))
            {
                validate = false;
                txt_SchoolCode.BackColor = System.Drawing.Color.Red;
            }


            if (isNullString(txt_ShcoolName.Text))
            {
                validate = false;
                txt_ShcoolName.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txt_PrinceName1.Text))
            {
                validate = false;
                txt_PrinceName1.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txt_PrinceName2.Text))
            {
                validate = false;
                txt_PrinceName2.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txt_PostCode1.Text))
            {
                validate = false;
                txt_PostCode1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_PostCode1.Text.Length < 3)
                {
                    validate = false;
                    txt_PostCode1.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_PostCode2.Text))
            {
                validate = false;
                txt_PostCode2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_PostCode2.Text.Length < 4)
                {
                    validate = false;
                    txt_PostCode2.BackColor = System.Drawing.Color.Red;
                }
            }

            
            if (isNullString(txt_Address1.Text))
            {
                validate = false;
                txt_Address1.BackColor = System.Drawing.Color.Red;
            }

           /* if (isNullString(txt_Address4.Text))
            {
                validate = false;
                txt_Address4.BackColor = System.Drawing.Color.Red;
            }
            * */

            if (isNullString(txt_Email.Text))
            {
                validate = false;
                txt_Email.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (!isEmail(txt_Email.Text))
                {
                    validate = false;
                    lb_EmailNotCorrect.Visible = true;
                }
                else
                {
                    validate = true;
                    lb_EmailNotCorrect.Visible = false;
                }
            }

            if (isNullString(txt_NumberFax1.Text))
            {
                validate = false;
                txt_NumberFax1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_NumberFax1.Text.Length < 3)
                {
                    validate = false;
                    txt_NumberFax1.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_NumberFax2.Text))
            {
                validate = false;
                txt_NumberFax2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_NumberFax2.Text.Length < 4)
                {
                    validate = false;
                    txt_NumberFax2.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_NumberFax3.Text))
            {
                validate = false;
                txt_NumberFax3.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_NumberFax3.Text.Length < 4)
                {
                    validate = false;
                    txt_NumberFax3.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_NumberPhone1.Text))
            {
                validate = false;
                txt_NumberPhone1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_NumberPhone1.Text.Length < 3)
                {
                    validate = false;
                    txt_NumberPhone1.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_NumberPhone2.Text))
            {
                validate = false;
                txt_NumberPhone2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_NumberPhone2.Text.Length < 4)
                {
                    validate = false;
                    txt_NumberPhone2.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_NumberPhone3.Text))
            {
                validate = false;
                txt_NumberPhone3.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt_NumberPhone3.Text.Length < 4)
                {
                    validate = false;
                    txt_NumberPhone3.BackColor = System.Drawing.Color.Red;
                }
            }

            if (isNullString(txt_URL.Text))
            {
                validate = false;
                txt_URL.BackColor = System.Drawing.Color.Red;
            }

            if (rdb_HasPass.Checked == true)
            {
                if (isNullString(txt_Pass1.Text))
                {
                    validate = false;
                    txt_Pass1.BackColor = System.Drawing.Color.Red;
                }

                if (isNullString(txt_Pass2.Text))
                {
                    validate = false;
                    txt_Pass2.BackColor = System.Drawing.Color.Red;
                }

                if (txt_Pass1.Text.Length < 6 || txt_Pass1.Text.Length > 12)
                {
                    validate = false;
                    txt_Pass1.BackColor = System.Drawing.Color.Red;
                }

                if (!isNullString(txt_Pass1.Text) && !isNullString(txt_Pass2.Text))
                {
                    if (txt_Pass1.Text != txt_Pass2.Text)
                    {
                        txt_Pass2.BackColor = System.Drawing.Color.Red;
                    }
                }

            }


            return validate;
        }

        /**
         * method to validate number
         */
        private static bool isNumber(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            return result;
        }

        private static bool isEmail(string value)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(value);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /**
         * method to validate string 
        */
        private static bool isNullString(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }


        private void rdb_HasPass_Click(object sender, EventArgs e)
        {
            if (rdb_HasPass.Checked == true)
            {
                txt_Pass1.Visible = true;
                txt_Pass2.Visible = true;
                lb_PassLength.Visible = true;
                lb_pw1.Visible = true;
                lb_pw2.Visible = true;
            }
            else
            {
                txt_Pass1.Visible = false;
                txt_Pass2.Visible = false;
                lb_PassLength.Visible = false;
                lb_pw1.Visible = false;
                lb_pw2.Visible = false;
            }
        }

        private void rdb_NotPass_Click(object sender, EventArgs e)
        {
            if (rdb_NotPass.Checked == true)
            {
                txt_Pass1.Visible = false;
                txt_Pass2.Visible = false;
                lb_pw1.Visible = false;
                lb_pw2.Visible = false;
            }
        }


        private void resetInput()
        {
            txt_SchoolCode.Text = "";
            txt_ShcoolName.Text = "";
            txt_PrinceName1.Text = "";
            txt_PrinceName2.Text = "";
            txt_PostCode1.Text = "";
            txt_PostCode2.Text = "";
            txt_NumberPhone1.Text = "";
            txt_NumberPhone2.Text = "";
            txt_NumberPhone3.Text = "";
            txt_NumberFax1.Text = "";
            txt_NumberFax2.Text = "";
            txt_NumberFax3.Text = "";
            txt_Address1.Text ="";
            txt_Address2.Text ="";
            txt_Email.Text = "";
            txt_URL.Text = "";
            txt_Pass1.Text = "";
            txt_Pass2.Text = "";
            lb_EmailNotCorrect.Visible = false;
            lb_PassNotCorrect.Visible = false;
        }

        private void loadListSchool()
        {
            #region load data staff
            lv_School.Items.Clear();
            var list_schools = from s in db.CpSchools select s;
          //  int code_number = 0;
            if (list_schools.Any())
            {
                int STT = 1;

                foreach (var t in list_schools)
                {
                    ListViewItem item = new ListViewItem(STT.ToString());

                    // item.Name = t.Id.ToString();
                    item.SubItems.Add(t.Code.ToString());
                    item.SubItems.Add(t.Name);
                    item.SubItems.Add(t.Id.ToString());

                    lv_School.Items.Add(item);

                    STT++;
                   // code_number = Convert.ToInt32(t.Code.ToString());
  
                }
            }

            //string code_text = Convert.ToString(code_number + 1);
           // txt_SchoolCode.Text = code_text;

            #endregion
        }

        private void lv_School_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_School.SelectedItems.Count > 0)
            {
                ListViewItem obj_school = lv_School.SelectedItems[0];
                loadInputSchool(obj_school);
            }
        }

        private void loadInputSchool(ListViewItem obj_school)
        {
            int Id = Convert.ToInt32( obj_school.SubItems[3].Text.ToString());
            var cp_school = (from s in db.CpSchools where s.Id == Id select s).SingleOrDefault();
            if (cp_school != null)
            {
                txt_SchoolCode.Text = cp_school.Code.ToString();
                txt_ShcoolName.Text = cp_school.Name;
                txt_PrinceName1.Text = cp_school.PrinceName1;
                txt_PrinceName2.Text = cp_school.PrinceName2;

                if (cp_school.PostCode.Length >= 5)
                {
                    txt_PostCode1.Text = cp_school.PostCode.Substring(0, 3);
                    txt_PostCode2.Text = cp_school.PostCode.Substring(3, cp_school.PostCode.Length - 3);
                }

                txt_Address1.Text = cp_school.Address1;
                txt_Address2.Text = cp_school.Address2;

                if (cp_school.Tel.Length >= 10)
                {
                    txt_NumberPhone1.Text = cp_school.Tel.Substring(0, 3);
                    txt_NumberPhone2.Text = cp_school.Tel.Substring(3, 4);
                    txt_NumberPhone3.Text = cp_school.Tel.Substring(7, cp_school.Tel.Length - 7);
                }
                if (cp_school.Fax.Length >= 10)
                {
                    txt_NumberFax1.Text = cp_school.Fax.Substring(0, 3);
                    txt_NumberFax2.Text = cp_school.Fax.Substring(3, 4);
                    txt_NumberFax3.Text = cp_school.Fax.Substring(7, cp_school.Fax.Length - 7);
                }
                txt_Email.Text = cp_school.Email;
                txt_URL.Text = cp_school.HomePage;

                if (cp_school.UsePass == 1)
                {
                    lb_PassLength.Visible = true;
                    rdb_HasPass.Checked = true;
                    rdb_NotPass.Checked = false;
                    lb_pw1.Visible = true;
                    lb_pw2.Visible = true;
                    txt_Pass1.Visible = true;
                    txt_Pass2.Visible = true;
                    txt_Pass1.Text = cp_school.Password;
                    txt_Pass2.Text = cp_school.Password;
                }
                else
                {
                    lb_PassLength.Visible = false;
                    rdb_HasPass.Checked = false;
                    rdb_NotPass.Checked = true;
                    lb_pw1.Visible = false;
                    lb_pw2.Visible = false;
                    txt_Pass1.Visible = false;
                    txt_Pass2.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("something error");
            }
        }

        private void txt_ShcoolName_TextChanged(object sender, EventArgs e)
        {
            if (txt_ShcoolName.Text.Length > 0 && txt_ShcoolName.BackColor == System.Drawing.Color.Red)
            {
                txt_ShcoolName.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_PrinceName1_TextChanged(object sender, EventArgs e)
        {
            if (txt_PrinceName1.Text.Length > 0 && txt_PrinceName1.BackColor == System.Drawing.Color.Red)
            {
                txt_PrinceName1.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_PrinceName2_TextChanged(object sender, EventArgs e)
        {
            if (txt_PrinceName2.Text.Length > 0 && txt_PrinceName2.BackColor == System.Drawing.Color.Red)
            {
                txt_PrinceName2.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_PostCode1_TextChanged(object sender, EventArgs e)
        {
            if (txt_PostCode1.Text.Length > 0 && txt_PostCode1.BackColor == System.Drawing.Color.Red)
            {
                txt_PostCode1.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_PostCode2_TextChanged(object sender, EventArgs e)
        {
            if (txt_PostCode2.Text.Length > 0 && txt_PostCode2.BackColor == System.Drawing.Color.Red)
            {
                txt_PostCode2.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_Address1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Address1.Text.Length > 0 && txt_Address1.BackColor == System.Drawing.Color.Red)
            {
                txt_Address1.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_NumberPhone1_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumberPhone1.Text.Length > 0 && txt_NumberPhone1.BackColor == System.Drawing.Color.Red)
            {
                txt_NumberPhone1.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_NumberPhone2_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumberPhone2.Text.Length > 0 && txt_NumberPhone2.BackColor == System.Drawing.Color.Red)
            {
                txt_NumberPhone2.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_NumberPhone3_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumberPhone3.Text.Length > 0 && txt_NumberPhone3.BackColor == System.Drawing.Color.Red)
            {
                txt_NumberPhone3.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_NumberFax1_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumberFax1.Text.Length > 0 && txt_NumberFax1.BackColor == System.Drawing.Color.Red)
            {
                txt_NumberFax1.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_NumberFax2_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumberFax2.Text.Length > 0 && txt_NumberFax2.BackColor == System.Drawing.Color.Red)
            {
                txt_NumberFax2.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_NumberFax3_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumberFax3.Text.Length > 0 && txt_NumberFax3.BackColor == System.Drawing.Color.Red)
            {
                txt_NumberFax3.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text.Length > 0 && txt_Email.BackColor == System.Drawing.Color.Red)
            {
                txt_Email.BackColor = System.Drawing.Color.White;
            }
            if (!isEmail(txt_Email.Text))
            {
                lb_EmailNotCorrect.Visible = true;
            }
            else
            {
                lb_EmailNotCorrect.Visible = false;
            }

        }

        private void txt_URL_TextChanged(object sender, EventArgs e)
        {
            if (txt_URL.Text.Length > 0 && txt_URL.BackColor == System.Drawing.Color.Red)
            {
                txt_URL.BackColor = System.Drawing.Color.White;
            }

        }

        private void txt_Pass1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Pass1.Text.Length > 0 && txt_Pass1.BackColor == System.Drawing.Color.Red)
            {
                txt_Pass1.BackColor = System.Drawing.Color.White;
            }
        }

        private void txt_Pass2_TextChanged(object sender, EventArgs e)
        {
            if (txt_Pass2.Text.Length > 0 && txt_Pass2.BackColor == System.Drawing.Color.Red)
            {
                txt_Pass2.BackColor = System.Drawing.Color.White;
            }

            if (txt_Pass2.Text != txt_Pass1.Text)
            {
                lb_PassNotCorrect.Visible = true;
            }
            else
            {
                lb_PassNotCorrect.Visible = false;
            }
        }

        private void txt_SchoolCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_SchoolCode.Text.Length > 0 && txt_SchoolCode.BackColor == System.Drawing.Color.Red)
            {
                txt_SchoolCode.BackColor = System.Drawing.Color.White; // TextBox.DefaultBackColor;

                
            }

            if (txt_SchoolCode.Text.Length > 0)
            {
                //check db school_code is exits?
                string code = txt_SchoolCode.Text;
                var cp_school = (from s in db.CpSchools where s.Code == code select s).SingleOrDefault();
                if (cp_school != null)
                {
                    txt_SchoolCode.Text = cp_school.Code.ToString();
                    txt_ShcoolName.Text = cp_school.Name;
                    txt_PrinceName1.Text = cp_school.PrinceName1;
                    txt_PrinceName2.Text = cp_school.PrinceName2;

                    if (cp_school.PostCode.Length >= 5)
                    {
                        txt_PostCode1.Text = cp_school.PostCode.Substring(0, 3);
                        txt_PostCode2.Text = cp_school.PostCode.Substring(3, cp_school.PostCode.Length - 3);
                    }

                    txt_Address1.Text = cp_school.Address1;
                    txt_Address2.Text = cp_school.Address2;

                    if (cp_school.Tel.Length >= 10)
                    {
                        txt_NumberPhone1.Text = cp_school.Tel.Substring(0, 3);
                        txt_NumberPhone2.Text = cp_school.Tel.Substring(3, 4);
                        txt_NumberPhone3.Text = cp_school.Tel.Substring(7, cp_school.Tel.Length - 7);
                    }
                    if (cp_school.Fax.Length >= 10)
                    {
                        txt_NumberFax1.Text = cp_school.Fax.Substring(0, 3);
                        txt_NumberFax2.Text = cp_school.Fax.Substring(3, 4);
                        txt_NumberFax3.Text = cp_school.Fax.Substring(7, cp_school.Fax.Length - 7);
                    }
                    txt_Email.Text = cp_school.Email;
                    txt_URL.Text = cp_school.HomePage;

                    if (cp_school.UsePass == 1)
                    {
                        lb_PassLength.Visible = true;
                        rdb_HasPass.Checked = true;
                        rdb_NotPass.Checked = false;
                        lb_pw1.Visible = true;
                        lb_pw2.Visible = true;
                        txt_Pass1.Visible = true;
                        txt_Pass2.Visible = true;
                        txt_Pass1.Text = cp_school.Password;
                        txt_Pass2.Text = cp_school.Password;
                    }
                    else
                    {
                        lb_PassLength.Visible = false;
                        rdb_HasPass.Checked = false;
                        rdb_NotPass.Checked = true;
                        lb_pw1.Visible = false;
                        lb_pw2.Visible = false;
                        txt_Pass1.Visible = false;
                        txt_Pass2.Visible = false;

                    }
                }
                else
                {
                    //reset
                    txt_ShcoolName.Text = "";
                    txt_PrinceName1.Text = "";
                    txt_PrinceName2.Text = "";
                    txt_PostCode1.Text = "";
                    txt_PostCode2.Text = "";
                    txt_NumberPhone1.Text = "";
                    txt_NumberPhone2.Text = "";
                    txt_NumberPhone3.Text = "";
                    txt_NumberFax1.Text = "";
                    txt_NumberFax2.Text = "";
                    txt_NumberFax3.Text = "";
                    txt_Address1.Text = "";
                    txt_Address2.Text = "";
                    txt_Email.Text = "";
                    txt_URL.Text = "";
                    txt_Pass1.Text = "";
                    txt_Pass2.Text = "";
                    lb_EmailNotCorrect.Visible = false;
                    lb_PassNotCorrect.Visible = false;
                }
            }

        }

        private void txt_PostCode1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PostCode2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NumberPhone1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NumberPhone2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NumberPhone3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NumberFax1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NumberFax2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NumberFax3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PostCode1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_PostCode1.Text.Length>= 3)
            {
                txt_PostCode2.Focus();
            }
        }

        private void txt_PostCode2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_PostCode2.Text.Length >= 4)
            {
                txt_Address1.Focus();
            }
        }

        private void txt_NumberPhone1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_NumberPhone1.Text.Length >= 3)
            {
                txt_NumberPhone2.Focus();
            }
        }

        private void txt_NumberPhone2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_NumberPhone2.Text.Length >= 4)
            {
                txt_NumberPhone3.Focus();
            }
        }

        private void txt_NumberPhone3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_NumberPhone3.Text.Length >= 4)
            {
                txt_NumberFax1.Focus();
            }
        }

        private void txt_NumberFax1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_NumberFax1.Text.Length >= 3)
            {
                txt_NumberFax2.Focus();
            }
        }

        private void txt_NumberFax2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_NumberFax2.Text.Length >= 4)
            {
                txt_NumberFax3.Focus();
            }
        }

        private void txt_NumberFax3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_NumberFax3.Text.Length >= 4)
            {
                txt_Email.Focus();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaintain maintain = new FrmMaintain();
            maintain.Show();
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void labelX13_Click(object sender, EventArgs e)
        {

        }

        private void txt_Address2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void labelX14_Click(object sender, EventArgs e)
        {

        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void labelX16_Click(object sender, EventArgs e)
        {

        }

    }
}
