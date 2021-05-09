using MySql.Data.MySqlClient;
using Tarea9.Clases;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Tarea9
{
  
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument("C:/Users/alumno/Documents/archivoPlano.csv");
            SLWorksheetStatistics propiedades = sl.GetWorksheetStatistics();

            int ultimafila = propiedades.EndRowIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MySQL_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionDB = Cls_MySQL.conexion();
            
        }

        private void btn_oracle_Click(object sender, EventArgs e)
        {
            OracleConnection conexionBD = Cls_Oracle.conexion2();
        }
    }
}
