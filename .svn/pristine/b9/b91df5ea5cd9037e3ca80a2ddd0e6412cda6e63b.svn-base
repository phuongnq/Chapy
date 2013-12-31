using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chapy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            chapyEntities db = new chapyEntities();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmSchoolSelect())
            var List_School = from s in db.CpSchools select s;

            if (List_School.Any())
            {
                Application.Run(new FrmSchoolSelect());
            }
            else
            {
                Application.Run(new FrmMain());
            }
            //Application.Run(new FrmHoliday());
            
        }
    }
}
