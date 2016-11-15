using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appEjercicio.Dato;
using appEjercicio.Entidad;
namespace appEjercicio.Logica
{
    class cllUsuario
    {

        cldUsuario objcldUsuario = new cldUsuario();
        List<cleUsuario> listaUsuarios;
        public int mtdLRegistrar(cleUsuario usuario){

            int n = objcldUsuario.mtdDRegistrar(usuario);

            return n;
        }

        public List<cleUsuario> mtdlConsultar(cleUsuario objcleUsuario = null)
        {

            listaUsuarios = objcldUsuario.mtdDConsultar(objcleUsuario);
            return listaUsuarios;

        }

    }
}
