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
    public partial class FrmTanninList : Form
    {
        private Int32 D_INX_TAN = 0;
        private Int32 D_INX_TAN_MAX = 0;

        chapyEntities db = new chapyEntities();

        public FrmTanninList()
        {
            InitializeComponent();
            loadTannin();
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                FrmTannin mas_ins = new FrmTannin(D_INX_TAN_MAX + 1, "A");
                mas_ins.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (D_INX_TAN > 0)
            {
                try
                {
                    this.Hide();
                    FrmTannin mas_ins = new FrmTannin(D_INX_TAN, "E");
                    mas_ins.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose a tannin");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (D_INX_TAN > 0)
            {
                var classStaff = from sc in db.CpClassStaffs where sc.TanninId == D_INX_TAN select sc;

                if (classStaff.Any())
                {

                    foreach (var cs in classStaff)
                    {
                        db.CpClassStaffs.Remove(cs);
                    }
                    db.SaveChanges();
                }

                var tannin = (from t in db.CpTannins where t.Id == D_INX_TAN select t).SingleOrDefault();
                if (tannin != null)
                {
                    db.CpTannins.Remove(tannin);
                    db.SaveChanges();

                    MessageBox.Show("Delete success");
                    loadTannin();
                }
            }
            else
            {
                MessageBox.Show("please choose a tannin");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            FrmMaintain mainTain = new FrmMaintain();
            mainTain.Show();
            this.Close();
        }

        private void DAT_GRI_VIW_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void DAT_GRI_VIW_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DAT_GRI_VIW_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void DAT_GRI_VIW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (DAT_GRI_VIW[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString() == "True")
                    {
                        D_INX_TAN = Convert.ToInt32(DAT_GRI_VIW[3, e.RowIndex].Value);
                        for (int i = 0; i < DAT_GRI_VIW.RowCount; i++)
                        {
                            if (i != e.RowIndex)
                            {
                                DAT_GRI_VIW[e.ColumnIndex, i].Value = false;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadTannin()
        {
            
            //get all tannin in db
            var tannins = (from t in db.CpTannins where t.SchoolId == VariableGlobal.school_id select t).ToArray();

            DAT_GRI_VIW.Rows.Clear();
            //insert min 15row in tannins de view cho dep
            if (tannins.Count() < 15)
            {
                DAT_GRI_VIW.RowCount = 15;
            }
            else
            {
                DAT_GRI_VIW.RowCount = tannins.Count();
            }

            //insert in to data gridview
            int i = 0;
            foreach (var item in tannins)
            {
                DAT_GRI_VIW[1, i].Value = item.Code.Trim();
                DAT_GRI_VIW[2, i].Value = item.Name.Trim();
                DAT_GRI_VIW[3, i].Value = item.Id;
                i++;
            }

            D_INX_TAN_MAX = i > 0 ? i - 1 : 0;
        }

        private void FrmTanninList_Load(object sender, EventArgs e)
        {

        }

    }
}
