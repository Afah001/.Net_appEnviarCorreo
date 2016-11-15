using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
namespace appEjercicio.Dato
{
    class cldAdministracion
    {

        SqlConnection conexion;

        public cldAdministracion()
        {
            // conexion  a la db
            conexion = new SqlConnection("Data Source=CAPACITACION_03\\SQLEXPRESS;Initial Catalog=bdUsuario;Integrated Security=True");

            // metodo para desconectado select 
        }

            public DataTable mtdListas( String sql)
        {
            SqlDataAdapter adapatador = new SqlDataAdapter(sql,conexion);


            // conjunto de datos 

            DataTable tblDatos = new DataTable();
            // pasar los datos 
            adapatador.Fill(tblDatos);


            // cerrar conexion
            conexion.Close();
            return tblDatos;
           
        }

        // metodo para conectar  Insert update delete 
        public int mtdModificar(string sql)
        {
            conexion.Open();
            SqlCommand cmdDatos = new SqlCommand(sql, conexion);


            // valida  la cantidad de registros afectados 
            int reg = cmdDatos.ExecuteNonQuery();
            conexion.Close();
            
            return reg;
        }

    }
}
