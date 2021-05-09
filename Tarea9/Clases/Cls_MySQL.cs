using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9.Clases
{
    class Cls_MySQL
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "db_progra";
            string usuario = "root";
            string password = "Umg$2019";

            string cadenaConexion = "Database=" + bd + "; Data Sourc=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                Console.WriteLine("Conectado");
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
