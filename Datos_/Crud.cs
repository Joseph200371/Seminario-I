using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos_
{
    public class Crud
    {
        private DataBase db = new DataBase();
        private string connectionString = "server=127.0.0.1;port=3306;database=reservasantioquia;uid=root;pwd= ";
        /// <summary>
        /// Se crea el metodo obternerReservas,se inicia la conexion a la base de datos
        /// guardada los valos del tipo reserva en una lista
        /// </summary>
        /// <returns>retorna un valor del tipo reserva</returns>
        public List<Reserva> ObtenerReservas()
        {
            var alumnos = new List<Reserva>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM Reservas", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alumnos.Add(new Reserva
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                Email = reader.GetString("Email"),
                                Telefono = reader.GetString("Telefono"),
                                Tipodeevento = reader.GetString("Tipo_De_Evento"),
                                Fecha = reader.GetString("Fecha"),
                                Hora = reader.GetString("Hora")

                            }
                            ); 
                        }
                    }
                }
            }
            return alumnos;
        }
        /// <summary>
        /// crea una reserva
        /// </summary>
        /// <param name="reserva"></param>
        public void CreateData(Reserva reserva)
        //string Nombre, string Apellido,string Email, string Telefono, string Tipo_De_Evento, string Fecha,string Hora
        {
            string query = "INSERT INTO Reservas (Nombre,Apellido,Email,Telefono,Tipo_De_Evento,Fecha,Hora) " +
                "VALUES (@nombre,@apellido,@email,@telefono,@tipo_de_evento,@fecha,@hora)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nombre", reserva.Nombre);
            cmd.Parameters.AddWithValue("@apellido", reserva.Apellido);
            cmd.Parameters.AddWithValue("@email", reserva.Email);
            cmd.Parameters.AddWithValue("@telefono", reserva.Telefono);
            cmd.Parameters.AddWithValue("@tipo_de_evento", reserva.Tipodeevento);
            cmd.Parameters.AddWithValue("@fecha", reserva.Fecha);
            cmd.Parameters.AddWithValue("@hora", reserva.Hora);
            db.GetConnection().Open();
            cmd.ExecuteNonQuery();
            db.GetConnection().Close();
        }
        /// <summary>
        /// Actualiza valores en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reserva"></param>
        public void UpdateData(int id, Reserva reserva)
          //  string Nombre, string Apellido, string Email, string Telefono, string Tipo_De_Evento, string Fecha, string Hora)
        {
            string query = "UPDATE Reservas SET Nombre = @nombre, Apellido = @apellido, Email = @email,Telefono=@telefono,Tipo_De_Evento=@tipo_de_evento,Fecha=@fecha,Hora=@hora WHERE Id = @id";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", reserva.Nombre);
            cmd.Parameters.AddWithValue("@apellido", reserva.Apellido);
            cmd.Parameters.AddWithValue("@email", reserva.Email);
            cmd.Parameters.AddWithValue("@telefono", reserva.Telefono);
            cmd.Parameters.AddWithValue("@tipo_de_evento", reserva.Tipodeevento);
            cmd.Parameters.AddWithValue("@fecha", reserva.Fecha);
            cmd.Parameters.AddWithValue("@hora", reserva.Hora);
            db.GetConnection().Open();
            cmd.ExecuteNonQuery();
            db.GetConnection().Close();
        }
        /// <summary>
        /// Elimina una reserva mediante su Id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteData(int id)
        {
            string query = "DELETE FROM Reservas WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            db.GetConnection().Open();
            cmd.ExecuteNonQuery();
            db.GetConnection().Close();
        }
    }
}
