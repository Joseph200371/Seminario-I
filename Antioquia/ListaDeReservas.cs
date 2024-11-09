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
        // Se instancia LogicaDeNegocio para utilizar sus métodos
        private LogicaDeNegocio logicaNegocio = new LogicaDeNegocio();

        /// <summary>
        /// Formulario actualmente abierto en la interfaz.
        /// </summary>
        private Form formularioActual;

        /// <summary>
        /// Constructor de la clase ListaDeReservas.
        /// Inicializa componentes, configura el DateTimePicker y carga las reservas en el DataGridView.
        /// </summary>
        public ListaDeReservas()
        {
            InitializeComponent();

            //Cargo los valores obtenidos del método ObtenerReserva y utilizo DataSource para
            //cargar los datos en el DataGridView de manera automática
            dgvReservaciones.DataSource = logicaNegocio.ObtenerReserva();

            //Ajusto automáticamente las columnas según el tamaño del contenido
            dgvReservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Método para obtener las reservas seleccionadas
        public IEnumerable<DataGridViewCell> ObtenerReservasSeleccionadas()
        {
            return dgvReservaciones.SelectedCells.Cast<DataGridViewCell>();
        }

        public void ActualizarReservaciones()
        {
            // Limpiar la fuente de datos
            dgvReservaciones.DataSource = null;
            // Obtener los datos actualizados
            dgvReservaciones.DataSource = logicaNegocio.ObtenerReserva();
        }

        public void ActualizarDataGridView()
        {
            // Obtener reservas actualizadas
            dgvReservaciones.DataSource = logicaNegocio.ObtenerReserva();
            // Refrescar para mostrar los cambios
            dgvReservaciones.Refresh();
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Nueva Reserva". Permite cargar una reserva 
        /// </summary>
        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            cargaReservas formCrearReserva = new cargaReservas(this);

            //Mostrar el formulario para crear reservas
            AbrirFormulario(formCrearReserva);
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Editar". Permite editar una reserva seleccionada.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar formEditarReserva = new FormEditar(this);


            //Mostrar el formulario para crear reservas
            AbrirFormulario(formEditarReserva);

            // Obtener la reserva que el usuario desea editar
            var reserva = logicaNegocio.ObtenerReserva();

            // Itera sobre las celdas seleccionadas para obtener el valor de la fila
            foreach (DataGridViewCell celda in dgvReservaciones.SelectedCells)
            {
                // Verifica que el valor de la celda no sea null o "N/A"
                if (celda.Value != null && celda.Value.ToString() != "N/A")
                {
                    object valorCelda = celda.Value;
                    string valor = valorCelda.ToString();

                    // Intenta parsear el valor a un entero
                    if (int.TryParse(valor, out int idReserva))
                    {
                        // Busca la reserva correspondiente en la base de datos
                        foreach (var item in reserva)
                        {
                            // Se consulta si el id seleccionado es igual al id de la base de datos
                            if (idReserva == item.Id)
                            {
                                // Aquí se instancia FormEditar y se carga la reserva
                                FormEditar formEditar = new FormEditar(this);
                                AbrirFormulario(formEditar);
                                formEditar.CargarReserva(item.Id); // Llama al método para cargar la reserva
                                break; // Salir del bucle una vez que hemos encontrado la reserva
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Eliminar". Elimina una reserva seleccionada del DataGridView
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
                    logicaNegocio.EliminarDato(int.Parse(valor));
                }
            }
            dgvReservaciones.DataSource = logicaNegocio.ObtenerReserva();
        }

        /// <summary>
        /// Evento que maneja el clic en el botón "Guardar". Actualiza los datos de una reserva.
        /// despues se elimina
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // instancio la clase Reserva en una variable nuevaReserva
            Reserva nuevaReserva = new Reserva();

            //tomo los valores cargados en los txtbox y los guardos en los atributos correspondientes
            //nuevaReserva.Nombre = txtNombre.Text;
            //nuevaReserva.Apellido = txtApellido.Text;
            //nuevaReserva.Telefono = txtTelefono.Text;
            //nuevaReserva.Email = txtEmail.Text;
            //nuevaReserva.Tipodeevento = cbxTipodeEvento.Text;
            //string fechaSolo = dtpFecha.Value.ToString("dd/MM/yyyy");
            //nuevaReserva.Fecha = fechaSolo;
            //string horaSolo = dtpHora.Value.ToString("HH:mm");
            //nuevaReserva.Hora = horaSolo;

            // Seleccion el id con el cual quieres actualizar los valores
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
                    logicaNegocio.ActualizarDato(int.Parse(valor), nuevaReserva);
                }
            }

            // Limpia los campos y refresca el DataGridView
            //txtNombre.Clear();
            //txtApellido.Clear();
            //txtTelefono.Clear();
            //txtEmail.Clear();

            // Refrescar el DataGridView con los nuevos datos
            dgvReservaciones.DataSource = logicaNegocio.ObtenerReserva();
        }
        /// <summary>
        /// Abre un nuevo formulario dentro del panel principal y cierra el formulario anterior si está abierto.
        /// </summary>
        /// <param name="formularioHijo">Formulario que se desea abrir.</param>
        private void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();  // Cierra el formulario anterior.
            }

            formularioActual = formularioHijo;
            formularioHijo.TopLevel = false;  // Establece que el formulario hijo no es de nivel superior.
            formularioHijo.FormBorderStyle = FormBorderStyle.None;  // Elimina los bordes del formulario.
            formularioHijo.Dock = DockStyle.Fill;  // Ajusta el formulario al tamaño del panel.
            pnFormHijo.Controls.Add(formularioHijo);
            pnFormHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();  // Muestra el formulario hijo.
        }

        // Diseño

        //Para el botón de Nueva Reserva
        // Cambia el color del botón cuando el mouse entra en él
        private void btnNuevaReserva_MouseEnter(object sender, EventArgs e)
        {
            btnNuevaReserva.BackColor = Color.FromArgb(255, 128, 0);
            btnNuevaReserva.ForeColor = Color.Black;
            btnNuevaReserva.IconColor = Color.Black;
        }
        // Restablece el color del botón cuando el mouse sale
        private void btnNuevaReserva_MouseLeave(object sender, EventArgs e)
        {
            btnNuevaReserva.BackColor = Color.FromArgb(100, 0, 142);
            btnNuevaReserva.ForeColor = Color.FromArgb(255, 128, 0);
            btnNuevaReserva.IconColor = Color.FromArgb(255, 128, 0);
        }
        
        //Para el botón de Editar
        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.BackColor = Color.FromArgb(144, 238, 144);
            btnEditar.ForeColor = Color.Black;
            btnEditar.IconColor = Color.Black;
        }
        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackColor = Color.FromArgb(100, 0, 142);
            btnEditar.ForeColor = Color.FromArgb(144, 238, 144);
            btnEditar.IconColor = Color.FromArgb(144, 238, 144);
        }

        //Para el botón de Eliminar
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.IconColor = Color.Black;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(100, 0, 142);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.IconColor= Color.Red;
        }
    }
}
