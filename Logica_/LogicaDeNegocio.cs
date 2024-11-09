using Datos_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica_
{
    public class LogicaDeNegocio
    {
        /// <summary>
        /// Se intancia la clase Crud para poder manegar sus metodos
        /// </summary>
        public Crud crud = new Crud();
        /// <summary>
        /// Se instancia una reservar para poder pasarla como parametros
        /// </summary>
        Reserva reserva = new Reserva();  
        
        /// <summary>
        /// este metodo posee una lista del tipo reserva 
        /// </summary>
        /// <returns>lista de valores en la base de datos</returns>
        public List<Reserva> ObtenerReserva()
        {
            return crud.ObtenerReservas();
        }

        /// <summary>
        /// este metodo agraga datos 
        /// </summary>
        /// <param name="reserva"></param>
        public void AgregarDato(Reserva reserva)
         
        {
            crud.CreateData(reserva);
        }

        /// <summary>
        /// este metodo actualiza datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reserva"></param>
        public void ActualizarDato(int id, Reserva reserva)
        {
            crud.UpdateData(id,reserva);
        }

        /// <summary>
        /// este metodo elimina datos
        /// </summary>
        /// <param name="id"></param>
        public void EliminarDato(int id)
        {
            crud.DeleteData(id);
        }

    }
}
