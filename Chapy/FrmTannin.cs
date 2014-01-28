using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.Data.Objects;
using System.Messaging;

namespace Chapy
{
    public partial class FrmTannin : Form
    {
        private Int32 D_INX_TAN_REC = 0;
        private Int32 D_SCHOOL_ID = 0;
        private String D_MOD = "";

        private static List<int> staffSelected;
        chapyEntities db = new chapyEntities();

        public FrmTannin(Int32 D_Tan_Nin_ID, String D_MODE)
        {
            InitializeComponent();
            D_INX_TAN_REC = D_Tan_Nin_ID;
            D_MOD = D_MODE;
            //txt_TanninId.Text = D_Tan_Nin_ID.ToString();
            D_SCHOOL_ID = VariableGlobal.school_id;

           
            staffSelected = new List<int>();
            loadContent();
            load_term();

            //txtDrd_Term.DataBindings.Add(
        }


        private void load_combobox_school()
        {
            //#region load combox school
            //Dictionary<int, string> obj_schools = new Dictionary<int, string>();
            //obj_schools.Add(VariableGlobal.school_id, VariableGlobal.school_name);

            //cbb_Schools.DataSource = new BindingSource(obj_schools, null);
            //cbb_Schools.DisplayMember = "Value";
            //cbb_Schools.ValueMember = "Key";

            //#endregion

            #region load combox School
            Dictionary<int, string> obj_schools = new Dictionary<int, string>();

            var list_schools = from s in db.CpSchools select s;

            if (list_schools.Any())
            {
                foreach (var list_school in list_schools)
                {
                    obj_schools.Add(list_school.Id, list_school.Name);
                }
                cbb_Schools.DataSource = new BindingSource(obj_schools, null);
                cbb_Schools.DisplayMember = "Value";
                cbb_Schools.ValueMember = "Key";
            }
            #endregion
        }

        private void load_term()
        {
            var dataSource = (from t in db.CpTerms
                              where t.SchoolId == D_SCHOOL_ID
                              select
                                  new
                                  {
                                      Key = t.Year,
                                      Value = t.Name
                                  }).ToArray();

            cb_Term.DataSource = new BindingSource(dataSource, null);
            cb_Term.DisplayMember = "Value";
            cb_Term.ValueMember = "Key";
        }

        private void loadContent()
        {
            if (D_MOD == "A")
            {
                var cpClass = (from c in db.CpClasses where c.SchoolId == D_SCHOOL_ID orderby c.GradeCodeId select c).ToList();

                int i = 0;
                if (cpClass.Count > 0)
                {
                    DAT_GRI_VIW.RowCount = cpClass.Count;
                    foreach (var item in cpClass)
                    {
                        DAT_GRI_VIW[0, i].Value = true;
                        DAT_GRI_VIW[1, i].Value = item.GradeCodeId;
                        DAT_GRI_VIW[2, i].Value = item.CpGradeCode.Name;
                        DAT_GRI_VIW[3, i].Value = item.Id;
                        DAT_GRI_VIW[4, i].Value = item.Name;

                        i++;
                    }
                }
            }
            else if (D_MOD == "E")
            {
                var tannin = (from t in db.CpTannins where t.Id == D_INX_TAN_REC select t).SingleOrDefault();
                if (tannin != null)
                {
                    txt_Code.Text = tannin.Code;
                    txt_Code.Enabled = false;
                }

                var cpClassStaff = (from cs in db.CpClassStaffs where cs.TanninId == D_INX_TAN_REC select cs).ToList();

                int i = 0;
                if (cpClassStaff.Count > 0)
                {
                    DAT_GRI_VIW.RowCount = cpClassStaff.Count;
                    foreach (var item in cpClassStaff)
                    {
                        DAT_GRI_VIW[0, i].Value = true;
                        DAT_GRI_VIW[1, i].Value = item.CpClass.GradeCodeId;
                        DAT_GRI_VIW[2, i].Value = item.CpClass.CpGradeCode.Name;
                        DAT_GRI_VIW[3, i].Value = item.CpClass.Id;
                        DAT_GRI_VIW[4, i].Value = item.CpClass.Name;

                        DAT_GRI_VIW[5, i].Value = item.NumberOfStaff;

                        var staff1 = (from s in db.CpStaffs where s.Id == item.StaffId1 select s).SingleOrDefault();
                        if (staff1 != null)
                        {
                            DAT_GRI_VIW[6, i].Value = staff1.Name;
                            DAT_GRI_VIW[12, i].Value = staff1.Id;
                            staffSelected.Add(staff1.Id);
                        }

                        var staff2 = (from s in db.CpStaffs where s.Id == item.StaffId2 select s).SingleOrDefault();
                        if (staff2 != null)
                        {
                            DAT_GRI_VIW[7, i].Value = staff2.Name;
                            DAT_GRI_VIW[13, i].Value = staff2.Id;
                            staffSelected.Add(staff2.Id);
                        }

                        var staff3 = (from s in db.CpStaffs where s.Id == item.StaffId3 select s).SingleOrDefault();
                        if (staff3 != null)
                        {
                            DAT_GRI_VIW[8, i].Value = staff3.Name;
                            DAT_GRI_VIW[14, i].Value = staff3.Id;
                            staffSelected.Add(staff3.Id);
                        }

                        var staff4 = (from s in db.CpStaffs where s.Id == item.StaffId4 select s).SingleOrDefault();
                        if (staff4 != null)
                        {
                            DAT_GRI_VIW[9, i].Value = staff4.Name;
                            DAT_GRI_VIW[15, i].Value = staff4.Id;
                            staffSelected.Add(staff4.Id);
                        }

                        var staff5 = (from s in db.CpStaffs where s.Id == item.StaffId5 select s).SingleOrDefault();
                        if (staff5 != null)
                        {
                            DAT_GRI_VIW[10, i].Value = staff5.Name;
                            DAT_GRI_VIW[16, i].Value = staff5.Id;
                            staffSelected.Add(staff5.Id);
                        }

                        var staff6 = (from s in db.CpStaffs where s.Id == item.StaffId6 select s).SingleOrDefault();
                        if (staff6 != null)
                        {
                            DAT_GRI_VIW[11, i].Value = staff6.Name;
                            DAT_GRI_VIW[17, i].Value = staff6.Id;
                            staffSelected.Add(staff6.Id);
                        }

                        i++;
                    }
                }
            }
        }

