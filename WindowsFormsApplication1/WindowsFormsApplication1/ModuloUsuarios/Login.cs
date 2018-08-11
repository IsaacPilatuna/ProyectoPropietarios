using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Login
    {

        
        GestiónModulos facade;
        
        Cuenta cuenta = new Cuenta();
        String mensaje;
        Usuario user = new Usuario();

        public Boolean validarCredenciales(String usuario, string pass){

            bool flag;
            SqlDataReader loguear;


            cuenta.Usuario = usuario.Trim();
            cuenta.Contraseña = pass.Trim();

            loguear = cuenta.obtenerDatos();

            if (loguear.Read() == true)
            {
                flag = true;
                iniciarSesion(usuario.Trim());
            }
            else
            {
                flag = false;
            }

            loguear.Close();

            return flag;
        }


        public void iniciarSesion(String user)
        {
          
            facade = new GestiónModulos(new FormMenu(user), user);
            

        }


        public String recuperarContraseña(string correo)
        {
            SqlDataReader obtener;
            
            
            obtener = user.obtenerDatos(correo);

            if (obtener.Read())
            {
                user.Nombre = obtener.GetString(1);
                user.Email = obtener.GetString(4);
                obtener.Close();
                mensaje = "Estimado " + user.Nombre + "\n, Recientemente has solicitado información de seguridad, " +
                    "por lo que se ha enviado sus credenciales a su correo electronico." + user.Email + "" +
                    "\n";
            }
            else
            {
                mensaje = "El usuario no existe";
            }

            return mensaje;
            
        }

        public void enviaEmail()
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("epn.help2018@gmail.com");
            correo.To.Add(user.Email);
            correo.Subject="RECUPERAR CONTRASEÑA";
            correo.Body = "Hola Estimado " + user.Nombre + ",\n" +
                "Recientemente ha solicitado recuperar sus credenciales, las cuales son: \n" +
                "Usuario :" + user.Email + "\n" +
                "Contraseña :" + user.Email + "";
            correo.Priority = MailPriority.Normal;

            //SMTP
            SmtpClient servidor = new SmtpClient();
            servidor.Credentials = new NetworkCredential("epn.help2018@gmail.com", "@admin123"); 

        }




       



    }
}
