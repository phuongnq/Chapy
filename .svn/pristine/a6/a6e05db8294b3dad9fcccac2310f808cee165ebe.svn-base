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
    public partial class Form1 : Form
    {

        chapyEntities db = new chapyEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = (from t in db.CpClasses select t).Count();
            MessageBox.Show(test.ToString());
        }
    }
}
