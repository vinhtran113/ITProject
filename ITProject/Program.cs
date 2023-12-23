using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            Employee_Class em = new Employee_Class();
            
            if (lg.ShowDialog() == DialogResult.OK)
            {
                if (em.getEmjob(StaticVars_Class.emID) == "Employee")
                {
                    OverView overView = new OverView();
                    Application.Run(overView);
                }
                else
                {
                    Manage manage = new Manage();
                    Application.Run(manage);
                }
            }
            else
                Application.Exit();
        }
    }
}
