using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoEmail;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using appEjercicio.Entidad;
using appEjercicio.Logica;
using appEjercicio.Dato;


namespace appEjercicio.Vista
{
    public partial class frmEnvioCorreo : Form
    {
        public frmEnvioCorreo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                MailMessage email = new MailMessage();

                
                email.To.Add(new MailAddress(txtIngresarEmail.Text));  //para
                email.From = new MailAddress("anderson.alarcon.afa@hotmail.com", "Anderson Alarcon"); //de
                email.Subject="RECUPERACION DE CLAVE"; //titulo

               string clave= mtdRecuperacionClave();

               email.Body = "Esta es tu clave"+clave; //cuerpo

                SmtpClient cliente = new SmtpClient("smtp.live.com",587);  //protocolo simple de transferencia de correo
                
                using(cliente){
                    cliente.Credentials = new System.Net.NetworkCredential("anderson.alarcon.afa@hotmail.com","anderson1057603126");
                    cliente.EnableSsl = true;
                    cliente.Send(email);  //envio
                }

                /* Si deseamos Adjuntar algún archivo*/
                //    mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));


                MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
                   
        }
        cllUsuario usuarioConsulta = new cllUsuario();
        
        List<cleUsuario>listaUsuarios;

        public string mtdRecuperacionClave()
        {

            string clave = "";
            cleUsuario usuario = new cleUsuario();
            usuario.documento = txtIngreseDocumento.Text;

            listaUsuarios = usuarioConsulta.mtdlConsultar(usuario);

            foreach (cleUsuario u in listaUsuarios)
            {
                clave = u.clave;
            }

            return clave;

        }

        private void txtIngreseDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
