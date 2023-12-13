using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheQuiz.BackEnd.Services;
using MatheQuiz.Forms;

namespace MatheQuiz
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainService a = new MainService();
            a.Ini();

            Application.Run();
        }
    }
}