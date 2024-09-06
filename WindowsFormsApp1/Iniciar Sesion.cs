using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Iniciar_Sesion : Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        ///<summary>
        /// Maneja el evento del botón 'Ingresar' para iniciar sesión.
        /// Valida los campos de correo electrónico y contraseña antes de intentar iniciar sesión.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Lanza una excepción si los campos txtMail o txtContrsenia están vacíos, nulos o contienen solo espacios en blanco
        /// </exception>
        private void btnIngresar_Click(object sender, EventArgs e)
        {    
            try
            {
                // Validar si los campos están vacíos o contienen solo espacios en blanco
                if (string.IsNullOrWhiteSpace(txtMail.Text) && string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    throw new ArgumentException("Ambos campos debe ser llenado Email y Contraseña");
                }
                if (string.IsNullOrEmpty(txtContrasenia.Text))
                {
                    throw new ArgumentException("Deber llenar el campo Contraseña");
                }
                if (string.IsNullOrWhiteSpace(txtMail.Text))
                {
                    throw new ArgumentException("Deber llenar el campo Email");
                }
                else if (ComprobarFormatoEmail(txtMail.Text) == false)
                {
                    //lEmailCorrecto.Text = "Dirección de Email no valida";
                    //lEmailCorrecto.ForeColor = Color.Red;
                }



            }
            catch (ArgumentException ex)
            {
                // Manejo de errores si los campos están vacíos o inválidos
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                // Captura cualquier otro error inesperado
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Maneja el evento del botón 'Registrarte' para cambiar de la vista 'Iniciar Sesión' a 'Registrarse'.
        /// Oculta el formulario actual y muestra el formulario de registro.
        /// </summary>
        private void btnRegistrarte_Click(object sender, EventArgs e)
        {
            // Lógica para ocultar el formulario de inicio de sesión y mostrar el formulario de registro
            Registrarse cambioForm = new Registrarse();
            cambioForm.Show();
            this.Hide();
        }

        ///<summary>
        /// Obtener las dimensiones de la pantalla, para poder tener los Form en el centro de la pantalla
        ///</summary>
        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {
            // Obtener las dimensiones de la pantalla
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Obtener las dimensiones del formulario
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Calcular las coordenadas para centrar el formulario
            int centerX = (screenWidth / 2) - (formWidth / 2);
            int centerY = (screenHeight / 2) - (formHeight / 2);

            // Establecer la posición manualmente
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(centerX, centerY);
        }
    }
}
