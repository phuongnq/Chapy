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
    public partial class FrmTerm : Form
    {
        //school id
        private static int schoolId { get; set; }

        //is in edit mode or not
        private bool isEditMode = false;
        
        //database access
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);

        //edit term_id

        int term_id;

        int class_id;

        //edit term_code
        string term_code;

        //edit term_name
        string term_name;

        //start year
        int startYear = 2010;//1990;

        int selectedStaffRowIndex = 1;  //staff row id clicked

        //add new term initialization
        public FrmTerm()
        {
            InitializeComponent();
            schoolId = VariableGlobal.school_id;

            #region load combox year
            Dictionary<int?, string> obj_years = new Dictionary<int?, string>();
            int currentYear = DateTime.Now.Year;
            for (int i = startYear; i <= currentYear + 6; i++)    //add to next 5 years
            {
                obj_years.Add(i, i.ToString() + "年度");
            }
            tbdropbxTerm_Year.DataSource = new BindingSource(obj_years, null);
            tbdropbxTerm_Year.DisplayMember = "Key";
            tbdropbxTerm_Year.ValueMember = "Key";
            tbdropbxTerm_Year.SelectedIndex = -1;

            #endregion
        }

        //edit mode initialization
        public FrmTerm(string code, string name)
        {
            InitializeComponent();
            schoolId = VariableGlobal.school_id;
            isEditMode = true;
            var term = (from c in db.CpTerms
                          where c.Code == code && c.Name == name && c.SchoolId == VariableGlobal.school_id
                          select c).SingleOrDefault();
            if(term == null) return;
            term_id = term.Id;
            term_code = code;
            term_name = name;

            //output editing term id & term name
            txbTerm_termCode.Text = term_code;
            txbTerm_termName.Text = term_name;
            

            //output list of grade and class of term
            loadGradeAndClassOfTerm(term_id);

            #region load combox year
            Dictionary<int?, string> obj_years = new Dictionary<int?, string>();
            int currentYear = DateTime.Now.Year;
            for (int i = startYear; i <= currentYear + 6; i++)    //add to next 5 years
            {
                obj_years.Add(i, i.ToString() + "年度");
            }
            tbdropbxTerm_Year.DataSource = new BindingSource(obj_years, null);
            tbdropbxTerm_Year.DisplayMember = "Key";
            tbdropbxTerm_Year.ValueMember = "Key";
            tbdropbxTerm_Year.SelectedIndex = -1;

            #endregion
            if (term.Year - startYear > 0)
                tbdropbxTerm_Year.SelectedIndex = term.Year - startYear;
            else
                tbdropbxTerm_Year.SelectedIndex = -1;
        }


        private void loadTermByCode(string code)
        {

            var term = (from c in db.CpTerms
                        where c.Code == code &&
                        c.SchoolId == schoolId
                        select c).SingleOrDefault();
            if (term == null)
            {
                isEditMode = false;
                term_id = -1;
                return;
            }
            isEditMode = true;
            term_id = term.Id;
            term_code = code;
            term_name = term.Name;

            //output editing term id & term name
            txbTerm_termCode.Text = term_code;
            txbTerm_termName.Text = term_name;


            //output list of grade and class of term
            //loadGradeAndClassOfTerm(term_id);

            //#region load combox year
            //Dictionary<int?, string> obj_years = new Dictionary<int?, string>();
            //int currentYear = DateTime.Now.Year;
            //for (int i = startYear; i <= currentYear + 6; i++)    //add to next 5 years
            //{
            //    obj_years.Add(i, i.ToString() + "年度");
            //}
            //tbdropbxTerm_Year.DataSource = new BindingSource(obj_years, null);
            //tbdropbxTerm_Year.DisplayMember = "Key";
            //tbdropbxTerm_Year.ValueMember = "Key";
            //tbdropbxTerm_Year.SelectedIndex = -1;

            //#endregion
            //if (term.Year - startYear > 0)
            //    tbdropbxTerm_Year.SelectedIndex = term.Year - startYear;
            //else
            //    tbdropbxTerm_Year.SelectedIndex = -1;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmTerm_Load(object sender, EventArgs e)
        {
            //school name
            tbDrop_schoolName.Text = getSchoolName();
        }

        private string getSchoolName()
        {
            var school = (from c in db.CpSchools
                            where c.Id == schoolId
                            select c).SingleOrDefault();
            if (school == null) return "";
            return school.Name;
        }

        private void btnTerm_Save_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                saveNewTerm();
            }
            else
            {
                saveEditedTerm();
            }
        }

        private void btnTerm_Back_Click(object sender, EventArgs e)
        {
            
            Thread thread = new Thread(new ThreadStart(ShowTermList)); //Tạo luồng mới
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void ShowTermList()
        {
            FrmTermList termList_Screen = new FrmTermList();
            termList_Screen.ShowDialog();
            
        }

        /**
         * save new term 
         */
        private void saveNewTerm()
        {
            if (validate())
            {
                //check if term exited or not
                if (isExistedTermCode(txbTerm_termCode.Text.Trim()))
                {
                    txbTerm_termCode.BackColor = Color.Red;
                    MessageBox.Show("マスタコードが存在しています");
                    return;
                }
                txbTerm_termCode.BackColor = Color.Empty;
                //save new term
                CpTerm term = new CpTerm();
                term.SchoolId = schoolId;

                var year = tbdropbxTerm_Year.SelectedValue;
                if ((year != null) && (year.GetType() == typeof(int)))
                    term.Year = Convert.ToInt32(year);
                term.Code = txbTerm_termCode.Text.Trim();
                term.Name = txbTerm_termName.Text.Trim();
                db.CpTerms.Add(term);
                try
                {
                    db.SaveChanges();
                    
                    //set term_id for view grade and class
                    term_id = term.Id;
                    //change to edit mode
                    isEditMode = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //save new grade
                if (isNullString(txbTerm_gradeCode.Text) || isNullString(txbTerm_gradeName.Text))
                {
                    MessageBox.Show("保存完了しました");
                    return;
                }
                CpGradeCode gradeCode = new CpGradeCode();
                gradeCode.Code = txbTerm_gradeCode.Text.Trim();
                gradeCode.Name = txbTerm_gradeName.Text.Trim();
                gradeCode.TermId = term.Id;
                db.CpGradeCodes.Add(gradeCode);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //save new class
                if (isNullString(txbTerm_classCode.Text) || isNullString(txbTerm_className.Text))
                {
                    MessageBox.Show("保存完了しました");
                    return;
                }
                CpClass classOfGrade = new CpClass();
                classOfGrade.Code = txbTerm_classCode.Text.Trim();
                classOfGrade.Name = txbTerm_className.Text.Trim();
                classOfGrade.SchoolId = schoolId;
                classOfGrade.TermId = term.Id;
                classOfGrade.GradeCodeId = gradeCode.Id;
                db.CpClasses.Add(classOfGrade);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("保存完了しました");
                    resetInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                loadGradeAndClassOfTerm(term.Id);
            }
        }

        /**
         * save edited term
         */
        private void saveEditedTerm()
        {
            if (!validate()) return;
            //check term code existed or not
            var term = (from c in db.CpTerms where c.Code == txbTerm_termCode.Text.Trim() && c.SchoolId == VariableGlobal.school_id select c).SingleOrDefault();
            if (term != null)
            {
                if (term.Id != term_id)
                {
                    txbTerm_termCode.BackColor = Color.Red;
                    MessageBox.Show("指定したマスタコードが既に存在しています");
                    return;
                }
            }
            txbTerm_termCode.BackColor = Color.Empty;
            //save term info
            term = (from c in db.CpTerms where c.Id == term_id select c).SingleOrDefault();
            if (term == null) return;
            term.Code = txbTerm_termCode.Text.Trim();
            term.Name = txbTerm_termName.Text.Trim();
            var year = tbdropbxTerm_Year.SelectedValue;
            if ((year != null) && (year.GetType() == typeof(int)))
                term.Year = Convert.ToInt32(year);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //save grade info
            //if there is no grade input, just save term and exit
            if (isNullString(txbTerm_gradeCode.Text) || isNullString(txbTerm_gradeName.Text))
            {
                MessageBox.Show("編集完了しました");
                loadGradeAndClassOfTerm(term.Id);
                return;
            }
            // if there is grade input
            //1. check if grade of term existed or not
            var grade = (from c in db.CpGradeCodes
                        where c.Code == txbTerm_gradeCode.Text.Trim() && c.TermId == term.Id
                         select c).SingleOrDefault();
            //1. if grade of term not existed, create new
            if (grade == null)
            {
                grade = new CpGradeCode();
                grade.Code = txbTerm_gradeCode.Text.Trim();
                grade.Name = txbTerm_gradeName.Text.Trim();
                grade.TermId = term.Id;
                db.CpGradeCodes.Add(grade);
            }
            else
            {
                grade.Code = txbTerm_gradeCode.Text.Trim();
                grade.Name = txbTerm_gradeName.Text.Trim();
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //save class info
            //if there is no class input, just save term, grade and exit
            if (isNullString(txbTerm_classCode.Text) || isNullString(txbTerm_className.Text))
            {
                MessageBox.Show("編集完了しました");
                loadGradeAndClassOfTerm(term.Id);
                return;
            }
            //1. check if class of grade existed or not
            var classOfGrade = (from c in db.CpClasses
                        where c.Code == txbTerm_classCode.Text.Trim() && c.TermId == term.Id && c.GradeCodeId == grade.Id
                         select c).SingleOrDefault();
            if (classOfGrade == null)
            {
                classOfGrade = new CpClass();
                classOfGrade.Code = txbTerm_classCode.Text.Trim();
                classOfGrade.Name = txbTerm_className.Text.Trim();
                classOfGrade.SchoolId = schoolId;
                classOfGrade.TermId = term.Id;
                classOfGrade.GradeCodeId = grade.Id;
                db.CpClasses.Add(classOfGrade);
            }
            else
            {
                classOfGrade.Code = txbTerm_classCode.Text.Trim();
                classOfGrade.Name = txbTerm_className.Text.Trim();
            }
            try
            {
                db.SaveChanges();
                MessageBox.Show("編集完了しました");
                loadGradeAndClassOfTerm(term.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * load grade list and class list of term
         */
        private void loadGradeAndClassOfTerm(int termId)
        {
            gridViewTerm_GradeClassList.Rows.Clear();
            var gradeList = (from g in db.CpGradeCodes
                            where g.TermId == termId
                            select g);
            gradeList.OrderBy(g => g.Code);
            if (!gradeList.Any()) return;
            foreach (var grade in gradeList)
            {
                var classList = (from c in db.CpClasses
                                 where c.SchoolId == schoolId && c.TermId == termId && c.GradeCodeId == grade.Id
                                 select c);
                classList.OrderBy(c => c.Code);
                if (!classList.Any()) continue;
                foreach (var classOfGrade in classList)
                {
                    gridViewTerm_GradeClassList.Rows.Add(grade.Code, grade.Name,classOfGrade.Code,classOfGrade.Name );
                }
                
            }
        }

        private void btnTerm_Cancel_Click(object sender, EventArgs e)
        {
            //keep term master if in editing mode
            if (!isEditMode)
            {
                txbTerm_termCode.Text = "";
                txbTerm_termName.Text = "";
            }

            txbTerm_classCode.Text = "";
            txbTerm_className.Text = "";
            txbTerm_gradeCode.Text = "";
            txbTerm_gradeName.Text = "";
        }

        private void btnTerm_Edit_Click(object sender, EventArgs e)
        {
            var index = gridViewTerm_GradeClassList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTerm_GradeClassList.Rows[index];
            if (row.Cells[1].Value == null) return;
            txbTerm_gradeCode.Text = row.Cells[0].Value.ToString();
            txbTerm_gradeName.Text = row.Cells[1].Value.ToString();
            txbTerm_classCode.Text = row.Cells[2].Value.ToString();
            txbTerm_className.Text = row.Cells[3].Value.ToString();
        }
        private void btnTerm_deleteClass_Click(object sender, EventArgs e)
        {
            //confirm delete data
            var confirmResult = MessageBox.Show("選択されたクラスを削除しますか？", "クラス削除確認!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) return;

            var index = gridViewTerm_GradeClassList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTerm_GradeClassList.Rows[index];
            if (row.Cells[1].Value == null) return;
            string classCode = row.Cells[2].Value.ToString();
            string gradeCode = row.Cells[0].Value.ToString();
            deleteClass(classCode,gradeCode);
            loadGradeAndClassOfTerm(term_id);
            //gridViewTerm_GradeClassList.Rows.RemoveAt(index);
        }

        /*********************************/
        //access db
        /**
         * delete term with term id
         * param: term id
        */
        private bool deleteClass(string classCode, string gradeCode)
        {
            var classOfCodeRecord = (from c in db.CpClassStaffs where c.TermId == term_id && c.ClassId == class_id select c).SingleOrDefault();
            if (classOfCodeRecord != null)
            {
                try
                {
                    db.CpClassStaffs.Remove(classOfCodeRecord);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }

            var grade = (from c in db.CpGradeCodes where c.Code == gradeCode && c.TermId == term_id select c).SingleOrDefault();
            if (grade == null) return false;
            var classOfGrade = (from c in db.CpClasses where c.SchoolId == schoolId && c.Code == classCode && c.GradeCodeId == grade.Id && c.TermId == term_id select c).SingleOrDefault();
            if (classOfGrade == null) return false;

            try
            {
                db.CpClasses.Remove(classOfGrade);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        /********************************/
        //validate methods
       
        /**
         * method to validate string 
        */
        private bool isNullString(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /**
         * method to validate term code existed
         */
        private bool isExistedTermCode(string code)
        {
            var term = (from c in db.CpTerms
                             where c.Code == code
                             select c);
            return term.Any();
        }

        /**
         * method to validate grade existed
         */
        private bool isExistedGradeCodeOfTerm(int termId, string gradeCode)
        {
            var grade = (from c in db.CpGradeCodes
                        where c.Code == gradeCode && c.TermId == termId
                        select c);
            return grade.Any();
        }

        private void tbdropbxTerm_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = tbdropbxTerm_Year.SelectedValue;
            if((year != null) && year.GetType() == typeof(int))
                txbTerm_termName.Text = year + "年度学年クラス";
        }

        private void FrmTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txbTerm_termCode_TextChanged(object sender, EventArgs e)
        {
            if (txbTerm_termCode.Text.Length > 0 && txbTerm_termCode.BackColor == System.Drawing.Color.Red)
            {
                txbTerm_termCode.BackColor = System.Drawing.Color.White; // TextBox.DefaultBackColor;
            }
            if (txbTerm_termCode.Text.Length > 0)
            {
               // loadTermByCode(txbTerm_termCode.Text);
                string termCode = txbTerm_termCode.Text;
                var term = (from c in db.CpTerms where c.Code == termCode && c.SchoolId == schoolId select c).SingleOrDefault();
                if (term != null)
                {
                    // txt_Code.Text = cp_buidings.Code.ToString();
                    txbTerm_termCode.Text = termCode;
                    txbTerm_termName.Text = term.Name;
                    tbdropbxTerm_Year.Text = Convert.ToString(term.Year);
                }
                else
                {
                    //reset
                    // txt_Code.Text = "";
                    //txbTerm_termCode.Text = "";
                    txbTerm_termName.Text = "";
                    tbdropbxTerm_Year.Text = "";
                }

            }
        }

        private void txbTerm_termCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 13)
            {

            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }

            
           /* if (e.KeyChar == (char)13)
            {
                loadTermByCode(txbTerm_termCode.Text.Trim());
            }
            * */
        }

        string makeCodeParam(string code)
        {
            while (code.Length < 5)
            {
                code = "0" + code;
            }
            return code;
        }

        /**
         * staff code refactor
         * 1 -> 000001
         * */
        string make2DigitParam(string code)
        {
            while (code.Length < 2)
            {
                code = "0" + code;
            }
            return code;
        }

        private void txbTerm_termCode_Leave(object sender, EventArgs e)
        {
            txbTerm_termCode.Text = makeCodeParam(txbTerm_termCode.Text.Trim());
        }

        private void txbTerm_gradeCode_Leave(object sender, EventArgs e)
        {
            txbTerm_gradeCode.Text = make2DigitParam(txbTerm_gradeCode.Text.Trim());
        }

        private void txbTerm_classCode_Leave(object sender, EventArgs e)
        {
            txbTerm_classCode.Text = make2DigitParam(txbTerm_classCode.Text.Trim());
        }


        //validate input data.
        private bool validate()
        {
            bool validate = true;

            if (isNullString(txbTerm_termCode.Text))
            {
                validate = false;
                txbTerm_termCode.BackColor = System.Drawing.Color.Red;
            }


            if (isNullString(tbdropbxTerm_Year.Text))
            {
                validate = false;
                tbdropbxTerm_Year.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txbTerm_termName.Text))
            {
                validate = false;
                txbTerm_termName.BackColor = System.Drawing.Color.Red;
            }
            if (txbTerm_classCode.Text.Trim().Length > 2)
            {
                validate = false;
                txbTerm_classCode.BackColor = System.Drawing.Color.Red;
            }
            if(txbTerm_gradeCode.Text.Trim().Length > 2)
            {
                validate = false;
                txbTerm_gradeCode.BackColor = System.Drawing.Color.Red;
            }
            return validate;
        }

        private void txbTerm_termName_TextChanged(object sender, EventArgs e)
        {
            if (txbTerm_termName.Text.Length > 0 && txbTerm_termName.BackColor == System.Drawing.Color.Red)
            {
                txbTerm_termName.BackColor = System.Drawing.Color.White; // TextBox.DefaultBackColor;
            }
        }

        private void tbdropbxTerm_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetInput()
        {
            txbTerm_termCode.Text = "";
            tbdropbxTerm_Year.Text = "";
            txbTerm_termName.Text = "";
            txbTerm_gradeCode.Text = "";
            txbTerm_gradeName.Text = "";
            txbTerm_classCode.Text = "";
            txbTerm_className.Text = "";

        }

        private void txbTerm_gradeCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 13)
            {

            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

        private void txbTerm_classCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 13)
            {

            }
            else
            {
                MessageBox.Show("You Can Only Enter A Number!");
                e.Handled = true;
            }
        }

        private void txbTerm_gradeCode_TextChanged(object sender, EventArgs e)
        {
            if (txbTerm_gradeCode.Text.Length > 0 && txbTerm_gradeCode.BackColor == System.Drawing.Color.Red)
            {
                txbTerm_gradeCode.BackColor = System.Drawing.Color.White; // TextBox.DefaultBackColor;
            }
            if (txbTerm_gradeCode.Text.Length > 0)
            {
                loadTermByCode(txbTerm_termCode.Text);
                string gradeCode = txbTerm_gradeCode.Text;
                var gradeCodes = (from c in db.CpGradeCodes where c.Code == gradeCode && c.TermId == term_id  select c).SingleOrDefault();
                if (gradeCodes != null)
                {
                    // txt_Code.Text = cp_buidings.Code.ToString();
                    txbTerm_gradeCode.Text = gradeCode;
                    txbTerm_gradeName.Text = gradeCodes.Name;
                }
                else
                {
                    txbTerm_gradeName.Text = "";
                }

            }
        }

        private void txbTerm_classCode_TextChanged(object sender, EventArgs e)
        {
            if (txbTerm_classCode.Text.Length > 0 && txbTerm_classCode.BackColor == System.Drawing.Color.Red)
            {
                txbTerm_classCode.BackColor = System.Drawing.Color.White; // TextBox.DefaultBackColor;
            }
            if (txbTerm_classCode.Text.Length > 0)
            {
                loadTermByCode(txbTerm_termCode.Text);
                string classCode = txbTerm_classCode.Text;
                string gradeCode = txbTerm_gradeCode.Text.Trim();
                var gcRecord = (from c in db.CpGradeCodes where c.TermId == term_id && c.Code == gradeCode select c).SingleOrDefault();
                int gradeCodeId = (gcRecord != null) ? gcRecord.Id : -1;
                var classCodes = (from c in db.CpClasses where c.Code == classCode && c.TermId == term_id && c.GradeCodeId == gradeCodeId select c).SingleOrDefault();
                if (classCodes != null)
                {
                    // txt_Code.Text = cp_buidings.Code.ToString();
                    txbTerm_classCode.Text = classCode;
                    txbTerm_className.Text = classCodes.Name;
                }
                else
                {
                    txbTerm_className.Text = "";
                }

            }
        }

        private void gridViewTerm_GradeClassList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = gridViewTerm_GradeClassList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTerm_GradeClassList.Rows[index];
            if (row.Cells[1].Value == null) return;
            txbTerm_gradeCode.Text = row.Cells[0].Value.ToString().Trim();
            txbTerm_gradeName.Text = row.Cells[1].Value.ToString().Trim();
            txbTerm_classCode.Text = row.Cells[2].Value.ToString().Trim();
            txbTerm_className.Text = row.Cells[3].Value.ToString().Trim();

            //load staff to table
            //01. get term Id
            int termId = term_id;

            //02. get classId
            var gcRecord = (from c in db.CpGradeCodes where c.TermId == termId && c.Code == txbTerm_gradeCode.Text select c).SingleOrDefault();
            int gradeCodeId = (gcRecord != null) ? gcRecord.Id : -1;
            var cRecord = (from c in db.CpClasses where c.Code == txbTerm_classCode.Text && c.TermId == term_id && c.GradeCodeId == gradeCodeId && c.SchoolId == schoolId select c).SingleOrDefault();
            int classId = (cRecord != null) ? cRecord.Id : -1;
            class_id = classId;

            //03. load staffs of class by term id and class id
            if (termId > 0 && classId > 0)
            {
                loadStaffOfClass(termId, classId);
            }
        }

        /**
         * load staff of class 
         * param1: term id
         * param2: class id
         * output: list staff in table
         **/
        private void loadStaffOfClass(int termId, int classId)
        {
            dgvTerm_StaffList.Rows.Clear();

            var staffsClassRecord = (from c in db.CpClassStaffs where c.ClassId == classId && c.TermId == termId select c).SingleOrDefault();
            if (staffsClassRecord != null)
            {
                int staff1_id = staffsClassRecord.StaffId1;
                string[] attr = staffAttributes(staff1_id);
                dgvTerm_StaffList.Rows.Add(attr[0] + "　(担任)", attr[1], staff1_id);
            }
            else
            {
                dgvTerm_StaffList.Rows.Add();
            }



            if (staffsClassRecord != null && staffsClassRecord.StaffId2 != null)
            {
                int staffId = (int)staffsClassRecord.StaffId2;
                string[] attr = staffAttributes(staffId);
                dgvTerm_StaffList.Rows.Add(attr[0], attr[1], staffId);
            }
            else
            {
                dgvTerm_StaffList.Rows.Add();
            }
            if (staffsClassRecord != null &&  staffsClassRecord.StaffId3 != null)
            {
                int staffId = (int)staffsClassRecord.StaffId3;
                string[]  attr = staffAttributes(staffId);
                dgvTerm_StaffList.Rows.Add(attr[0], attr[1], staffId);
            }
            else
            {
                dgvTerm_StaffList.Rows.Add();
            }

            if (staffsClassRecord != null &&  staffsClassRecord.StaffId4 != null)
            {
                int staffId = (int)staffsClassRecord.StaffId4;
                string[]  attr = staffAttributes(staffId);
                dgvTerm_StaffList.Rows.Add( attr[0], attr[1], staffId);
            }
            else
            {
                dgvTerm_StaffList.Rows.Add();
            }

            if (staffsClassRecord != null &&  staffsClassRecord.StaffId5 != null)
            {
                int staffId = (int)staffsClassRecord.StaffId5;
                string[]  attr = staffAttributes(staffId);
                dgvTerm_StaffList.Rows.Add( attr[0], attr[1], staffId);
            }
            else
            {
                dgvTerm_StaffList.Rows.Add();
            }

            if (staffsClassRecord != null &&  staffsClassRecord.StaffId6 != null)
            {
                int staffId = (int)staffsClassRecord.StaffId6;
                string[]  attr = staffAttributes(staffId);
                dgvTerm_StaffList.Rows.Add( attr[0], attr[1], staffId);
            }
            else
            {
                dgvTerm_StaffList.Rows.Add();
            }
        }

        /**
         *  load staff full name from staff id
         *  param: staff id
         *  return : {staff.Name + staff.Name2, staff job type}
         * */
        private string[] staffAttributes(int id)
        {
            var staffRecord = (from c in db.CpStaffs where c.Id == id select c).SingleOrDefault();
            if (staffRecord == null) return null;
            string fullname = staffRecord.Name + "　" + staffRecord.Name2;
            string staffType = staffRecord.CpStaffType.Name;
            return new string[] {fullname, staffType};
        }

        private void dgvTerm_StaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStaffRowIndex = e.RowIndex;
            Staffs staffScreen = new Staffs();
            staffScreen._setSchoolId = schoolId.ToString();
            staffScreen.MyGetData = new Staffs.GetString(GetValueStaff);
            staffScreen.Show();
        }

        //delegate method
        //get staff from Staffs Screen
        private void GetValueStaff(String Id, String Name, String Row, String Column)
        {
            if (selectedStaffRowIndex == -1) 
                addStaffOfClass(Convert.ToInt32(Id));
            else
             updateStaffOfClass(Convert.ToInt32(Id),selectedStaffRowIndex);
        }

        /**
         *  update staff of class
         *  param1: staff id
         *  param2: row index
         */ 
        private void updateStaffOfClass(int staffId, int rowIndex)
        {
            rowIndex++;
            var staffsClassRecord = (from c in db.CpClassStaffs where c.ClassId == class_id && c.TermId == term_id select c).SingleOrDefault();
            if (staffsClassRecord == null) return;

            if (rowIndex == 1)
            {
                staffsClassRecord.StaffId1 = staffId;
            }
            if (rowIndex == 2)
            {
                staffsClassRecord.StaffId2 = staffId;
            }
            if (rowIndex == 3)
            {
                staffsClassRecord.StaffId3 = staffId;
            }
            if (rowIndex == 4)
            {
                staffsClassRecord.StaffId4 = staffId;
            }
            if (rowIndex == 5)
            {
                staffsClassRecord.StaffId5 = staffId;
            }
            if (rowIndex == 6)
            {
                staffsClassRecord.StaffId6 = staffId;
            }

            try
            {
                //save to database
                db.SaveChanges();

                //output to table
                string[] attr = staffAttributes(staffId);
                if (rowIndex == 1)
                {
                    dgvTerm_StaffList[0, rowIndex - 1].Value = attr[0] + "　(担任)";
                }
                else
                {
                    dgvTerm_StaffList[0, rowIndex - 1].Value = attr[0];
                }
                dgvTerm_StaffList[1, rowIndex - 1].Value = attr[1];
                dgvTerm_StaffList[2, rowIndex - 1].Value = staffId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        /**
         *  add  staff of class
         *  param1: staff id
         *  param2: row index
         */ 
        private void addStaffOfClass(int staffId)
        {
            var staffsClassRecord = (from c in db.CpClassStaffs where c.ClassId == class_id && c.TermId == term_id select c).SingleOrDefault();
            if (staffsClassRecord == null)
            {
                staffsClassRecord = new CpClassStaff();
                staffsClassRecord.ClassId = class_id;
                staffsClassRecord.TermId = term_id;
                staffsClassRecord.StaffId1 = staffId;
                db.CpClassStaffs.Add(staffsClassRecord);
                try
                {
                    //save to database
                    db.SaveChanges();

                    //output to table
                    string[] attr = staffAttributes(staffId);
                    dgvTerm_StaffList[0, 0].Value = attr[0] + "　(担任)";
                    dgvTerm_StaffList[1, 0].Value = attr[1];
                    dgvTerm_StaffList[2, 0].Value = staffId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                int rowIndex = -1;
                if (staffsClassRecord.StaffId2 == null)
                {
                    staffsClassRecord.StaffId2 = staffId;
                    rowIndex = 1;
                }
                else if (staffsClassRecord.StaffId3 == null)
                {
                    staffsClassRecord.StaffId3 = staffId;
                    rowIndex = 2;
                }
                else if (staffsClassRecord.StaffId4 == null)
                {
                    staffsClassRecord.StaffId4 = staffId;
                    rowIndex = 3;
                }
                else if (staffsClassRecord.StaffId5 == null)
                {
                    staffsClassRecord.StaffId5 = staffId;
                    rowIndex = 4;
                }
                else if (staffsClassRecord.StaffId6 == null)
                {
                    staffsClassRecord.StaffId6 = staffId;
                    rowIndex = 5;
                }

                try
                {
                    //save to database
                    db.SaveChanges();

                    //output to table
                    string[] attr = staffAttributes(staffId);
                    if (rowIndex > 0)
                    {
                        dgvTerm_StaffList[0, rowIndex].Value = attr[0];
                        dgvTerm_StaffList[1, rowIndex].Value = attr[1];
                        dgvTerm_StaffList[2, rowIndex].Value = staffId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTerm_StaffOfClassNew_Click(object sender, EventArgs e)
        {
            var staffsClassRecord = (from c in db.CpClassStaffs where c.ClassId == class_id && c.TermId == term_id select c).SingleOrDefault();
            if (staffsClassRecord != null && staffsClassRecord.StaffId6 != null) return;

            selectedStaffRowIndex = -1;
            Staffs staffScreen = new Staffs();
            staffScreen._setSchoolId = schoolId.ToString();
            staffScreen.MyGetData = new Staffs.GetString(GetValueStaff);
            staffScreen.Show();
        }

        private void btnTerm_StaffOfClassDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTerm_StaffList.CurrentRow.Index;
            if (rowIndex < 0 || rowIndex > 6) return;

            var staffsClassRecord = (from c in db.CpClassStaffs where c.ClassId == class_id && c.TermId == term_id select c).SingleOrDefault();
            if (staffsClassRecord == null) return;

            if (rowIndex == 0)
            {
                //confirm delete data
                var confirmResult = MessageBox.Show("担任を削除するとクラスの職員が自動的に削除されます。よろしでしょうか？", "クラスの職員削除確認", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No) return;

                db.CpClassStaffs.Remove(staffsClassRecord);
            }
            else if (rowIndex == 1)
            {
                staffsClassRecord.StaffId2 = null;
            }
            else if (rowIndex == 2)
            {
                staffsClassRecord.StaffId3 = null;
            }
            else if (rowIndex == 3)
            {
                staffsClassRecord.StaffId4 = null;
            }
            else if (rowIndex == 4)
            {
                staffsClassRecord.StaffId5 = null;
            }
            else if (rowIndex == 5)
            {
                staffsClassRecord.StaffId6 = null;
            }
            try
            {
                db.SaveChanges();
                if (rowIndex == 0)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        dgvTerm_StaffList[0, i].Value = "";
                        dgvTerm_StaffList[1, i].Value = "";
                        dgvTerm_StaffList[2, i].Value = "";
                    }
                }
                dgvTerm_StaffList[0, rowIndex].Value = "";
                dgvTerm_StaffList[1, rowIndex].Value = "";
                dgvTerm_StaffList[2, rowIndex].Value = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
