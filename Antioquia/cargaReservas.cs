﻿using Datos_;
using Logica_;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Antioquia
{
    public partial class cargaReservas : Form
    {
        // Instancia de LogicaDeNegocio para usar sus métodos
        private LogicaDeNegocio logicaNegocio = new LogicaDeNegocio();

        // Referencia al formulario con el DataGridView
        private ListaDeReservas formReservas;

        public cargaReservas(ListaDeReservas formReservas)
        {
            InitializeComponent();
            // Se inicializa DateTimePicker para que solo muestre la hora
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
            dtpHora.Width = 100;
            Controls.Add(dtpHora);

            // Asignar la referencia del formulario de reservas
            this.formReservas = formReservas;
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
                logicaNegocio.AgregarDato(nuevaReserva);

                // Llamar al método de actualización del DataGridView en el otro formulario
                formReservas.ActualizarReservaciones();

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
            // Reiniciar selección del ComboBox
            cbxTipodeEvento.SelectedIndex = -1;
            // Resetear a la fecha actual
            dtpFecha.Value = DateTime.Now;
            // Resetear a la hora actual
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

        //Para el botón de reserva
        // Cambia el color del botón cuando el mouse entra en él
        private void btnReserva_MouseEnter(object sender, EventArgs e)
        {
            btnReserva.BackColor = Color.FromArgb(255, 128, 0);
            btnReserva.ForeColor = Color.Black;
        }
        // Restablece el color del botón cuando el mouse sale
        private void btnReserva_MouseLeave(object sender, EventArgs e)
        {
            btnReserva.BackColor = Color.FromArgb(68, 121, 171);
            btnReserva.ForeColor = Color.FromArgb(255, 128, 0);
        }
    }
}


