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
        public static int SizeTable = 7;// Table size
        public static bool ColoredNumber = true; //Painted even numbers
		public static int ControlCount = 0;// Control finish click
		public static int SecondCount = 0;// Timer Second
		public static int MinuteCount = 0;// Timer Minute
	}
}