        private void GetValueStaff(String Id, String Name, String Row, String Column)
        {
            try
            {
                int column = int.Parse(Column);
                int row = int.Parse(Row);
                int id = int.Parse(Id);

                //check xem giao vien nay da duoc chon hay chua?
                var exist = staffSelected.FirstOrDefault(s => s == id);

                if (exist == 0)
                {
                    DAT_GRI_VIW[column, row].Value = Name;
                    DAT_GRI_VIW[column + 6, row].Value = Id;
                }
                else
                {
                    MessageBox.Show("Staff is selected");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void DAT_GRI_VIW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.ColumnIndex)
                {
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        Staffs frmStaff = new Staffs();
                        frmStaff._setSchoolId = D_SCHOOL_ID.ToString();
                        frmStaff._setColumn = e.ColumnIndex.ToString();
                        frmStaff._setRow = e.RowIndex.ToString();
                        frmStaff.MyGetData = new Staffs.GetString(GetValueStaff);
                        frmStaff.Show();
                        break;

                    default:
                        //default stuff
                        break;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (validate() == false)
            {
                return;
            }
            Int32 D_LAG = 0;


            try
            {
                for (int i = 0; i < DAT_GRI_VIW.RowCount; i++)
                {
                    if (DAT_GRI_VIW[0, i].Value != null && DAT_GRI_VIW[0, i].Value.ToString().Equals("True"))
                    {
                        D_LAG = D_LAG + 1;
                    }
                }

                if (D_LAG <= 0)
                {
                    MessageBox.Show("Please choose at least row to insert or update");
                    return;
                }
                CpTannin tannin;

                if (D_MOD == "A")
                {
                    tannin = new CpTannin();
                    tannin.SchoolId = D_SCHOOL_ID;
                    tannin.Code = txt_Code.Text;
                    tannin.Name = txt_Name.Text;
                    db.CpTannins.Add(tannin);
                    db.SaveChanges();
                   
                }
                else
                {
                    tannin = (from t in db.CpTannins where t.Id == D_INX_TAN_REC select t).SingleOrDefault();
                }

                int countSave = 0;
                for (int i = 0; i < DAT_GRI_VIW.RowCount; i++)
                {
                    if (DAT_GRI_VIW[0, i].Value != null && DAT_GRI_VIW[0, i].Value.ToString().Equals("True"))
                    {
                        string classId = DAT_GRI_VIW[3, i].Value.ToString();
                        string staffId1 = DAT_GRI_VIW[12, i].Value != null ? DAT_GRI_VIW[12, i].Value.ToString() : "";
                        string staffId2 = DAT_GRI_VIW[13, i].Value != null ? DAT_GRI_VIW[13, i].Value.ToString() : "";
                        string staffId3 = DAT_GRI_VIW[14, i].Value != null ? DAT_GRI_VIW[14, i].Value.ToString() : "";
                        string staffId4 = DAT_GRI_VIW[15, i].Value != null ? DAT_GRI_VIW[15, i].Value.ToString() : "";
                        string staffId5 = DAT_GRI_VIW[16, i].Value != null ? DAT_GRI_VIW[16, i].Value.ToString() : "";
                        string staffId6 = DAT_GRI_VIW[17, i].Value != null ? DAT_GRI_VIW[17, i].Value.ToString() : "";

                        if (staffId1 == "" && staffId2 == "" && staffId1 == "" && staffId1 == "" && staffId1 == "" && staffId1 == "")
                        {
                            continue;
                        }
                        string number = DAT_GRI_VIW[5, i].Value != null ? DAT_GRI_VIW[5, i].Value.ToString() : "";

                        int ClassId = int.Parse(classId);
                        string MOD = "E";
                        var cpClassStaff = (from cs in db.CpClassStaffs where cs.ClassId == ClassId && cs.TanninId == tannin.Id select cs).FirstOrDefault();

                        if (cpClassStaff == null)
                        {
                            cpClassStaff = new CpClassStaff();
                            MOD = "A";
                        }
                        cpClassStaff.ClassId = int.Parse(classId);
                        //cpClassStaff.TanninId = D_INX_TAN_REC;
                        cpClassStaff.TanninId = tannin.Id;
                        if (staffId1 != "")
                        {
                            cpClassStaff.StaffId1 = int.Parse(staffId1);
                        }
                        if (staffId2 != "")
                        {
                            cpClassStaff.StaffId2 = int.Parse(staffId2);
                        }
                        if (staffId3 != "")
                        {
                            cpClassStaff.StaffId3 = int.Parse(staffId3);
                        }
                        if (staffId4 != "")
                        {
                            cpClassStaff.StaffId4 = int.Parse(staffId4);
                        }
                        if (staffId5 != "")
                        {
                            cpClassStaff.StaffId5 = int.Parse(staffId5);
                        }
                        if (staffId6 != "")
                        {
                            cpClassStaff.StaffId6 = int.Parse(staffId6);
                        }

                        if (number != "")
                        {
                            cpClassStaff.NumberOfStaff = int.Parse(number);
                        }

                        if (MOD == "A")
                        {
                            db.CpClassStaffs.Add(cpClassStaff);
                        }
                        countSave++;
                    }

                }

                if (countSave == 0)
                {
                    MessageBox.Show("Please select staff");
                }
                else
                {
                    db.SaveChanges();

                    btn_Save.Enabled = false;
                    MessageBox.Show("Save successfull");
                }
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FrmTanninList tannin_list = new FrmTanninList();
            tannin_list.Show();
            this.Close();
        }

        private void DAT_GRI_VIW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool validate()
        {
            bool validate = true;

            if (isNullString(txt_Code.Text))
            {
                validate = false;
                txt_Code.BackColor = System.Drawing.Color.Red;
            }

            if (isNullString(txt_Name.Text))
            {
                validate = false;
                txt_Name.BackColor = System.Drawing.Color.Red;
            }

            if (D_MOD == "A")
            {
                var checkTannin = (from t in db.CpTannins where t.Code == txt_Code.Text select t).FirstOrDefault();
                if (checkTannin != null)
                {
                    validate = false;
                    txt_Code.BackColor = System.Drawing.Color.Red;
                }
            }
            return validate;
        }

        private static bool isNullString(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        private void cb_Term_SelectedValueChanged(object sender, EventArgs e)
        {
            var year = cb_Term.SelectedValue;
            txt_Name.Text = year.ToString() + " 年度　担任";
        }

        private void txt_Code_Leave(object sender, EventArgs e)
        {
            if (D_MOD == "A")
            {
                var checkTannin = (from t in db.CpTannins where t.Code == txt_Code.Text select t).FirstOrDefault();
                if (checkTannin != null)
                {
                    MessageBox.Show("Code exist");
                }

                txt_Code.Text = makeCodeParam(txt_Code.Text.Trim());
            }
          
        }

        private void FrmTannin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void cbb_Schools_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    KeyValuePair<int,string> school_selected =  (KeyValuePair<int, string>)cbb_Schools.SelectedItem;

            //    VariableGlobal.school_id = school_selected.Key;
            //    VariableGlobal.school_name = school_selected.Value;
         
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
            
        }

        private void FrmTannin_Load(object sender, EventArgs e)
        {
            load_combobox_school();
            cbb_Schools.SelectedValue = D_SCHOOL_ID;

            cbb_Schools.Enabled = false;
        }
        string makeCodeParam(string code)
        {
            while (code.Length < 5)
            {
                code = "0" + code;
            }
            return code;
        }
    }
}
