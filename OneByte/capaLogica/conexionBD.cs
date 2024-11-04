using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace OneByte.capaLogica
{

    class ConexionBD
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;"; 
        private MySqlConnection con; // Metodo para realizar la conexion con la BD

        public ConexionBD()
        {
            con = new MySqlConnection(connectionString);
        }
        public MySqlDataReader MakeQuery(string query)
        {
            MySqlDataReader reader = null;

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                // Manejo específico de excepciones de MySQL
                MessageBox.Show("La consulta falló: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otra excepción
                MessageBox.Show("Error: " + ex.Message);
            }
            MySqlCommand cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            return reader;
        }

        internal void closeCon()
        {
        }
        public bool User(string nroDocumento, string contraseña, string rol)
        {
            bool isValid = false;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM usuario WHERE numDoc=@nroDocumento AND contraseña=@contraseña AND rol=@rol";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nroDocumento", nroDocumento);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);  
                        cmd.Parameters.AddWithValue("@rol", rol);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Si existe un registro que coincide, el login es válido
                        isValid = (count > 0);
                    }
                }
            }
            finally { closeCon(); }

            return isValid;

        }

    }   
}

