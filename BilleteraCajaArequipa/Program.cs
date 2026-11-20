using System;
using System.Windows.Forms;
using BilleteraCajaArequipa.Formularios;

namespace BilleteraCajaArequipa
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
