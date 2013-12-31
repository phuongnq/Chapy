using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;     //japanese calendar

namespace Chapy
{
    public partial class FrmStaffRegister : Form
    {
        //school id
        private int schoolId { get; set; }

        //database access
        chapyEntities db = new chapyEntities();

        //start year of combo box
        int startYear = 1950;

        //picture url
        string profileImg = null;

        //current staff id
        int? current_staff_id;

        //error message
        string error;
        public FrmStaffRegister()
        {
            InitializeComponent();
            schoolId = VariableGlobal.school_id;

            loadYear();
            loadCbStafftype();
            loadCbPosition();

            loadStaffList(schoolId);
        }

        private void FrmStaffRegister_Load(object sender, EventArgs e)
        {
            tbxStaffReg_school.Text = schoolId.ToString() + "  " + getSchoolName(schoolId);
            tbxStaffReg_school.Enabled = false;
            //loadStaffPicture();
        }

        //check edit mode
        /**
         * staff code existed in db => edit mode
         */
        private bool isEditMode()
        {
            String staff_code = tbxStaff_Code.Text.Trim();
            var staff = (from c in db.CpStaffs where c.Code == staff_code && c.SchoolId == schoolId select c).SingleOrDefault();
            return !(staff == null);
        }

        //get school name from school id
        private string getSchoolName(int id)
        {
            var school = (from c in db.CpSchools
                          where c.Id == id
                          select c).SingleOrDefault();
            if (school == null) return null;
            return school.Name;
        }

