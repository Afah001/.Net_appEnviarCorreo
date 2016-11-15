using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appEjercicio.Vista;
using appEjercicio.Logica;
using appEjercicio.Entidad;

namespace appEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmRegistroUsuario objfrmRegistroUsuario = new frmRegistroUsuario();
        private void lklRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //objfrmRegistroUsuario.MdiParent = this;
            objfrmRegistroUsuario.Show();
        }
        cllUsuario objcllUsuario = new cllUsuario();
        List<cleUsuario> listaUsuarios;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            listaUsuarios = objcllUsuario.mtdlConsultar();
            bool correcto = false;
          

            foreach (cleUsuario usuario in listaUsuarios)
            {
                if(txtUsuario.Text==usuario.documento && txtPassword.Text==usuario.clave){
                    correcto = true;       
                }  
            }

            if (correcto==true)
            {
                MessageBox.Show("Correcto si se encuentra registrado");
            }else{
                if (MessageBox.Show("¿El usuario no se encuentra en la bd desea registrarlo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    frmRegistroUsuario objfrmRegistroUsuario = new frmRegistroUsuario();
                   // objfrmRegistroUsuario.MdiParent = this;
                    objfrmRegistroUsuario.Show();
                }
                
            }

        }
        frmEnvioCorreo objfrmEnvioCorreo = new frmEnvioCorreo();
        private void lklOlvideClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // objfrmEnvioCorreo.MdiParent = this;
            objfrmEnvioCorreo.Show();
        }
    }
}
