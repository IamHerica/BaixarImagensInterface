using System;
using System.Windows.Forms;

namespace AppDownload
{
    static class Program
    {
        //Aqui é onde rola o startup do tela 
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Baixar());
        }
    }
}
