using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableShurle
{

    static class Program
    {
    
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainForm());
        }

    }
    static class Data
    {
        public static int SizeTable = 12;
        //public static bool StartOrNot = false;
        public static int ControlCount = 0;
    }
}
