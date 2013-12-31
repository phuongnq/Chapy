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
    public partial class Staffs : Form
    {
        chapyEntities db = new chapyEntities();
        public Staffs()
        {
            InitializeComponent();
        }

        /*Khai bao cac tham so get tu trang chinh*/
        string schoolId = null;
        string RowIndex = null;
        string ColumnIndex = null;
        /* tham so tra ve trang chih */
        string Name = null;
        string Id = null;
       
        /*---------------------------------------------------------------*/
        /*Nhan tham so noixuathang tu form chinh*/
        public string _setSchoolId
        {
            set { schoolId = value; }
        }
        public string _setRow
        {
            set { RowIndex = value; }
        }
        public string _setColumn
        {
            set { ColumnIndex = value; }
        }
        /*---------------------------------------------------------------*/

        /*---------------------------------------------------------------*/

        /* Khai báo 1 hàm delegate de truyen sang cac tham so sang form chinh*/
        public delegate void GetString(String id, String name, String row, String column);
        public GetString MyGetData;

        private void Staffs_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(schoolId);
           //int Id = 2;
            var staffs = (from t in db.CpStaffs
                          where t.SchoolId == Id
                          select new
                          {
                              Id = t.Id,
                              Name = t.Name,
                              Gender = t.Gender,
                              Birday = t.BirthDay
                          }).ToArray();

            dgv_ListStaff.DataSource = staffs;
        }

        private void dgv_ListStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                callBack();

            }
        }

        private void dgv_ListStaff_DoubleClick(object sender, EventArgs e)
        {
            callBack();
        }

        private void callBack()
        {
            Id = dgv_ListStaff.Rows[dgv_ListStaff.CurrentRow.Index].Cells[0].Value.ToString();
            Name = dgv_ListStaff.Rows[dgv_ListStaff.CurrentRow.Index].Cells[1].Value.ToString();

            if (MyGetData != null)
            {
                MyGetData(Id, Name, RowIndex, ColumnIndex);
            }
            this.Close();
        }


    }
}
