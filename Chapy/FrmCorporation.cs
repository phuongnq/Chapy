using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chapy
{
    public partial class FrmCorporation : Form
    {
        chapyEntities db = new chapyEntities();

        public FrmCorporation()
        {
            InitializeComponent();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCorporation_Load(object sender, EventArgs e)
        {
            //select row
            var corporation = (from c in db.CpCorporations select c).SingleOrDefault();
            //show nothing if there is no data
            if (corporation == null) return;

            tbCorporation_Name.Text = corporation.Name;
            
            tbCorporation_ChairManFirstName.Text = corporation.ChairManFirstName;
            tbCorporation_ChairManLastName.Text = corporation.ChairManLastName;

            if (corporation.PostCode.Length >= 5)
            {
                tbCorporation_PostCode1.Text = corporation.PostCode.Substring(0, 3);
                tbCorporation_PostCode2.Text = corporation.PostCode.Substring(3, corporation.PostCode.Length - 3);
            }

            tbCorporation_Address1.Text = corporation.Address1;
            tbCorporation_Address2.Text = corporation.Address2;

            if (corporation.Tel.Length >= 10)
            {
                tbCorporation_Tel1.Text = corporation.Tel.Substring(0, 3);
                tbCorporation_Tel2.Text = corporation.Tel.Substring(3, 4);
                tbCorporation_Tel3.Text = corporation.Tel.Substring(7, corporation.Tel.Length - 7);
            }
            if (corporation.Fax.Length >= 10)
            {
                tbCorporation_Fax1.Text = corporation.Fax.Substring(0, 3);
                tbCorporation_Fax2.Text = corporation.Fax.Substring(3, 4);
                tbCorporation_Fax3.Text = corporation.Fax.Substring(7, corporation.Fax.Length - 7);
            }

            tbCorporation_Email.Text = corporation.Email;

            tbCorporation_HomePage.Text = corporation.HomePage;

        }

        private void btnCorporation_Click(object sender, EventArgs e)
        {
            if(!validate()) return;
            //select row to update
            var corporation = (from c in db.CpCorporations select c).SingleOrDefault();
            if (corporation == null)
            {
                corporation = new CpCorporation();
                corporation.Name = tbCorporation_Name.Text.Trim();

                corporation.ChairManFirstName = tbCorporation_ChairManFirstName.Text.Trim();
                corporation.ChairManLastName = tbCorporation_ChairManLastName.Text.Trim();

                corporation.PostCode = tbCorporation_PostCode1.Text.Trim() + tbCorporation_PostCode2.Text.Trim();

                corporation.Address1 = tbCorporation_Address1.Text.Trim();
                corporation.Address2 = tbCorporation_Address2.Text.Trim();

                corporation.Tel = tbCorporation_Tel1.Text.Trim() + tbCorporation_Tel2.Text.Trim() + tbCorporation_Tel3.Text.Trim();

                corporation.Fax = tbCorporation_Fax1.Text.Trim() + tbCorporation_Fax2.Text.Trim() + tbCorporation_Fax3.Text.Trim();

                corporation.Email = tbCorporation_Email.Text.Trim();

                corporation.HomePage = tbCorporation_HomePage.Text.Trim();
                db.CpCorporations.Add(corporation);
            }
            else
            {
                corporation.Name = tbCorporation_Name.Text.Trim();

                corporation.ChairManFirstName = tbCorporation_ChairManFirstName.Text.Trim();
                corporation.ChairManLastName = tbCorporation_ChairManLastName.Text.Trim();

                corporation.PostCode = tbCorporation_PostCode1.Text.Trim() + tbCorporation_PostCode2.Text.Trim();

                corporation.Address1 = tbCorporation_Address1.Text.Trim();
                corporation.Address2 = tbCorporation_Address2.Text.Trim();

                corporation.Tel = tbCorporation_Tel1.Text.Trim() + tbCorporation_Tel2.Text.Trim() + tbCorporation_Tel3.Text.Trim();

                corporation.Fax = tbCorporation_Fax1.Text.Trim() + tbCorporation_Fax2.Text.Trim() + tbCorporation_Fax3.Text.Trim();

                corporation.Email = tbCorporation_Email.Text.Trim();

                corporation.HomePage = tbCorporation_HomePage.Text.Trim();
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("保存完了しました");
        }
        private bool validate()
        {
            bool validate = true;

            /**
             * validate corporation name
             * check null
             */
            if (isNullString(tbCorporation_Name.Text))
            {
                validate = false;
                tbCorporation_Name.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate chairman name
             * check null
             */
            if (isNullString(tbCorporation_ChairManFirstName.Text))
            {
                validate = false;
                tbCorporation_ChairManFirstName.BackColor = System.Drawing.Color.Red;
            }
            if (isNullString(tbCorporation_ChairManLastName.Text))
            {
                validate = false;
                tbCorporation_ChairManLastName.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate address
             * check null
             */
            if (isNullString(tbCorporation_Address1.Text))
            {
                validate = false;
                tbCorporation_Address1.BackColor = System.Drawing.Color.Red;
            }
            if (isNullString(tbCorporation_Address2.Text))
            {
                validate = false;
                tbCorporation_Address2.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate post code
             * check number
             */
            if(!isNumber(tbCorporation_PostCode1.Text))
            {
                validate = false;
                tbCorporation_PostCode1.BackColor = System.Drawing.Color.Red;
            }
            if (!isNumber(tbCorporation_PostCode2.Text))
            {
                validate = false;
                tbCorporation_PostCode2.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate Tel
             * check number
             */
            if (!isNumber(tbCorporation_Tel1.Text))
            {
                validate = false;
                tbCorporation_Tel1.BackColor = System.Drawing.Color.Red;
            }
            if (!isNumber(tbCorporation_Tel2.Text))
            {
                validate = false;
                tbCorporation_Tel2.BackColor = System.Drawing.Color.Red;
            }
            if (!isNumber(tbCorporation_Tel3.Text))
            {
                validate = false;
                tbCorporation_Tel3.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate Fax
             * check number
             */
            if (!isNumber(tbCorporation_Fax1.Text))
            {
                validate = false;
                tbCorporation_Fax1.BackColor = System.Drawing.Color.Red;
            }
            if (!isNumber(tbCorporation_Fax2.Text))
            {
                validate = false;
                tbCorporation_Fax2.BackColor = System.Drawing.Color.Red;
            }
            if (!isNumber(tbCorporation_Fax3.Text))
            {
                validate = false;
                tbCorporation_Fax3.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate email
             * check format
             */
            if (!isEmail(tbCorporation_Email.Text))
            {
                validate = false;
                tbCorporation_Email.BackColor = System.Drawing.Color.Red;
            }

            /**
             * validate url
             */
            if (isNullString(tbCorporation_HomePage.Text))
            {
                validate = false;
                tbCorporation_HomePage.BackColor = System.Drawing.Color.Red;
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

        /**
         * method to validate string 
        */
        private static bool isNullString(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /**
         * method to validate email
         */
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

        private void btCorporation_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain();
            main.Show();
        }
    }
}
