namespace Datos_
{/// <summary>
/// Se crea la clase tipo reserva donde se colocan todos lo atributos a utilizar
/// </summary>
    public class Reserva
    {
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string tipodeevento;
        private string fecha;
        private string hora;

        // se generar los get u set para ser utilizacion y modificados en otras clases
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Tipodeevento { get => tipodeevento; set => tipodeevento = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        
    }
}
