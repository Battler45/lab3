using System;
using System.Windows.Forms;

namespace lab3_CV
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
            ///it's some shit code there, because i'm too laz to write another main form
            #region Shitcode
            var form1 = new Task1();
            var form2 = new Task2();
            form1.Show();
            form2.Show();
            #endregion Shitcode
            Application.Run();
        }
    }
}
