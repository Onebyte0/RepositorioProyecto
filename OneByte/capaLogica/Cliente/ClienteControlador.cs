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
                command.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                command.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                command.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                command.Parameters.AddWithValue("@primerNom", cliente.primerNom);
                command.Parameters.AddWithValue("@segundoNom", cliente.segundoNom);
                command.Parameters.AddWithValue("@primerApe", cliente.primerApe);
                command.Parameters.AddWithValue("@segundoApe", cliente.segundoApe);
                command.Parameters.AddWithValue("@direccion", cliente.direccion);
                command.Parameters.AddWithValue("@numCalle", cliente.numCalle);
                command.Parameters.AddWithValue("@departamento", cliente.departamento);
                command.Parameters.AddWithValue("@fecha", cliente.fecha);
                command.Parameters.AddWithValue("@estPago", cliente.estPago);
                command.Parameters.AddWithValue("@contrase�a", cliente.contrase�a);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

   

        public bool IniciarSesion(string documento, string contrase�a)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM cliente WHERE documento = @documento AND contrase�a = @contrase�a";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@documento", documento);
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
