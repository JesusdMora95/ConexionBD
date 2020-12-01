using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;

namespace ConexionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Coneccion()
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\ConexionBD\\ConexionBD\\Database1.mdf;Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            Mensaje(connection);
        }

        public void Mensaje(SqlConnection connection)
        {
            try
            {
                connection.Open();
                MessageBox.Show(" Conectado ");
            }
            catch (Exception e)
            {
                MessageBox.Show(" Error al conectar " + e.Message);
                throw;
            }
            finally
            {
                connection.Close();
                MessageBox.Show(" Desconectado ");

            }

        }

        private void Conectar_Click_1(object sender, EventArgs e)
        {
            Coneccion();
        }
    }
}
