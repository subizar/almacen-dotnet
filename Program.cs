using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form login = new Formularios.LoginForm();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new Formularios.Usuario.PanelVentas());
            }
        }

        
    }
}
