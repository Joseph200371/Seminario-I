using Datos_;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica_
{
    public class LogicaDeReservas
    {
        // se crea la clase ReservarData para ejecutar todos los metodos del crud debe
        // ser estatica ya que no vamos a instaciar esta clase
        // se inicializa una lista del tipo Reserva
        private static List<Reserva> Reservas = new List<Reserva>();

        //se crea el metodo AgregarReservas del tipo reserva
        public static void AgregarReservas(Reserva cliente)
        {
            // se agregar a la lista reserca un cliente
            Reservas.Add(cliente);
        }
        // se crea el metodo Mostrar reserva para que regrese la lista Reserva 
        public static List<Reserva> MostrarReservas()
        {
            return Reservas;
        }
        // este metodo Recibe un dato del tipo int para eliminar de la lista el elemento correspondiente
        // 
        public static void EliminarReserva(int fila)
        {
            Reservas.RemoveAt(fila);
        }

        public static List<Reserva> EditarReservas(int fila)
        {
            var numeroDeFila = Reservas[fila];

            return Reservas;
        }
        public static bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