        //save new staff
        private void saveNewStaff()
        {
            CpStaff newStaff = new CpStaff();
            newStaff.SchoolId = schoolId;
            newStaff.Code = tbxStaff_Code.Text.Trim();
            newStaff.Hiragana = tbxStaff_Furigana.Text.Trim();
            newStaff.Hiragana2 = tbxStaff_Furigana2.Text.Trim();
            newStaff.Name = tbxStaff_Name.Text.Trim();
            newStaff.Name2 = tbxStaff_Name2.Text.Trim();
            newStaff.Abbreviation = tbxStaff_Abbreviation.Text.Trim();
            foreach (RadioButton rb in grpBoxStaff_Sex.Controls)
            {
                if (rb.Checked)
                {
                    Debug.WriteLine("sex: " + rb.Text);
                    if (rb.Text.Equals("男"))
                        newStaff.Gender = 0;
                    else
                        newStaff.Gender = 1;
                }
            }
            //add birthday datetime
            //parse date from year + month + day
            int year = getYearFromString(tbxStaff_BirthdayYear.Text.Trim(), VariableGlobal.japaneseYear);
            int month = Convert.ToInt32(tbxStaff_BirthdayMonth.Text.Trim());
            int day = Convert.ToInt32(tbxStaff_BirthdayDay.Text.Trim());
            DateTime dtBirth = new DateTime(year, month, day, 0, 0, 0);
            dtBirth = DateTime.SpecifyKind(dtBirth, DateTimeKind.Local);
            newStaff.BirthDay = dtBirth;

            newStaff.StaffTypeId = Convert.ToInt32(cb_StaffType.SelectedValue);
            newStaff.PositionId = Convert.ToInt32(cb_Postion.SelectedValue);

            //add startWork datetime
            //parse date from year + month + day
            year = getYearFromString(tbxStaff_startWorkYear.Text.Trim(), VariableGlobal.japaneseYear);
            month = Convert.ToInt32(tbxStaff_startWorkMonth.Text.Trim());
            day = Convert.ToInt32(tbxStaff_startWorkDay.Text.Trim());
            DateTime startWork = new DateTime(year, month, day, 0, 0, 0);
            startWork = DateTime.SpecifyKind(startWork, DateTimeKind.Local);
            newStaff.beginJob = startWork;

            foreach (RadioButton rb in grpbxStaff_jobType.Controls)
            {
                if (rb.Checked)
                {
                    Debug.WriteLine("job type: " + rb.Text);
                    if (rb.Text.Equals("正社員"))  //正社員: jobType=0, パート: jobType=1
                        newStaff.jobType = 0;
                    else
                        newStaff.jobType = 1;
                }
            }

            //add post code
            newStaff.PostCode = tbStaff_PostCode1.Text.Trim() + tbStaff_PostCode2.Text.Trim();

            //add staff address
            newStaff.Address1 = tbStaff_Address1.Text.Trim();
            newStaff.Address2 = tbStaff_Address2.Text.Trim();

            //add staff homepage
            newStaff.HomePage = tbStaff_HomePage.Text.Trim();

            //add staff telephone
            newStaff.Tel = tbStaff_Tel1.Text.Trim() + tbStaff_Tel2.Text.Trim() + tbStaff_Tel3.Text.Trim();

            //add staff mobile
            newStaff.Mobile = tbStaff_Mobile1.Text.Trim() + tbStaff_Mobile2.Text.Trim() + tbStaff_Mobile3.Text.Trim();

            //add staff mobile
            newStaff.Email = tbStaff_Email.Text.Trim();

            //add staff emerency address
            newStaff.EmerencyAddress1 = tbStaff_EmerencyAddr1.Text.Trim();
            newStaff.EmerencyAddress2 = tbStaff_EmerencyAddr2.Text.Trim();

            //add staff emerency telephone
            newStaff.EmerencyTel = tbStaff_EmerencyTel1.Text.Trim() + tbStaff_EmerencyTel2.Text.Trim() + tbStaff_EmerencyTel3.Text.Trim();

            db.CpStaffs.Add(newStaff);

            try
            {
                db.SaveChanges();
                //save profile picture
                if (profileImg != null)
                {
                    var path = Application.StartupPath + "\\image";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var profilePic = path + "\\" + newStaff.Id + ".jpg";
                    Debug.WriteLine("profile picture: " + profilePic);
                    if (File.Exists(profilePic))
                   {
                        unloadStaffPicture();
                        File.Delete(profilePic);
                    }
                    Debug.WriteLine("imagelocation: " + picturebxStaff_ProfilePic.ImageLocation);
                    File.Copy(profileImg, profilePic);
                    loadStaffPicture(profilePic);
               }

                MessageBox.Show("新しい職員追加完了しました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearInput();
            }
        }

        private void saveEditStaff()
        {
            String staff_code = tbxStaff_Code.Text.Trim();
            var staff = (from c in db.CpStaffs where c.Code == staff_code && c.SchoolId == schoolId select c).SingleOrDefault();
            if (staff == null) return;
            staff.SchoolId = schoolId;
            staff.Code = tbxStaff_Code.Text.Trim();
            staff.Hiragana = tbxStaff_Furigana.Text.Trim();
            staff.Hiragana2 = tbxStaff_Furigana2.Text.Trim();
            staff.Name = tbxStaff_Name.Text.Trim();
            staff.Name2 = tbxStaff_Name2.Text.Trim();
            staff.Abbreviation = tbxStaff_Abbreviation.Text.Trim();
            foreach (RadioButton rb in grpBoxStaff_Sex.Controls)
            {
                if (rb.Checked)
                {
                    Debug.WriteLine("sex: " + rb.Text);
                    if (rb.Text.Equals("男"))
                        staff.Gender = 0;
                    else
                        staff.Gender = 1;
                }
            }
            //add birthday datetime
            //parse date from year + month + day
            int year = getYearFromString(tbxStaff_BirthdayYear.Text.Trim(), VariableGlobal.japaneseYear);
            int month = Convert.ToInt32(tbxStaff_BirthdayMonth.Text.Trim());
            int day = Convert.ToInt32(tbxStaff_BirthdayDay.Text.Trim());
            DateTime dtBirth = new DateTime(year, month, day, 0, 0, 0);
            dtBirth = DateTime.SpecifyKind(dtBirth, DateTimeKind.Local);
            staff.BirthDay = dtBirth;

            staff.StaffTypeId = Convert.ToInt32(cb_StaffType.SelectedValue);
            staff.PositionId = Convert.ToInt32(cb_Postion.SelectedValue);

            //add startWork datetime
            //parse date from year + month + day
            year = getYearFromString(tbxStaff_startWorkYear.Text.Trim(), VariableGlobal.japaneseYear);
            month = Convert.ToInt32(tbxStaff_startWorkMonth.Text.Trim());
            day = Convert.ToInt32(tbxStaff_startWorkDay.Text.Trim());
            DateTime startWork = new DateTime(year, month, day, 0, 0, 0);
            startWork = DateTime.SpecifyKind(startWork, DateTimeKind.Local);
            staff.beginJob = startWork;

            foreach (RadioButton rb in grpbxStaff_jobType.Controls)
            {
                if (rb.Checked)
                {
                    Debug.WriteLine("job type: " + rb.Text);
                    if (rb.Text.Equals("正社員"))  //正社員: jobType=0, パート: jobType=1
                        staff.jobType = 0;
                    else
                        staff.jobType = 1;
                }
            }

            //save post code
            staff.PostCode = tbStaff_PostCode1.Text.Trim() + tbStaff_PostCode2.Text.Trim();

            //save staff address
            staff.Address1 = tbStaff_Address1.Text.Trim();
            staff.Address2 = tbStaff_Address2.Text.Trim();

            //save staff homepage
            staff.HomePage = tbStaff_HomePage.Text.Trim();

            //save staff telephone
            staff.Tel = tbStaff_Tel1.Text.Trim() + tbStaff_Tel2.Text.Trim() + tbStaff_Tel3.Text.Trim();

            //save staff mobile
            staff.Mobile = tbStaff_Mobile1.Text.Trim() + tbStaff_Mobile2.Text.Trim() + tbStaff_Mobile3.Text.Trim();

            //save staff mobile
            staff.Email = tbStaff_Email.Text.Trim();

            //save staff emerency address
            staff.EmerencyAddress1 = tbStaff_EmerencyAddr1.Text.Trim();
            staff.EmerencyAddress2 = tbStaff_EmerencyAddr2.Text.Trim();

            //save staff emerency telephone
            staff.EmerencyTel = tbStaff_EmerencyTel1.Text.Trim() + tbStaff_EmerencyTel2.Text.Trim() + tbStaff_EmerencyTel3.Text.Trim();

            try
            {
                db.SaveChanges();
                //save profile picture
                if (profileImg != null)
                {
                    var path = Application.StartupPath + "\\image";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var profilePic = path + "\\" + staff.Id + ".jpg";
                    if (!profileImg.Equals(profilePic))
                    {
                        if (File.Exists(profilePic))
                        {
                            unloadStaffPicture();
                            File.Delete(profilePic);
                        }
                        File.Copy(profileImg, profilePic);
                        loadStaffPicture(profilePic);
                    }
                    
                }
                MessageBox.Show("職員の編集完了しました");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                loadStaffList(schoolId);
            }
        }

        //register button click
        /**
         * if in new mode: save new to db
         * if in edit mode: save change to staff code
         */
        private void btnStaff_Register_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Register button clicked");
            if (!validate())
            {
                MessageBox.Show(error);
                return;
            } 
            if (!isEditMode())  //new staff
            {
                saveNewStaff();

                loadStaffList(VariableGlobal.school_id);
            }
            else if (current_staff_id != null)
            {
                saveEditStaff();
            }
            else
            {
                MessageBox.Show("「" + tbxStaff_Code.Text.Trim() + "」" + "は既に使用されているコードです");
            }
        }

