using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
//using Pruebaconexion.Clases_MySql;

namespace Pruebaconexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // Clases_MySql.Mostrar_Usuarios objetoUsuarios = new Clases_MySql.Mostrar_Usuarios();
            //objetoUsuarios.mostrarUsuarios(dataGVUS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases_MySql.Conexion objetoConexion = new Clases_MySql.Conexion();
            objetoConexion.establecerConexion();
           /* MessageBox.Show("La conexion ha sido exitosa");*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clases_MySql.Mostrar_Usuarios objetoUsuarios = new Clases_MySql.Mostrar_Usuarios();
            objetoUsuarios.mostrarUsuarios(dataGVUS);
            //try
            //{

            //    Conexion con = new Conexion();
            //    string mysql = "SELECT * FROM Usuarios;";


            //    MySqlConnection con2 = con.establecerConexion();

            //    MySqlCommand commnad = new MySqlCommand(mysql, con2);           

            //    MySqlDataAdapter db = new MySqlDataAdapter();
            //    db.SelectCommand = commnad;
            //    DataTable dtable = new DataTable();
            //    db.Fill(dtable);
            //    dataGVUS.DataSource = db;
            //}
            //catch(Exception ex)
            //{
            //   MessageBox.Show(ex.Message);            
            //}

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases_MySql.Mostrar_Usuarios objetoUsuarios = new Clases_MySql.Mostrar_Usuarios();
            objetoUsuarios.guardarUsuarios(txtUsuario,txtTcuenta,txtContra,txtValidar);
            objetoUsuarios.mostrarUsuarios(dataGVUS);
        }

        private void dataGVUS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases_MySql.Mostrar_Usuarios objetoUsuarios = new Clases_MySql.Mostrar_Usuarios();
            objetoUsuarios.seleccionarUsuarios(dataGVUS, txtId, txtUsuario, txtTcuenta, txtContra, txtValidar);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases_MySql.Mostrar_Usuarios objetoUsuarios = new Clases_MySql.Mostrar_Usuarios();
            objetoUsuarios.modificarUsuarios(txtId, txtUsuario, txtTcuenta, txtContra, txtValidar);
            objetoUsuarios.mostrarUsuarios(dataGVUS);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases_MySql.Mostrar_Usuarios objetoUsuarios = new Clases_MySql.Mostrar_Usuarios();
            objetoUsuarios.eliminarUsuarios(txtId, txtUsuario, txtTcuenta, txtContra, txtValidar);
            objetoUsuarios.mostrarUsuarios(dataGVUS);
        }
    }
}
