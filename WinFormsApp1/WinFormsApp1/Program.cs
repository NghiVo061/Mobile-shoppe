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
<<<<<<< HEAD

            // Kh?i ??ng ?ng d?ng v?i AdminForm
            Application.Run(new EmployeeForm());
            //Application.Run(new AdminForm());
=======
            Application.Run(new AdminForm());
>>>>>>> b15efc742110c9ed2387cef864d220433f5d5e02
        }
    }
} 