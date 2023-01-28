using project.MainFormFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    internal static class Program
    {
        public static string AtmName = "ATM 0001";

        public static LoginForm loginForm;
        public static SignUpForm signUpForm;
        public static MainForm mainForm;
        public static AddForm addForm;
        public static TransferForm transferForm;
        public static HistoryForm historyForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            signUpForm = new SignUpForm();
            mainForm = new MainForm();
            Application.Run(loginForm = new LoginForm());
        }
    }
}
