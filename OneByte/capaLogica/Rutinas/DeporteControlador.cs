using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte.capaLogica.Rutinas
{
    internal class DeporteControlador
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";

        private List<Deporte> Deportes;
        ConexionBD connection = new ConexionBD();

        public DeporteControlador()
        {
            this.Deportes = new List<Deporte>();
        }
        public void bdcargarDeporte()
        {

            MySqlDataReader reader = connection.MakeQuery("SELECT * from DEPORTE");
            this.Deportes.Clear();

            while (reader.Read())
            {
                string idDeporte = Convert.ToString(reader["IDDEPORTE"]);
                if (this.Deportes.Any(c => c.IdDeporte == idDeporte))
                {
                    continue;
                }

                this.Deportes.Add(new Deporte(
                        Convert.ToString(reader["IDDEPORTE"]),
                        Convert.ToString(reader["NOMBRE"])
                        )
                    );
            }

            connection.closeCon();
        }

        public void addDeporte(string id_deporte, string nombre)
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO DEPORTE (IDDEPORTE, NOMBRE)
                                     VALUES (@id_deporte, @nombre)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_deporte", id_deporte);
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se agregó el deporte.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el deporte: " + ex.Message);
                }
            }
        }
        public List<Deporte> getDeporte()
        {
            return this.Deportes;
        }

        public Deporte findDeporte(string IDDEPORTE)
        {
            return this.Deportes.Find(x => x.IdDeporte.Contains(IDDEPORTE));
        }

        public bool RegistrarDeporte(Deporte deporte)
        {
            if (Deportes.Any(c => c.IdDeporte == deporte.IdDeporte))
            {
                MessageBox.Show("Este deporte ya existe.");
                return false;
            }

            addDeporte(
                deporte.IdDeporte,
                deporte.nom
            );

            return true;
        }
    }
}
