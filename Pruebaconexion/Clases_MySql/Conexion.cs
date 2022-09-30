using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pruebaconexion.Clases_MySql
{

    internal class Conexion
    {
      MySqlConnection conex = new MySqlConnection();

        static string servidor = "127.0.0.1";
        static string db = "Sistema";
        static string usuario = "root";
        static string contra = "";
        static string puerto = "3306";

        string cadenaConex = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + contra + ";" + "database=" + db + ";";

        
        public MySqlConnection establecerConexion()
        {
            try
            {
              conex.ConnectionString = cadenaConex;
              conex.Open();
             /* MessageBox.Show("Conexion Exitosa");*/
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión"+ ex.ToString());
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
