using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace OneByte.capaLogica.Cliente
{
    internal class ClienteControlador
    {
        private string connectionString = "server=localhost;database=onebyte;user=;password="; 

        public bool AgregarCliente(cliente cliente)
        {
            string query = "INSERT INTO Cliente (idCliente, tipoDoc, numDoc, primerNom, segundoNom, primerApe, segundoApe, direccion, numCalle, departamento, fecha, estPago, contrase�a) " +
                           "VALUES (@idCliente, @tipoDoc, @numDoc, @primerNom, @segundoNom, @primerApe, @segundoApe, @direccion, @numCalle, @departamento, @fecha, @estPago @contrase�a)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("@tipoDoc", cliente.TipoDoc);
                command.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                command.Parameters.AddWithValue("@primerNom", cliente.PrimerNom);
                command.Parameters.AddWithValue("@segundoNom", cliente.SegundoNom);
                command.Parameters.AddWithValue("@primerApe", cliente.PrimerApe);
                command.Parameters.AddWithValue("@segundoApe", cliente.SegundoApe);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@numCalle", cliente.NumCalle);
                command.Parameters.AddWithValue("@departamento", cliente.Departamento);
                command.Parameters.AddWithValue("@fecha", cliente.Fecha);
                command.Parameters.AddWithValue("@estPago", cliente.EstPago);
                command.Parameters.AddWithValue("@contrase�a", cliente.contrase�a);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool IniciarSesion(string usuario, string contrase�a)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Cliente WHERE documento = @documento AND contrase�a = @contrase�a";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@documento", usuario);
                    command.Parameters.AddWithValue("@contrase�a", contrase�a);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al iniciar sesi�n: " + ex.Message); // Utiliza Console.WriteLine en lugar de MessageBox en c�digo de l�gica
                return false;
            }
        }
    }
}
