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
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                // Configurar manejo global de excepciones
                Application.ThreadException += Application_ThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico en la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Error en la aplicación: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"Error crítico: {((Exception)e.ExceptionObject).Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void logout()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
