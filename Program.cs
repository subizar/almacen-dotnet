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
                if (State.user_role != null)
                {
                    switch (State.user_role)
                    {
                        case "Admin": Application.Run(new Formularios.Admin.Menu()); break;
                        case "Usuario": Application.Run(new Formularios.Usuario.Menu()); break;
                        default: Application.Run(new Formularios.Usuario.Menu()); break;
                    }
                }
            }
            
        }

        public static void logout()
        {
            Application.Restart();
            Form login = new Formularios.LoginForm();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                if (State.user_role != null)
                {
                    switch (State.user_role)
                    {
                        case "Admin": Application.Run(new Formularios.Admin.Menu()); break;
                        case "Usuario": Application.Run(new Formularios.Usuario.Menu()); break;
                        default: Application.Run(new Formularios.Usuario.Menu()); break;
                    }
                }
            }
        }
        
    }
}
