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
    public partial class FrmTerm : Form
    {
        //school id
        private static int schoolId { get; set; }

        //is in edit mode or not
        private bool isEditMode = false;
        
        //database access
        chapyEntities db = new chapyEntities();

        //edit term_id
        int term_id;

        //edit term_code
        string term_code;

        //edit term_name
        string term_name;

        //start year
        int startYear = 1990;

        //add new term initialization
        public FrmTerm()
        {
            InitializeComponent();
            schoolId = VariableGlobal.school_id;

            #region load combox year
            Dictionary<int?, string> obj_years = new Dictionary<int?, string>();
            int currentYear = DateTime.Now.Year;
            for (int i = startYear; i < currentYear + 6; i++)    //add to next 5 years
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
                          where c.Code == code && c.Name == name
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
            for (int i = startYear; i < currentYear + 6; i++)    //add to next 5 years
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
            this.Hide();
            FrmTermList termList_Screen = new FrmTermList();
            termList_Screen.Show();
        }

        /**
         * save new term 
         */
        private void saveNewTerm()
        {
            //check if term exited or not
            if(isExistedTermCode(txbTerm_termCode.Text.Trim()))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadGradeAndClassOfTerm(term.Id);
        }

        /**
         * save edited term
         */
        private void saveEditedTerm()
        {
            //check term code existed or not
            var term = (from c in db.CpTerms where c.Code == txbTerm_termCode.Text.Trim() select c).SingleOrDefault();
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
            if (!gradeList.Any()) return;
            foreach (var grade in gradeList)
            {
                var classList = (from c in db.CpClasses
                                 where c.SchoolId == schoolId && c.TermId == termId && c.GradeCodeId == grade.Id
                                 select c);
                if (!classList.Any()) continue;
                foreach (var classOfGrade in classList)
                {
                    DataGridViewRow row = (DataGridViewRow)gridViewTerm_GradeClassList.Rows[0].Clone();
                    row.Cells[1].Value = grade.Code;
                    row.Cells[2].Value = grade.Name;
                    row.Cells[3].Value = classOfGrade.Code;
                    row.Cells[4].Value = classOfGrade.Name;
                    gridViewTerm_GradeClassList.Rows.Add(row);
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
            txbTerm_gradeCode.Text = row.Cells[1].Value.ToString();
            txbTerm_gradeName.Text = row.Cells[2].Value.ToString();
            txbTerm_classCode.Text = row.Cells[3].Value.ToString();
            txbTerm_className.Text = row.Cells[4].Value.ToString();
        }
        private void btnTerm_deleteClass_Click(object sender, EventArgs e)
        {
            var index = gridViewTerm_GradeClassList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTerm_GradeClassList.Rows[index];
            if (row.Cells[1].Value == null) return;
            string classCode = row.Cells[3].Value.ToString();
            string gradeCode = row.Cells[1].Value.ToString();
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
    }
}
