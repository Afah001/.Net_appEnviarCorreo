using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appEjercicio.Entidad;
using appEjercicio.Dato;

namespace appEjercicio.Vista
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }
        cldUsuario objcldUsuario = new cldUsuario();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cleUsuario objUsuario = new cleUsuario();
            objUsuario.documento = txtDocumento.Text;
            objUsuario.nombre = txtNombre.Text;
            objUsuario.apellido = txtApellido.Text;
            objUsuario.email = txtEmail.Text;
            objUsuario.clave = txtClave.Text;

            int n = objcldUsuario.mtdDRegistrar(objUsuario);



        }
    }
}
