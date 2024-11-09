using Datos_;
using Logica_;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antioquia
{
    public partial class FormEditar : Form
    {
        // Instancia de LogicaDeNegocio para usar sus métodos
        private LogicaDeNegocio logicaNegocio = new LogicaDeNegocio();

        // Referencia al formulario con el DataGridView
        private ListaDeReservas formEditarReserva;

        /// <summary>
        /// Constructor de la clase FormEditar.
        /// Inicializa componentes, configura el DateTimePicker.
        /// </summary>
        public FormEditar(ListaDeReservas formEditarReserva)
        {
            InitializeComponent();
            // Se inicializa DateTimePicker para que solo muestre la hora
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
            dtpHora.Width = 100;
            Controls.Add(dtpHora);

            // Asignar la referencia del formulario de reservas
            this.formEditarReserva = formEditarReserva;
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Confirmar". Actualiza los datos de una reserva.
        /// </summary>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de Reserva y asignar valores desde los TextBox
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

                // Selecciona la celda del ID de la reserva para actualizar
                foreach (DataGridViewCell celda in formEditarReserva.ObtenerReservasSeleccionadas())
                {
                    //int idReserva = int.Parse(celda.Value.ToString());
                    object valorCelda = celda.Value;
                    string valor = valorCelda?.ToString() ?? "N/A";
                    // Confirmación antes de Guardar
                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas guardar esta reserva?",
                                                         "Confirmar Guardado",
                                                         MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        //logicaNegocio.ActualizarDato(idReserva, nuevaReserva);
                        logicaNegocio.ActualizarDato(int.Parse(valor), nuevaReserva);
                        formEditarReserva.ActualizarDataGridView();  // Actualizar el DataGridView en ListaDeReservas
                        MessageBox.Show("Reserva actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarReserva(int idReserva)
        {
            var reserva = logicaNegocio.ObtenerReserva();

            // Busca la reserva en la lista de reservas obtenida
            var reservaSeleccionada = reserva.FirstOrDefault(r => r.Id == idReserva);
            if (reservaSeleccionada != null)
            {
                // Llena los campos con los datos de la reserva seleccionada
                txtNombre.Text = reservaSeleccionada.Nombre;
                txtApellido.Text = reservaSeleccionada.Apellido;
                txtTelefono.Text = reservaSeleccionada.Telefono;
                txtEmail.Text = reservaSeleccionada.Email;
                cbxTipodeEvento.Text = reservaSeleccionada.Tipodeevento;
                dtpFecha.Text = reservaSeleccionada.Fecha;
                dtpHora.Text = reservaSeleccionada.Hora;
            }
            else
            {
                MessageBox.Show("No se encontró la reserva seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método para limpiar campos después de actualizar la reserva
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cbxTipodeEvento.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
        }

        // Diseño 

        /// <summary>
        /// Configura el comportamiento al entrar en un campo de texto. 
        /// Elimina el marcador de posición y cambia el color del texto cuando está en foco.
        /// </summary>
        /// <param name="textBox">El campo de texto a modificar.</param>
        /// <param name="placeholder">El texto del marcador de posición.</param>
        private void TextBox_Enter(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
            }
        }

        // Comportamiento al entrar en un campo de texto
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtNombre, "Nombre");
        }
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtApellido, "Apellido");
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtTelefono, "Teléfono");
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(txtEmail, "Email");
        }

        /// <summary>
        /// Configura el comportamiento al salir de un campo de texto. 
        /// Restaura el marcador de posición y ajusta el color si el campo está vacío.
        /// </summary>
        /// <param name="textBox">El campo de texto a modificar.</param>
        /// <param name="placeholder">El texto del marcador de posición.</param>
        private void TextBox_Leave(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
            }
        }

        // Comportamiento al salir de un campo de texto
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtApellido, "Apellido");
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtTelefono, "Teléfono");
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtEmail, "Email");
        }

        //Para el botón de confirmar
        // Cambia el color del botón cuando el mouse entra en él
        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.FromArgb(144, 238, 144);
            btnConfirmar.ForeColor = Color.Black;
        }
        // Restablece el color del botón cuando el mouse sale
        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.FromArgb(68, 121, 171);
            btnConfirmar.ForeColor = Color.FromArgb(144, 238, 144);
        }
    }
}
