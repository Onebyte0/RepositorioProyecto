using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace OneByte.capaLogica
{
    internal class conexionBD
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        internal MySqlConnection Connection;
        private MySqlConnection con;

        public conexionBD()
        {
            con = new MySqlConnection(connectionString);
        }
        
        // Método para abrir la conexión
        public bool AbrirConexion()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    Console.WriteLine("Conexión abierta correctamente.");
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    Console.WriteLine("Conexión cerrada correctamente.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
