using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OneByte.capaLogica.Cliente
{
    internal class ClienteControlador
    {
        private readonly string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        private List<cliente> Clientes;

        public ClienteControlador()
        {
            this.Clientes = new List<cliente>();
        }

        public void bdcargarClientes()
        {
            ConexionBD con = new ConexionBD();
            MySqlDataReader reader = con.MakeQuery("SELECT * from CLIENTE");

            // Limpia la lista Clientes para evitar duplicados al recargar
            this.Clientes.Clear();

            while (reader.Read())
            {
                // Manejar FECHA_NAC como DateTime?, permitiendo valores NULL
                DateTime? fechaNac = null;
                if (!reader.IsDBNull(reader.GetOrdinal("fecha")))
                {
                    fechaNac = reader.GetDateTime(reader.GetOrdinal("fecha"));
                }

                // Evitar duplicados comprobando si el cliente ya está en la lista antes de agregarlo
                string numDoc = Convert.ToString(reader["numDoc"]);
                if (this.Clientes.Any(c => c.num_doc == numDoc))
                {
                    // Cliente ya existe, omitir
                    continue;
                }

                this.Clientes.Add(new cliente(
                    Convert.ToString(reader["idCliente"]),
                    Convert.ToString(reader["tipoDoc"]),
                    Convert.ToString(reader["numDoc"]),
                    Convert.ToString(reader["primerNom"]),
                    Convert.ToString(reader["primerApe"]),
                    Convert.ToString(reader["segundoApe"]),
                    Convert.ToString(reader["Direccion"]),
                    Convert.ToInt32(reader["numCalle"]),
                    fechaNac,
                    Convert.ToString(reader["Departamento"]),
                    Convert.ToString(reader["estPago"]),
                    Convert.ToString(reader["Deporte"]),
                    Convert.ToString(reader["Contraseña"])
                    )
                );
            }

            con.closeCon();
        }

        public void addCliente(string idCliente, string tipoDoc, string numDoc,string primerNom, string segundoNom, string primerApe, string segundoApe, string Direccion, int numCalle, string Departamento, DateTime? Fecha, string estPago, string Deporte, string Contraseña)
        {
            // Verificar si el cliente ya está en la lista para evitar duplicación
            if (this.Clientes.Any(c => c.num_doc == numDoc))
            {
                MessageBox.Show("El cliente ya fue agregado.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO CLIENTE (idCliente, tipoDoc, numDoc, primerNom, segundoNom, primerApe, segundoApe, Direccion, numCalle, Departamento, Fecha, estPago, Deporte, Contraseña)
                             VALUES (@idCliente, @tipoDoc, @numDoc, @primerNom, @segundoNom, @primerApe, @segundoApe, @Direccion, @numCalle, @Departamento, @Fecha, @estPago, @Deporte, @Contraseña)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@tipoDoc", tipoDoc);
                        cmd.Parameters.AddWithValue("@numDoc", numDoc);
                        cmd.Parameters.AddWithValue("@primerNom", primerNom);
                        cmd.Parameters.AddWithValue("@segundoNom", segundoNom);
                        cmd.Parameters.AddWithValue("@primerApe", primerApe);
                        cmd.Parameters.AddWithValue("@segundoApe", segundoApe);
                        cmd.Parameters.AddWithValue("@Direccion", Direccion);
                        cmd.Parameters.AddWithValue("@numCalle", numCalle);
                        cmd.Parameters.AddWithValue("@Departamento", Departamento);
                        cmd.Parameters.AddWithValue("@Fecha", Fecha?.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@estPago", estPago);
                        cmd.Parameters.AddWithValue("@Deporte", Deporte);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente agregado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                }
            }
        }

        public List<cliente> getClientes()
        {
            return this.Clientes;
        }

        public cliente findCliente(string numDoc)
        {
            return this.Clientes.Find(x => x.num_doc.Contains(numDoc));
        }

        public bool RegistrarCliente(cliente cliente)
        {
            if (Clientes.Any(c => c.num_doc == cliente.num_doc))
            {
                MessageBox.Show("El cliente ya existe en la base de datos.");
                return false;
            }

            addCliente(
                cliente.idCliente,
                cliente.tipo_doc,
                cliente.num_doc,
                cliente.primer_nom,
                cliente.segundo_nom,
                cliente.primer_ape,
                cliente.segundo_ape,
                cliente.direccion,
                cliente.calle,
                cliente.departamento,
                cliente.fecha,
                cliente.est_pago,
                cliente.deporte,
                cliente.contraseña


            );

            return true;
        }
    }
}
 