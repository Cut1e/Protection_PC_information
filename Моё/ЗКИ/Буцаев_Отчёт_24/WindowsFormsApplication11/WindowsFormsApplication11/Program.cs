using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form6 form6 = new Form6();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            form6.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            form6.Close();
            form6.Dispose();
            Application.Run(new Form1());
        }
    }
}
