using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos_
{
    /// <summary>
    /// sE CREA CLASE PARA ACCCEDER A LA CONEXION A LA BASE DE DATOS
    /// </summary>
    public  class DataBase
    {
       
        private MySqlConnection connection;
        /// <summary>
        /// SE ESTABLECE LA RUTA DE CONEXION
        /// </summary>
        private string connectionString = "server=127.0.0.1;port=3306;database=reservasantioquia;uid=root;pwd= ";

        public DataBase()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
