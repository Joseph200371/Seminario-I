using Datos_;
using Logica_;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Antioquia
{
    public partial class cargaReservas : Form
    {
        // Instancia de LogicaDeNegocio para usar sus métodos
        private LogicaDeNegocio logica = new LogicaDeNegocio();

        public cargaReservas()
        {
            InitializeComponent();
            // Se inicializa DateTimePicker para que solo muestre la hora
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
            dtpHora.Width = 100;
            Controls.Add(dtpHora);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica si es necesario
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón de reserva.
        /// Valida los datos del formulario y agrega una nueva reserva.
        /// </summary>
        private void btnReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los datos antes de proceder
                ValidarDatos();

                // Instancio la clase Reserva en una variable nuevaReserva
                Reserva nuevaReserva = new Reserva
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Tipodeevento = cbxTipodeEvento.Text,
                    Fecha = dtpFecha.Value.ToString("dd/MM/yyyy"),
                    Hora = dtpHora.Value.ToString("HH:mm")
                };

                // Envío el dato del Tipo Reserva al método AgregarDato
                logica.AgregarDato(nuevaReserva);

                // Limpiar los campos
                LimpiarCampos();
                MessageBox.Show("Reserva agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón para mostrar la lista de reservas.
        /// </summary>
        private void btnListaDeReserva_Click(object sender, EventArgs e)
        {
            try
            {
                ListaDeReservas cambioForm = new ListaDeReservas();
                cambioForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la lista de reservas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida todos los datos del formulario antes de proceder con la reserva.
        /// </summary>
        private void ValidarDatos()
        {
            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !SoloLetras(txtNombre.Text))
            {
                throw new Exception("El nombre solo debe contener letras.");
            }

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || !SoloLetras(txtApellido.Text))
            {
                throw new Exception("El apellido solo debe contener letras.");
            }

            // Validar Teléfono
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || !SoloNumeros(txtTelefono.Text))
            {
                throw new Exception("El teléfono solo debe contener números.");
            }

            // Validar Correo
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !CorreoValido(txtEmail.Text))
            {
                throw new Exception("El correo electrónico no es válido.");
            }

            // Validación de la fecha
            if (dtpFecha.Value.Date < DateTime.Now.Date)
            {
                throw new Exception("La fecha no puede estar en el pasado.");
            }

            // Validación de la hora
            if (dtpFecha.Value.Date == DateTime.Now.Date && dtpHora.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                throw new Exception("La hora no puede estar en el pasado.");
            }
        }

        /// <summary>
        /// Verifica si el texto solo contiene letras y espacios.
        /// </summary>
        private bool SoloLetras(string texto)
        {
            return Regex.IsMatch(texto, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$");
        }

        /// <summary>
        /// Verifica si el texto solo contiene números.
        /// </summary>
        private bool SoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, "^[0-9]+$");
        }

        /// <summary>
        /// Valida si el correo electrónico tiene un formato correcto.
        /// </summary>
        private bool CorreoValido(string correo)
        {
            // Expresión regular simple para validar correos electrónicos
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cbxTipodeEvento.SelectedIndex = -1; // Reiniciar selección del ComboBox
            dtpFecha.Value = DateTime.Now; // Resetear a la fecha actual
            dtpHora.Value = DateTime.Now; // Resetear a la hora actual
        }
    }
}


