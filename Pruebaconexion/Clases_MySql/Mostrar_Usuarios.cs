using System;
//using System.Collections.Generic;
using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pruebaconexion.Clases_MySql
{
    class Mostrar_Usuarios
    {
        public void mostrarUsuarios(DataGridView tablaUsuarios)
        {
            try
            {
                Conexion objetoConexion = new Conexion();
                String query = "SELECT * FROM USUARIOS";
                tablaUsuarios.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuarios.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión" + ex.ToString());
            }
        }

        public void guardarUsuarios(TextBox username, TextBox account, TextBox password, TextBox validar_admin)
        {
            try
            {
                Conexion objetoConexion = new Conexion();
                String query = "INSERT INTO USUARIOS (username, account, password, validar_admin)" + "VALUES('" + username.Text + "','" + account.Text + "','" + password.Text + "','" + validar_admin.Text + "');";
                
                MySqlCommand command = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se guardaron los registros");
               /* while (reader.Read())
                {

                }*/
                
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión" + ex.ToString());
            }
        }

        public void seleccionarUsuarios(DataGridView tablaUsuarios, TextBox id_usuario, TextBox username, TextBox account,TextBox password, TextBox validar_admin)
        {
            try
            {
                id_usuario.Text = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                username.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                account.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                password.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                validar_admin.Text = tablaUsuarios.CurrentRow.Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión" + ex.ToString());
            }
        }

        public void modificarUsuarios(TextBox id_usuario, TextBox username, TextBox account, TextBox password, TextBox validar_admin)
        {
            try
            {
                Conexion objetoConexion = new Conexion();
                String query = "UPDATE USUARIOS SET username= '" + username.Text + "', account= '" + account.Text + "', password= '" + password.Text + "', validar_admin= '" + validar_admin.Text + "' WHERE id_usuario= '" + id_usuario.Text + "';";
                MySqlCommand command = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se Modificaron los registros");
                /*while (reader.Read())
                {

                }*/

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión" + ex.ToString());
            }
        }

        public void eliminarUsuarios(TextBox id_usuario, TextBox username, TextBox account, TextBox password, TextBox validar_admin)
        {
            try
            {
                Conexion objetoConexion = new Conexion();
                String query = "DELETE FROM USUARIOS WHERE id_usuario= '" + id_usuario.Text + "';";
                MySqlCommand command = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se Elimino el registro");
               /* while (reader.Read())
                {

                }*/

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión" + ex.ToString());
            }
        }
    }
}
//conexion objetoConexion = new conexion();
//String query = "SELECT * FROM USUARIOS";
//tablaUsuarios.DataSource = null;
//MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.connectionstring());
//DataTable dt = new DataTable();
//adapter.Fill(dt);
//tablaUsuarios.DataSource = dt;
//objetoConexion.cerrarConexion();