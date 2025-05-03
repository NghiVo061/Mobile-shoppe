using System.Windows.Forms;
using mobileshope;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Application.Run(new AdminForm());

           // Application.Run(new EmployeeForm());
            Application.Run(new IntroduceForm());

        }
    }
} 