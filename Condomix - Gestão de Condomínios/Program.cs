using System;
using System.Windows.Forms;

namespace Condomix___Gestão_de_Condomínios
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
   
        }
    }
}
