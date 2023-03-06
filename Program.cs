using AppWinFormCRUD.UI;
using System;
using System.Windows.Forms;

namespace AppWinFormCRUD
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
