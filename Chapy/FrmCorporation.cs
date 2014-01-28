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
using System.Threading;

namespace Chapy
{

    
    public partial class FrmCorporation : Form
    {

        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);

        //error message
        string error = null;

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

            cbCorporation_editable.Checked = true;

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
            error = "以下の項目を入力してください。\n";
            /**
             * validate corporation name
             * check null
             */
            if (isNullString(tbCorporation_Name.Text))
            {
                validate = false;
                tbCorporation_Name.BackColor = System.Drawing.Color.Red;
                
                error = error + "法人名\n" ;
            }

            /**
             * validate chairman name
             * check null
             */
            if (isNullString(tbCorporation_ChairManFirstName.Text))
            {
                validate = false;
                tbCorporation_ChairManFirstName.BackColor = System.Drawing.Color.Red;
                error = error + "理事長氏\n";
            }
            if (isNullString(tbCorporation_ChairManLastName.Text))
            {
                validate = false;
                tbCorporation_ChairManLastName.BackColor = System.Drawing.Color.Red;
                error = error + "理事長名\n";
            }

            /**
             * validate address
             * check null
             */
            if (isNullString(tbCorporation_Address1.Text))
            {
                validate = false;
                tbCorporation_Address1.BackColor = System.Drawing.Color.Red;
                error = error + "法人住所１\n";
            }
            if (isNullString(tbCorporation_Address2.Text))
            {
                validate = false;
                tbCorporation_Address2.BackColor = System.Drawing.Color.Red;
                error = error + "法人住所２\n";
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

            if (isNullString(tbCorporation_PostCode1.Text) || isNullString(tbCorporation_PostCode2.Text))
            {
                error = error + "法人郵便番号\n";
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

            if (isNullString(tbCorporation_Tel1.Text) || isNullString(tbCorporation_Tel2.Text) || isNullString(tbCorporation_Tel3.Text))
            {
                 error = error + "法人電話番号\n";
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
            if (isNullString(tbCorporation_Fax1.Text) || isNullString(tbCorporation_Fax2.Text) || isNullString(tbCorporation_Fax3.Text))
            {
                error = error + "法人ファックス番号\n";
            }

            /**
             * validate email
             * check format
             */
            if (!isEmail(tbCorporation_Email.Text))
            {
                validate = false;
                tbCorporation_Email.BackColor = System.Drawing.Color.Red;
                //error = error + "正しいメールアドレスを入力していください。";
            }
            if (isNullString(tbCorporation_Email.Text)) 
            {
               error = error + "法人E-mailアドレス\n";
            }

            /**
             * validate url
             */
            if (isNullString(tbCorporation_HomePage.Text))
            {
                validate = false;
                tbCorporation_HomePage.BackColor = System.Drawing.Color.Red;
                error = error + "法人ホームページアドレス\n";
            }

            if (error != null && validate == false)
            {
                MessageBox.Show(error, "法人登録エラーメッセージ");
                error = null;
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
            Thread thread = new Thread(new ThreadStart(ShowMainTain)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowMainTain()
        {
            FrmMaintain main = new FrmMaintain();
            main.ShowDialog();           
        }

        private void FrmCorporation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbCorporation_editable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCorporation_editable.Checked)
            {
                disableFields();
            }
            else
            {
                enableFields();
            }
        }

        private void disableFields()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                }
                btnCorporation_Save.Enabled = false;

            }
        }
        private void enableFields()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
                btnCorporation_Save.Enabled = true;

            }
        }
    }
}
