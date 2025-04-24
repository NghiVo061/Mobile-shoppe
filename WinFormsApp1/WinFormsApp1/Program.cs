<<<<<<< HEAD
using mobileshope;
=======
using System.Windows.Forms;
>>>>>>> 017b59c03db22590d9c51d58a74f9df06a0c8092

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
<<<<<<< HEAD
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Kh?i ??ng ?ng d?ng v?i AdminForm
            Application.Run(new AdminForm());
=======
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Employee());
>>>>>>> 017b59c03db22590d9c51d58a74f9df06a0c8092
        }
    }
}