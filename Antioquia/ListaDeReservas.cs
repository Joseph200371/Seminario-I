using Datos_;
using Logica_;
using Microsoft.VisualBasic.Logging;
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
    public partial class ListaDeReservas : Form
    {
        /// <summary>
        /// Constructor de la clase ListaDeReservas.
        /// Inicializa componentes, configura el DateTimePicker y carga las reservas en el DataGridView.
        /// </summary>
        public ListaDeReservas()
        {
            InitializeComponent();

            //inicializo DateTimePicker para ver solo la hora en el formulario
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
            dtpHora.Width = 100;
            Controls.Add(dtpHora);

            // Cargo los valores obtenidos del método ObtenerReserva y utilizo DataSource para
            // cargar los datos en el DataGridView de manera automática
            dgvReservaciones.DataSource = logic.ObtenerReserva();

            // Ajusto automáticamente las columnas según el tamaño del contenido
            dgvReservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Se instancia LogicaDeNegocio para utilizar sus métodos
        private LogicaDeNegocio logic = new LogicaDeNegocio();

        /// <summary>
        /// Evento que maneja el clic en el botón "Volver". Navega al formulario anterior.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            cargaReservas cambioForm = new cargaReservas();
            cambioForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Eliminar". Elimina una reserva seleccionada del DataGridView.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Utilizo este scrip el cual utilizado metodos del datagridview
            // Me devuelve el valor de la fila selecciona
            foreach (DataGridViewCell celda in dgvReservaciones.SelectedCells)
            {
                object valorCelda = celda.Value;
                string valor = valorCelda?.ToString() ?? "N/A";

                // Confirmación antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta reserva?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Elimina la reserva de la lógica de negocio
                    logic.EliminarDato(int.Parse(valor));
                }
            }
            dgvReservaciones.DataSource = logic.ObtenerReserva();
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Editar". Permite editar una reserva seleccionada.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var reserva = logic.ObtenerReserva();

            // Seleciona el id que deseea editar
            // Itera sobre las celdas seleccionadas para obtener el valor de la fila
            foreach (DataGridViewCell celda in dgvReservaciones.SelectedCells)
            {
                object valorCelda = celda.Value;
                string valor = valorCelda?.ToString() ?? "N/A";

                // Busca la reserva correspondiente en la base de datos
                foreach (var item in reserva)
                {

                    // Se consulta se el id seleccionado es igual al id de la base de datos
                    if (int.Parse(valor) == item.Id)
                    {
                        // Llena los campos con los datos de la reserva seleccionada
                        txtNombre.Text = item.Nombre;
                        txtApellido.Text = item.Apellido;
                        txtTelefono.Text = item.Telefono;
                        txtEmail.Text = item.Email;
                        cbxTipodeEvento.Text = item.Tipodeevento;
                        dtpFecha.Text = item.Fecha;
                        dtpHora.Text = item.Hora;
                    }
                }
            }
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Guardar". Actualiza los datos de una reserva.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // instancio la clase Reserva en una variable nuevaReserva
            Reserva nuevaReserva = new Reserva();

            //tomo los valores cargados en los txtbox y los guardos en los atributos correspondientes
            nuevaReserva.Nombre = txtNombre.Text;
            nuevaReserva.Apellido = txtApellido.Text;
            nuevaReserva.Telefono = txtTelefono.Text;
            nuevaReserva.Email = txtEmail.Text;
            nuevaReserva.Tipodeevento = cbxTipodeEvento.Text;
            string fechaSolo = dtpFecha.Value.ToString("dd/MM/yyyy");
            nuevaReserva.Fecha = fechaSolo;
            string horaSolo = dtpHora.Value.ToString("HH:mm");
            nuevaReserva.Hora = horaSolo;

            // Seleccion el id con el cual quiro actualizar los valores
            // Actualiza la reserva seleccionada
            foreach (DataGridViewCell celda in dgvReservaciones.SelectedCells)
            {
                object valorCelda = celda.Value;
                string valor = valorCelda?.ToString() ?? "N/A";
                // Confirmación antes de Guardar
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas guardar esta reserva?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    logic.ActualizarDato(int.Parse(valor), nuevaReserva);
                }
            }

            // Limpia los campos y refresca el DataGridView
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dgvReservaciones.DataSource = logic.ObtenerReserva();
        }
    }
}
