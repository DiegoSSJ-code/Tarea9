using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9.Clases
{
    class Cls_Oracle
    {
        public static OracleConnection conexion2()
        {
            string servidor = "localhost";
            string bd = "db_progra1";
            string usuario = "system";
            string password = "Umg$19";

            string cadenaConexion = "Database=" + bd + "; Data Sourc=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                Console.WriteLine("Conectado");
                OracleConnection conexionBD = new OracleConnection(cadenaConexion);
                return conexionBD;
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
