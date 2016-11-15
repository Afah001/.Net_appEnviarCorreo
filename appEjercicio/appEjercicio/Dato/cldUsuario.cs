using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appEjercicio.Entidad;
using System.Data;
namespace appEjercicio.Dato
{
    class cldUsuario
    {
        cldAdministracion objcldAdministracion = new cldAdministracion();
        List<cleUsuario> listaUsuarios;
        DataTable tableUsuario;
        public int mtdDRegistrar(cleUsuario objcleUsuario)
        {
            string consulta = "INSERT INTO Usuario(documento,nombre,apellido,email,clave)VALUES('" + objcleUsuario.documento + "','" + objcleUsuario.nombre + "','" + objcleUsuario.apellido + "','" + objcleUsuario.email + "','" + objcleUsuario.clave+ "')";
            int n = objcldAdministracion.mtdModificar(consulta);

            return n;

        }

        public List<cleUsuario> mtdDConsultar(cleUsuario objcleUsuario = null)
        {

            listaUsuarios = new List<cleUsuario>();
            string consulta = "";

            if (objcleUsuario == null)
            {
                consulta = "SELECT * FROM Usuario";

            }
            else if (objcleUsuario.documento!=null)
            {
                consulta = "SELECT * FROM Usuario where documento='"+ objcleUsuario.documento+"'";

            }



            tableUsuario = objcldAdministracion.mtdListas(consulta);  //datois a l dataTable
            foreach (DataRow fila in tableUsuario.Rows)  //itero dataTable
            {
                cleUsuario objUsuario = new cleUsuario();

              //  objUsuario.idUsuario = int.Parse(fila[0].ToString());
                objUsuario.documento = fila[1].ToString();
                objUsuario.nombre = fila[2].ToString();
                objUsuario.apellido = fila[3].ToString();
                objUsuario.email = fila[4].ToString();
                objUsuario.clave = fila[5].ToString();

                listaUsuarios.Add(objUsuario);

            }




            return listaUsuarios;

        }



    }
}
