using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte.capaLogica.Rutinas
{
    internal class RutinaControlador
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        private List<Rutina> Rutinas;

        public RutinaControlador()
        {
            this.Rutinas = new List<Rutina>();
        }

        public void bdcargarRutinas()
        {
            ConexionBD connection = new ConexionBD();
            MySqlDataReader reader = connection.MakeQuery("SELECT * from RUTINA");
            while (reader.Read())
            {
                string tipo_rutina = Convert.ToString(reader["TIPORUTINA"]);
                if (this.Rutinas.Any(c => c.tiporutina == tipo_rutina))
                {
                    // Cliente ya existe, omitir
                    continue;
                }

                this.Rutinas.Add(new Rutina(
                    Convert.ToString(reader["TIPORUTINA"]),
                    Convert.ToString(reader["NOMBRE"])
                    )
                );
                connection.closeCon();
            }
        }
    }
}
