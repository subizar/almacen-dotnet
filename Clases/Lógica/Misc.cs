using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas.Clases.Lógica
{
    internal class Misc
    {
        public static string ContraseñaAleatoria()
        {
            Random r = new Random();
            string contraseña = "";
            int num, num2;
            string[] letras = {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
            "u", "v", "w", "x", "y", "z"
            };
            for (int i = 0; i < 10; i++)
            {
                num = r.Next(0, 26);
                num2 = r.Next(0, 3);

                switch (num2)
                {
                    case 0:
                        contraseña = contraseña + letras[num];
                        break;
                    case 1:
                        contraseña = contraseña + letras[num].ToUpper();
                        break;
                    case 2:
                        contraseña = contraseña + num;
                        break;
                }
            }
            return contraseña;
        }
    



    public static void Mandar_Mail(string nombre)
        {
            // Configura los detalles del correo
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;

            string emailFrom = "practicasprofprueba@gmail.com"; // Cambia esto por tu email de Gmail
            string password = "ieoq pfem zqqx zntn"; // Usa la contraseña de aplicación aquí
            string emailTo = AdministracionUsuarios.BuscarMail(nombre);
            string subject = "Asunto del correo";
            string newpass = ContraseñaAleatoria();            
            string body = "<h1>Hola!</h1><p>Esta es tu nueva contraseña <b>" + newpass + "</b>.</p>";

            try
            {
                AdministracionUsuarios.CambiarContraseñaMail(newpass,nombre);
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true; // Importante para usar HTML
                    mail.Priority = MailPriority.High;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Correo enviado.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

    