        //cancel button click
        /**
         * if in edit mode => not delete staff code
         * if in new mode => delete all textbox
         */
        private void btnStaff_Cancel_Click(object sender, EventArgs e)
        {
            clearInput();
        }
        private void clearInput()
        {
            tbxStaff_Code.Text = "";
            tbxStaff_Furigana.Text = "";
            tbxStaff_Furigana2.Text = "";

            tbxStaff_Name.Text = "";
            tbxStaff_Name2.Text = "";

            tbxStaff_Abbreviation.Text = "";

            tbxStaff_BirthdayYear.Text = "";
            tbxStaff_BirthdayMonth.Text = "";
            tbxStaff_BirthdayDay.Text = "";

            rdBtnStaff_Male.Checked = false;
            rdBtnStaff_Female.Checked = false;

            tbxStaff_startWorkYear.Text = "";
            tbxStaff_startWorkMonth.Text = "";
            tbxStaff_startWorkDay.Text = "";

            cb_Postion.SelectedIndex = 0;
            cb_StaffType.SelectedIndex = 0;

            //clear birthday 1
            tbxStaff_BirthdayYear1.Text = "";
            tbxStaff_BirthdayMonth1.Text = "";
            tbxStaff_BirthdayDay1.Text = "";

            //clear Post Code
            tbStaff_PostCode1.Text = "";
            tbStaff_PostCode2.Text = "";

            //clear address
            tbStaff_Address1.Text = "";
            tbStaff_Address2.Text = "";

            //clear web url
            tbStaff_HomePage.Text = "";

            //clear telephone
            tbStaff_Tel1.Text = "";
            tbStaff_Tel2.Text = "";
            tbStaff_Tel3.Text = "";

            //clear mobile
            tbStaff_Mobile1.Text = "";
            tbStaff_Mobile2.Text = "";
            tbStaff_Mobile3.Text = "";

            //clear staff email
            tbStaff_Email.Text = "";

            //clear staff emerency address
            tbStaff_EmerencyAddr1.Text = "";
            tbStaff_EmerencyAddr2.Text = "";

            //clear staff emerency telephone
            tbStaff_EmerencyTel1.Text = "";
            tbStaff_EmerencyTel2.Text = "";
            tbStaff_EmerencyTel3.Text = "";

            unloadStaffPicture();
        }
        /********************************/
        //validate methods

