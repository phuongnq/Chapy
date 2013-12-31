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
    public partial class FrmTermList : Form
    {
        //school id
        public static int schoolId { get; set;}
        //database access
        chapyEntities db = new chapyEntities();

        public FrmTermList()
        {
            InitializeComponent();
            schoolId = VariableGlobal.school_id;
        }

        private void gridViewTermList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnTerm_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain();
            main.Show();
        }

        /**
         * when opening form, load term list from db
         */
        private void FrmTermList_Load(object sender, EventArgs e)
        {
            loadTermList(schoolId);
        }

        /**
         * click delete button
         * 1. delete in CpClass
         * 2. delete in CpTerm
         */
        private void btTerm_Delete_Click(object sender, EventArgs e)
        {
            var index = gridViewTermList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTermList.Rows[index];
            if (row.Cells[0].Value == null) return;

            //confirm delete data
            var confirmResult = MessageBox.Show("この学年クラスマスタを削除しますか？", "学年クラスマスタ削除確認!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) return;

            string termCode = row.Cells[0].Value.ToString();
            var term = (from c in db.CpTerms
                        where c.Code == termCode
                        select c).SingleOrDefault();
            if (term == null) return;
            int termId = term.Id;

            deleteClass(termId);
            deleteTerm(termId);
            gridViewTermList.Rows.RemoveAt(index);
        }
        /**
         * get currrent selected row code
         */
        private string getCurrentTermCode()
        {
            var index = gridViewTermList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTermList.Rows[index];
            if (row.Cells[0].Value == null) return null;
            return row.Cells[0].Value.ToString();
        }

        /**
         * get current selected row name 
         */
        private string getCurrentTermName()
        {
            var index = gridViewTermList.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)gridViewTermList.Rows[index];
            if (row.Cells[0].Value == null) return null;
            return row.Cells[1].Value.ToString();
        }

        /**
        * get list term of school
         * param: school id
        */
        private void loadTermList(int schoolId)
        {
            var termList = (from c in db.CpTerms
                            where c.SchoolId == schoolId
                            select c);
            if (!termList.Any()) return;
            foreach (var term in termList)
            {
                DataGridViewRow row = (DataGridViewRow)gridViewTermList.Rows[0].Clone();
                row.Cells[0].Value = term.Code;
                row.Cells[1].Value = term.Name;
                gridViewTermList.Rows.Add(row);
            }
        }

        /**
         * delete term with term id
         * param: term id
        */
        private bool deleteTerm(int id)
        {
            var term = (from t in db.CpTerms where t.Id == id select t).SingleOrDefault();
            if (term == null) return false;

            try
            {
                db.CpTerms.Remove(term);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        /**
         * delete class with term id 
         * param: term id
         */
        private bool deleteClass(int termId)
        {
            var classList = (from c in db.CpClasses where c.TermId == termId select c);
            foreach(var c in classList)
            {
                try
                {
                    db.CpClasses.Remove(c);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            return true;
        }

        private void btnTerm_Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTerm term_Screen = new FrmTerm();
            term_Screen.Show();
        }

        private void btnTerm_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTerm edit_Term = new FrmTerm(getCurrentTermCode(),getCurrentTermName());
            edit_Term.Show();
        }
    }
}
