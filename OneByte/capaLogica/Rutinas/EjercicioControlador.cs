using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte.capaLogica.Rutinas
{
    class EjercicioControlador
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        private List<Ejercicio> Ejercicios;

        public EjercicioControlador()
        {
            this.Ejercicios = new List<Ejercicio>();
        }

        public void bdcargarEjercicio()
        {
            ConexionBD con = new ConexionBD();
            MySqlDataReader reader = con.MakeQuery("SELECT * from EJERCICIO");

            this.Ejercicios.Clear();

            while (reader.Read())
            {
                // Llamada al método addCliente con las fechas convertidas a DateTime?
                this.Ejercicios.Add(new Ejercicio(
                    Convert.ToString(reader["IDEJERCICIO"]),
                    Convert.ToString(reader["DESCRIPCION"]),
                    Convert.ToString(reader["NOMBREEJERCICIO"]),
                    Convert.ToString(reader["GRUPOMUSCULAR"])
                ));
            }

            con.closeCon();
        }
        public List<Ejercicio> getEjercicios()
        {
            return this.Ejercicios;
        }

        public void addEjercicio(string IDEJERCICIO, string DESCRIPCION, string NOMBREEJERCICIO, string GRUPOMUSCULAR)
        {
            if (this.Ejercicios.Any(c => c.id_ejercicio == IDEJERCICIO))
            {
                MessageBox.Show("El ejercicio ya ha sido agregado a la lista.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO EJERCICIO (IDEJERCICIO, DESCRIPCION, NOMBREEJERCICIO, GRUPOMUSCULAR)
                             VALUES (@IdEjercicio, @Descripcion, @Nombre, @grupoMuscular)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdEjercicio", IDEJERCICIO);
                        cmd.Parameters.AddWithValue("@Descripcion", DESCRIPCION);
                        cmd.Parameters.AddWithValue("@Nombre", NOMBREEJERCICIO);
                        cmd.Parameters.AddWithValue("@grupoMuscular", GRUPOMUSCULAR);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ejercicio agregado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el ejercicio: " + ex.Message);
                }
            }
        }

        public void removeEjercicio(Ejercicio ej)
        {
            this.Ejercicios.Remove(ej);
        }

        public Ejercicio findEjercicio(string IDEJERCICIO)
        {

            return this.Ejercicios.Find(x => x.id_ejercicio.Contains(IDEJERCICIO));
        }
    }
}