        private bool validate()
        {
            bool validate = true;
            error = "";
            if (isNullString(tbxStaff_Code.Text))
            {
                validate = false;
                tbxStaff_Code.BackColor = System.Drawing.Color.Red;
                error = error + "職員コード";
            }
            if (isNullString(tbxStaff_Furigana.Text))
            {
                validate = false;
                tbxStaff_Furigana.BackColor = System.Drawing.Color.Red;
            }
            if (isNullString(tbxStaff_Furigana2.Text))
            {
                validate = false;
                tbxStaff_Furigana2.BackColor = System.Drawing.Color.Red;
            }
            if (isNullString(tbxStaff_Furigana.Text) || isNullString(tbxStaff_Furigana2.Text))
            {
                error = error + "、フリガナ";
            }

            if (isNullString(tbxStaff_Name.Text))
            {
                validate = false;
                tbxStaff_Name.BackColor = System.Drawing.Color.Red;
            }
            if (isNullString(tbxStaff_Name2.Text))
            {
                validate = false;
                tbxStaff_Name2.BackColor = System.Drawing.Color.Red;
            }
            if (isNullString(tbxStaff_Name.Text) || isNullString(tbxStaff_Name2.Text))
            {
                error = error + "、氏名";
            }

            //validate birthday
            if (isNullString(tbxStaff_BirthdayYear.Text) || isNullString(tbxStaff_BirthdayMonth.Text) || isNullString(tbxStaff_BirthdayDay.Text))
            {
                error = error + "、生年月日";
            }
            //1.validate year
            if (!isNullString(tbxStaff_BirthdayYear.Text))
            {
                int year = getYearFromString(tbxStaff_BirthdayYear.Text.Trim(),VariableGlobal.japaneseYear);
                if (year < startYear || year > DateTime.Now.Year)
                {
                    validate = false;
                    tbxStaff_BirthdayYear.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                validate = false;
                tbxStaff_BirthdayYear.BackColor = System.Drawing.Color.Red;
            }
            //2. validate month
            if (isNullString(tbxStaff_BirthdayMonth.Text))
            {
                validate = false;
                tbxStaff_BirthdayMonth.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                int month = Convert.ToInt32(tbxStaff_BirthdayMonth.Text.Trim());
                if (month > 12 || month < 1)
                {
                    validate = false;
                    tbxStaff_BirthdayMonth.BackColor = System.Drawing.Color.Red;
                }
            }

            //3. validate day
            if (isNullString(tbxStaff_BirthdayDay.Text))
            {
                validate = false;
                tbxStaff_BirthdayDay.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                int day = Convert.ToInt32(tbxStaff_BirthdayDay.Text.Trim());
                if (day > 31 || day < 1)
                {
                    validate = false;
                    tbxStaff_BirthdayDay.BackColor = System.Drawing.Color.Red;
                }
            }
            if (!validate)
            {
                error = error + "が入力されておりません";
            }
            /*
            //validate start work dat
            //1.validate year
            if (!isNullString(tbxStaff_startWorkYear.Text))
            {
                int year = getYearFromString(tbxStaff_startWorkYear.Text.Trim(), VariableGlobal.japaneseYear);
                if (year < startYear || year > DateTime.Now.Year)
                {
                    validate = false;
                    tbxStaff_startWorkYear.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                validate = false;
                tbxStaff_startWorkYear.BackColor = System.Drawing.Color.Red;
            }
            //2. validate month
            if (isNullString(tbxStaff_startWorkMonth.Text))
            {
                validate = false;
                tbxStaff_startWorkMonth.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                int month = Convert.ToInt32(tbxStaff_startWorkMonth.Text.Trim());
                if (month > 12 || month < 1)
                {
                    validate = false;
                    tbxStaff_startWorkMonth.BackColor = System.Drawing.Color.Red;
                }
            }

            //3. validate day
            if (isNullString(tbxStaff_startWorkDay.Text))
            {
                validate = false;
                tbxStaff_startWorkDay.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                int day = Convert.ToInt32(tbxStaff_startWorkDay.Text.Trim());
                if (day > 31 || day < 1)
                {
                    validate = false;
                    tbxStaff_startWorkDay.BackColor = System.Drawing.Color.Red;
                }
            }
             * */

            return validate;
        }

        /**
         * staff code refactor
         * 1 -> 000001
         * */
        string makeCodeParam(string code)
        {
            while (code.Length < 6)
            {
                code = "0" + code;
            }
            return code;
        }
        /**
         * method to validate string 
        */
        private bool isNullString(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        private void rdBtnStaff_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_SettingPartime_Click(object sender, EventArgs e)
        {

        }


        private int getYearFromString(string str, bool jpYear)
        {
            if (jpYear == false)
            {
                return Convert.ToInt32(str);
            }
            else if (jpYear == true)
            {
                return Convert.ToInt32(converJapaneseYearToWesternYear(str));
            }
            return 0;
        }
        private string convertWesternYearToJapaneseYear(string westernYear)
        {
            DateTime date = new DateTime(Convert.ToInt32(westernYear), 1, 1);
            JapaneseCalendar jpCalendar = new JapaneseCalendar();
            string[] era = { "明治", "大正", "昭和", "平成" };
            string japaneseYear = era[jpCalendar.GetEra(date) - 1] + jpCalendar.GetYear(date);
            return japaneseYear;
        }

        private string converJapaneseYearToWesternYear(string japaneseYear)
        {
            int year;
            japaneseYear = japaneseYear.Replace(" ",string.Empty);  //replace all spaces
            string era = japaneseYear.Substring(0, 2);
            if (era.Equals("平成"))
            {
                year = 1989;
            } else if(era.Equals("昭和"))
            {
                year = 1926;
            } else if(era.Equals("大正"))
            {
                year = 1912;
            }
            else if (era.Equals("明治"))
            {
                year = 1868;
            }
            else
            {
                return "";
            }
            year = year + Convert.ToInt32(japaneseYear.Substring(2,japaneseYear.Length -2)) - 1;
            return year.ToString();
        }

        private void loadYear()
        {
            #region load combox year
            Dictionary<int?, string> obj_years = new Dictionary<int?, string>();
            int currentYear = DateTime.Now.Year;
            for (int i = startYear; i < currentYear; i++)    //add to next 5 years
            {
                Debug.WriteLine(convertWesternYearToJapaneseYear(i.ToString()));
                if (VariableGlobal.japaneseYear)
                {
                    obj_years.Add(i, convertWesternYearToJapaneseYear(i.ToString()));   //build japanese calendar
                }
                else
                {
                    obj_years.Add(i, i.ToString()); //build western calendar
                }
                
            }
            cbbxStaff_BirthdayYear.DataSource = new BindingSource(obj_years, null);
            cbbxStaff_BirthdayYear.DisplayMember = "Value";
            cbbxStaff_BirthdayYear.ValueMember = "Key";
            cbbxStaff_BirthdayYear.SelectedIndex = -1;

            cbbxStaff_startWorkYear.DataSource = new BindingSource(obj_years, null);
            cbbxStaff_startWorkYear.DisplayMember = "Value";
            cbbxStaff_startWorkYear.ValueMember = "Key";
            cbbxStaff_startWorkYear.SelectedIndex = -1;

            //birthday combo box in 他の情報２
            cbbxStaff_BirthdayYear1.DataSource = new BindingSource(obj_years, null);
            cbbxStaff_BirthdayYear1.DisplayMember = "Value";
            cbbxStaff_BirthdayYear1.ValueMember = "Key";
            cbbxStaff_BirthdayYear1.SelectedIndex = -1;

            //startwork combo box in 他の情報1
            cbbxStaff_startWorkYear1.DataSource = new BindingSource(obj_years, null);
            cbbxStaff_startWorkYear1.DisplayMember = "Value";
            cbbxStaff_startWorkYear1.ValueMember = "Key";
            cbbxStaff_startWorkYear1.SelectedIndex = -1;

            #endregion
        }

        private void loadCbPosition()
        {
            #region load combox postion
            Dictionary<int, string> positions = new Dictionary<int, string>();

            var list_positions = from p in db.CpPositions where p.SchoolId == schoolId select p;

            if (list_positions.Any())
            {
                foreach (var position in list_positions)
                {
                    positions.Add(position.Id, position.Name);
                }
                cb_Postion.DataSource = new BindingSource(positions, null);
                cb_Postion.DisplayMember = "Value";
                cb_Postion.ValueMember = "Key";

            }
            #endregion
        }

        private void loadCbStafftype()
        {
            #region load combox staffType
            Dictionary<int, string> staffTypes = new Dictionary<int, string>();

            var list_staffType = from st in db.CpStaffTypes where st.SchoolId == schoolId select st;

            if (list_staffType.Any())
            {
                foreach (var position in list_staffType)
                {
                    staffTypes.Add(position.Id, position.Name);
                }
                cb_StaffType.DataSource = new BindingSource(staffTypes, null);
                cb_StaffType.DisplayMember = "Value";
                cb_StaffType.ValueMember = "Key";

            }
            #endregion
        }

        private void cbbxStaff_BirthdayYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = cbbxStaff_BirthdayYear.SelectedValue;
            if ((year != null) && year.GetType() == typeof(int))
            {
                if (VariableGlobal.japaneseYear)
                {
                    tbxStaff_BirthdayYear.Text = convertWesternYearToJapaneseYear(year.ToString());
                }
                else
                {
                    tbxStaff_BirthdayYear.Text = year.ToString();
                }
            }
                
        }

        private void cbbxStaff_startWorkYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = cbbxStaff_startWorkYear.SelectedValue;
            if ((year != null) && year.GetType() == typeof(int))
            {
                if (VariableGlobal.japaneseYear)
                {
                    tbxStaff_startWorkYear.Text = convertWesternYearToJapaneseYear(year.ToString());
                }
                else
                {
                    tbxStaff_startWorkYear.Text = year.ToString();
                }
            }
        }
        private void loadStaffPicture(string path)
        {
            //var path = Application.StartupPath + "\\image";
            //path = path + "\\default.jpg";
            if (!File.Exists(path)) return;
            Image image = Image.FromFile(path);
            picturebxStaff_ProfilePic.Image = image;
            picturebxStaff_ProfilePic.SizeMode = PictureBoxSizeMode.Zoom;

            //keep profile picture url;
            profileImg = path;
        }
        private void loadStaffPictureFromId(int staff_id)
        {
            var path = Application.StartupPath + "\\image";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var profilePic = path + "\\" + staff_id + ".jpg";
            if (File.Exists(profilePic))
            {
                loadStaffPicture(profilePic);
            }
        }
        private void unloadStaffPicture()
        {
            if (picturebxStaff_ProfilePic.Image != null)
            {
                picturebxStaff_ProfilePic.Image.Dispose();
                picturebxStaff_ProfilePic.Image = null;
            }
            profileImg = null;

        }

