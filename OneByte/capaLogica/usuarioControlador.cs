using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte.capaLogica
{
    internal class usuarioControlador
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        private List<usuario> usuarios;
        public usuarioControlador()
        {
            this.usuarios = new List<usuario>();
        }
        public void bdcargarUsuarios()
        {
            ConexionBD con = new ConexionBD();
            MySqlDataReader reader = con.MakeQuery("SELECT * from USUARIO");

            // Limpia la lista Usuarios para evitar duplicados al recargar
            this.usuarios.Clear();

            while (reader.Read())
            {
                // Evitar duplicados comprobando si el usuario ya está en la lista antes de agregarlo
                string nroDocumento = Convert.ToString(reader["NRO_DOCUMENTO"]);
                if (this.usuarios.Any(c => c.nro_documento == nroDocumento))
                {
                    // usuario ya existe, omitir
                    continue;
                }

                this.addUsuario(
                    Convert.ToString(reader["NRO_DOCUMENTO"]),
                    Convert.ToString(reader["CONTRASEÑA"]),
                    Convert.ToString(reader["ROL"])
                );
            }

            con.closeCon();
        }

        public void addUsuario(string nroDocumento, string contraseña, string rol)
        {
            // Verificar si el cliente ya está en la lista para evitar duplicación
            if (this.usuarios.Any(c => c.nro_documento == nroDocumento))
            {
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM USUARIO WHERE NRO_DOCUMENTO = @NroDocumento";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@NroDocumento", nroDocumento);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("El usuario ya ha sido agregado a la base de datos.");
                            return;
                        }
                    }

                    string query = @"INSERT INTO USUARIO (NRO_DOCUMENTO, CONTRASENIA, ROL)
                             VALUES (@NroDocumento, @Contrasenia, @Rol)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NroDocumento", nroDocumento);
                        cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        cmd.ExecuteNonQuery();

                        
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public List<usuario> getUsuarios()
        {
            return this.usuarios;
        }

        public usuario findUsuario(string NRO_DOCUMENTO)
        {
            return this.usuarios.Find(x => x.nro_documento.Contains(NRO_DOCUMENTO));
        }

        public bool RegistrarUsuario(usuario usuario)
        {
            if (usuarios.Any(c => c.nro_documento == usuario.nro_documento))
            {
                MessageBox.Show("El usuario ya existe.");
                return false;
            }

            addUsuario(
                usuario.nro_documento,
                usuario.contraseña,
                usuario.rol
            );

            return true;
        }
    }
}
