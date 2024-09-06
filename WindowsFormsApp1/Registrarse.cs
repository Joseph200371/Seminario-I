using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent(); 
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ///<summary>
            /// Son algunas excepciones del tipo null, para Los distintos campos
            /// </summary>
            /// <exception cref="IsNullOrEmpty"
            try
            {
                if (string.IsNullOrWhiteSpace(txtMail.Text) && string.IsNullOrWhiteSpace(txtContrasenia.Text) && string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new ArgumentException("Todos los campos debe ser completado");
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) 
                {
                    throw new ArgumentException("Deber llenar el campo Nombre");
                }
                if (string.IsNullOrWhiteSpace(txtMail.Text))
                {
                    throw new ArgumentException("Deber llenar el campo Email");
                }
                if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    throw new ArgumentException("Deber llenar el campo Contraseña");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        /// <summary>
        /// Maneja el evento del botón 'Inicio' para cambiar de la vista 'Registrarse' a 'Iniciar Sesión'.
        /// Oculta el formulario actual y muestra el formulario de iniciar seción.
        /// </summary>
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Lógica para ocultar el formulario de registro y mostrar el formulario de inicio de sesión
            Iniciar_Sesion cambioForm = new Iniciar_Sesion();
            cambioForm.Show();
            this.Hide();
        }
            
        ///<summary>
        /// Obtener las dimensiones de la pantalla, para poder tener los Form en el centro de la pantalla
        ///</summary>
        private void Registrarse_Load(object sender, EventArgs e)
        {
            

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            /// Obtener las dimensiones del formulario
            int formWidth = this.Width;
            int formHeight = this.Height;

            /// Calcular las coordenadas para centrar el formulario
            int centerX = (screenWidth / 2) - (formWidth / 2);
            int centerY = (screenHeight / 2) - (formHeight / 2);

            /// Establecer la posición manualmente
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(centerX, centerY);
        }
    }
}