        private void btnStaff_BrowsePic_Click(object sender, EventArgs e)
        {

            OpenFileDialog browser = new OpenFileDialog();
            browser.Filter =
        "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
        "All files (*.*)|*.*";
            browser.Title = "職員のプロフィール画像";
            browser.InitialDirectory = @"C:\\";

            DialogResult result = browser.ShowDialog();
            //read the file
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in browser.FileNames)
                {
                    profileImg = file;
                    loadStaffPicture(profileImg);
                    return;
                }
            }
        }

        private void clearStaffList()
        {
            //int rowCount = dgv_StaffList.Rows.Count;
            //for (int i = 0; i < rowCount; i++)
            //{
            //    dgv_StaffList.Rows.RemoveAt(i);
            //    --rowCount;
            //}
            dgv_StaffList.Rows.Clear();
        }

        /**
        * get list staff of school
         * param: school id
        */
        private void loadStaffList(int id)
        {
            var staffList = (from c in db.CpStaffs
                             where c.SchoolId == id
                             select c);
            if (!staffList.Any()) return;

            //sort by staff type and job type
            if (VariableGlobal.jobTypeSort) staffList = staffList.OrderBy(c => c.jobType);
            if (VariableGlobal.positionTypeSort) staffList = staffList.OrderBy(c => c.PositionId);

            //sort by staff attributes
            if (VariableGlobal.staffCodeSort) staffList = staffList.OrderBy( c => c.Code);
            if (VariableGlobal.staffFuriganaSort) staffList = staffList.OrderBy(c => c.Hiragana);
            if (VariableGlobal.staffBirthdaySort) staffList = staffList.OrderBy(c => c.BirthDay);
            if (VariableGlobal.staffStartWorkSort) staffList = staffList.OrderBy(c => c.beginJob);

            //sort by gender
            if (VariableGlobal.staffMtoWSort) staffList = staffList.OrderBy(c => c.Gender);
            if (VariableGlobal.staffWotMSort) staffList = staffList.OrderByDescending(c => c.Gender);

            dgv_StaffList.Rows.Clear();
            foreach (var staff in staffList)
            {
                DataGridViewRow row = (DataGridViewRow)dgv_StaffList.Rows[0].Clone();
                row.Cells[0].Value = staff.Code;
                row.Cells[1].Value = staff.Name + " " + staff.Name2;
                row.Cells[2].Value = staff.Id;
                dgv_StaffList.Rows.Add(row);
            }
        }

        //load a staff 
        //param1 : school id
        //param2 : staff id
        private void loadStaff(int school_id, int staff_id)
        {
            var staff = (from c in db.CpStaffs
                         where c.SchoolId == school_id
                         && c.Id == staff_id
                         select c).SingleOrDefault();
            if (staff == null) return;

            tbxStaff_Code.Text = staff.Code.ToString();
            tbxStaff_Furigana.Text = (staff.Hiragana != null) ? staff.Hiragana.ToString() : "";
            tbxStaff_Furigana2.Text = (staff.Hiragana2 != null) ? staff.Hiragana2.ToString() : "";
            tbxStaff_Name.Text = (staff.Name != null) ? staff.Name.ToString() : "";
            tbxStaff_Name2.Text = (staff.Name2 != null) ? staff.Name2.ToString() : "";
            tbxStaff_Abbreviation.Text = (staff.Abbreviation != null) ? staff.Abbreviation.ToString() : "";

            //load gender
            if (staff.Gender == 0)
            {
                rdBtnStaff_Male.Checked = true;
            }
            else
            {
                rdBtnStaff_Female.Checked = true;
            }

            //load birthday
            if (staff.BirthDay != null)
            {
                var birthday = (DateTime)staff.BirthDay;
                if (VariableGlobal.japaneseYear)
                {
                    tbxStaff_BirthdayYear.Text = convertWesternYearToJapaneseYear(birthday.Year.ToString());
                }
                else
                {
                    tbxStaff_BirthdayYear.Text = birthday.Year.ToString();
                }
                cbbxStaff_BirthdayYear.SelectedIndex = cbbxStaff_BirthdayYear.FindStringExact(tbxStaff_BirthdayYear.Text);

                tbxStaff_BirthdayMonth.Text = birthday.Month.ToString();
                tbxStaff_BirthdayDay.Text = birthday.Day.ToString();


                tbxStaff_BirthdayYear1.Text = tbxStaff_BirthdayYear.Text;
                cbbxStaff_BirthdayYear1.SelectedIndex = cbbxStaff_BirthdayYear1.FindStringExact(tbxStaff_BirthdayYear1.Text);
                tbxStaff_BirthdayMonth1.Text = birthday.Month.ToString();
                tbxStaff_BirthdayDay1.Text = birthday.Day.ToString();
            }


            //load start work
            if (staff.beginJob != null)
            {
                var startWork = (DateTime)staff.beginJob;
                if (VariableGlobal.japaneseYear)
                {
                    tbxStaff_startWorkYear.Text = convertWesternYearToJapaneseYear(startWork.Year.ToString());
                }
                else
                {
                    tbxStaff_startWorkYear.Text = startWork.Year.ToString();
                }
                cbbxStaff_startWorkYear.SelectedIndex = cbbxStaff_startWorkYear.FindStringExact(tbxStaff_startWorkYear.Text);
                

                tbxStaff_startWorkMonth.Text = startWork.Month.ToString();
                tbxStaff_startWorkDay.Text = startWork.Day.ToString();

                tbxStaff_startWorkYear1.Text = tbxStaff_startWorkYear.Text;
                cbbxStaff_startWorkYear1.SelectedIndex = cbbxStaff_startWorkYear1.FindStringExact(tbxStaff_startWorkYear1.Text);
                tbxStaff_startWorkMonth1.Text = startWork.Month.ToString();
                tbxStaff_startWorkDay1.Text = startWork.Day.ToString();
            }

            //staff type
            var staffType = (from st in db.CpStaffTypes where st.SchoolId == schoolId && st.Id == staff.StaffTypeId select st).SingleOrDefault();
            if (staffType != null)
            {
                cb_StaffType.SelectedIndex = cb_StaffType.FindStringExact(staffType.Name);
            }

            //staff position
            var staffPosition = (from p in db.CpPositions where p.SchoolId == schoolId && p.Id == staff.PositionId select p).SingleOrDefault();
            if (staffPosition != null)
            {
                cb_Postion.SelectedIndex = cb_Postion.FindStringExact(staffPosition.Name);
            }

            //job type
            if (staff.jobType == 0)
            {
                rbtn_RegularEmployee.Checked = true;
            }
            else
            {
                rbtn_RegularEmployee.Checked = true;
            }

            //post code
            if (staff.PostCode != null && staff.PostCode.Length >= 3)
            {
                tbStaff_PostCode1.Text = staff.PostCode.Substring(0, 3);
                tbStaff_PostCode2.Text = staff.PostCode.Substring(3, staff.PostCode.Length - 3);
            }

            //load staff address
            if (staff.Address1 != null)
            {
                tbStaff_Address1.Text = staff.Address1;
            }
            if (staff.Address2 != null)
            {
                tbStaff_Address2.Text = staff.Address2;
            }

            //load staff url
            if (staff.HomePage != null)
            {
                tbStaff_HomePage.Text = staff.HomePage;
            }

            //load staff telephone
            if (staff.Tel != null && staff.Tel.Length >= 10)
            {
                tbStaff_Tel1.Text = staff.Tel.Substring(0, 3);
                tbStaff_Tel2.Text = staff.Tel.Substring(3, 4);
                tbStaff_Tel3.Text = staff.Tel.Substring(7, staff.Tel.Length - 7);
            }

            //load staff mobile
            if (staff.Mobile != null && staff.Mobile.Length >= 10)
            {
                tbStaff_Mobile1.Text = staff.Mobile.Substring(0, 3);
                tbStaff_Mobile2.Text = staff.Mobile.Substring(3, 4);
                tbStaff_Mobile3.Text = staff.Mobile.Substring(7, staff.Tel.Length - 7);
            }

            //load staff email address
            if (staff.Email != null)
            {
                tbStaff_Email.Text = staff.Email;
            }


            //load staff emerency address
            if (staff.EmerencyAddress1 != null)
            {
                tbStaff_EmerencyAddr1.Text = staff.EmerencyAddress1;
            }
            if (staff.EmerencyAddress2 != null)
            {
                tbStaff_EmerencyAddr2.Text = staff.EmerencyAddress2;
            }

            //load staff emerency tel
            //load staff telephone
            if (staff.EmerencyTel != null && staff.EmerencyTel.Length >= 10)
            {
                tbStaff_EmerencyTel1.Text = staff.EmerencyTel.Substring(0, 3);
                tbStaff_EmerencyTel2.Text = staff.EmerencyTel.Substring(3, 4);
                tbStaff_EmerencyTel3.Text = staff.EmerencyTel.Substring(7, staff.EmerencyTel.Length - 7);
            }

            //profile picture
            loadStaffPictureFromId(staff.Id);

            //set current staff id
            current_staff_id = staff.Id;

        }

        private void dgv_StaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgv_StaffList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)dgv_StaffList.Rows[index];
            var staff_id = Convert.ToInt32(row.Cells[2].Value);
            clearInput();
            loadStaff(schoolId, staff_id);
        }

        private void btnStaff_ProfileImgDelete_Click(object sender, EventArgs e)
        {
            unloadStaffPicture();
            if (profileImg != null)
            {
                if (File.Exists(profileImg))
                {
                    File.Delete(profileImg);
                    profileImg = null;
                }
            }
        }
        private void btnTerm_Save_Click(object sender, EventArgs e)
        {
            if (current_staff_id != null)
            {
                var preStaff = (from c in db.CpStaffs
                                where c.SchoolId == schoolId
                                && c.Id < current_staff_id
                                select c).ToArray().LastOrDefault();
                if (preStaff != null)
                {
                    clearInput();
                    loadStaff(schoolId, preStaff.Id);
                }
            }
        }
        private void btnStaff_Next_Click(object sender, EventArgs e)
        {
            if (current_staff_id != null)
            {
                var nextStaff = (from c in db.CpStaffs
                                 where c.SchoolId == schoolId
                                 && c.Id > current_staff_id
                                 select c).ToArray().FirstOrDefault();
                if (nextStaff != null)
                {
                    clearInput();
                    loadStaff(schoolId, nextStaff.Id);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain Main = new FrmMain();
            Main.Show();
        }

        private void languageChange(Object sender, InputLanguageChangedEventArgs e)
        {
            // If the input language is Japanese. 

            if (e.InputLanguage.Culture.TwoLetterISOLanguageName.Equals("ja"))
            {
                tbxStaff_Code.ImeMode = System.Windows.Forms.ImeMode.Off;

            }
        }


        private void cbbxStaff_BirthdayYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = cbbxStaff_BirthdayYear1.SelectedValue;
            if ((year != null) && year.GetType() == typeof(int))
            {
                if (VariableGlobal.japaneseYear)
                {
                    tbxStaff_BirthdayYear1.Text = convertWesternYearToJapaneseYear(year.ToString());
                }
                else
                {
                    tbxStaff_BirthdayYear1.Text = year.ToString();
                }
            }
        }

        private void cbbxStaff_startWorkYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = cbbxStaff_startWorkYear1.SelectedValue;
            if ((year != null) && year.GetType() == typeof(int))
            {
                if (VariableGlobal.japaneseYear)
                {
                    tbxStaff_startWorkYear1.Text = convertWesternYearToJapaneseYear(year.ToString());
                }
                else
                {
                    tbxStaff_startWorkYear1.Text = year.ToString();
                }
            }
        }

        private void tbxStaff_Code_Leave(object sender, EventArgs e)
        {
            tbxStaff_Code.Text = makeCodeParam(tbxStaff_Code.Text.Trim());
        }
    }
}
