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


namespace Chapy
{
    public partial class FrmSchoolSelect : Form
    {
        chapyEntities db = new chapyEntities();
        public FrmSchoolSelect()
        {
            InitializeComponent();
        }

        private void btn_GoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            VariableGlobal.school_id = Convert.ToInt32(cbb_List_School.SelectedValue);
            int school_id = VariableGlobal.school_id;
            var obi_school = (from s in db.CpSchools where s.Id == school_id select s).Single();
            VariableGlobal.school_name = obi_school.Name;

            FrmMain main = new FrmMain();
            main.Show();
        }

        private void FrmSchoolSelect_Load(object sender, EventArgs e)
        {
            #region load combox School
            Dictionary<int, string> obj_schools = new Dictionary<int, string>();

            var list_schools = from s in db.CpSchools select s;

            if (list_schools.Any())
            {
                foreach (var list_school in list_schools)
                {
                    obj_schools.Add(list_school.Id, list_school.Name);
                }
                cbb_List_School.DataSource = new BindingSource(obj_schools, null);
                cbb_List_School.DisplayMember = "Value";
                cbb_List_School.ValueMember = "Key";
            }
            #endregion

            VariableGlobal.Codes.Clear();
            VariableGlobal.Names.Clear();
            VariableGlobal.Sexs.Clear();
            VariableGlobal.Birthdays.Clear();
            VariableGlobal.StaffIds.Clear();
        }
    }

    public class VariableGlobal
    {
        public static Int32 school_id = 0;
        public static string school_name = "";
        public static string position_name = null;
        public static Int32 position_id = 0;
        public static Int32 staff_type_id = 0;
        public static Int32 groupe_id = 0;
        public static Int32 building_id = 0;
        public static string group_code = null;
        public static ArrayList Codes = new ArrayList();
        public static ArrayList Names = new ArrayList();
        public static ArrayList Sexs = new ArrayList();
        public static ArrayList Birthdays = new ArrayList();
        public static ArrayList data_staffs = new ArrayList();
        public static ArrayList StaffIds = new ArrayList();
        


    }
}
