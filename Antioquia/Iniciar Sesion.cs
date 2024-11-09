using Datos_;
using Logica_;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Antioquia
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Importa la función de la biblioteca `user32.dll` para liberar el mouse 
        /// cuando se realiza un evento de captura en un formulario de Windows
        /// </summary>
        /// <returns> Devuelve el resultado de la función ReleaseCapture </returns>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        /// <summary>
        /// Importa la función de la biblioteca `user32.dll` para enviar un mensaje 
        /// a la ventana indicada, permitiendo mover el formulario al arrastrarlo
        /// </summary>
        /// <param name="hwnd"> Handle del formulario al que se le envía el mensaje </param>
        /// <param name="wmsg"> Código del mensaje a enviar (en este caso, 0x112 para mover la ventana) </param>
        /// <param name="wparam"> Parámetro adicional para el mensaje (0xf012 para indicar el arrastre) </param>
        /// <param name="lparam"> Parámetro adicional para el mensaje (0 en este caso) </param>
        /// <returns> Devuelve el resultado de la función SendMessage </returns>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            // Configurar el temporizador
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3000 ms = 3 segundos
            timer.Tick += Timer_Tick;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioMaster usuario = new UsuarioMaster();

            usuario.Usuario = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            UsuarioService usuarioService = new UsuarioService();

            try
            {
                usuarioService.RegistrarUsuario(usuario);
                ListaDeReservas cambioForm = new ListaDeReservas();
                cambioForm.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                // Muestra los errores de validación al usuario
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que se activa al entrar en el campo de texto del usuario
        /// Elimina el texto de marcador de posición y cambia el color del texto cuando está en foco
        /// </summary>
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Evento que se activa al salir del campo de texto del usuario
        /// Restaura el texto de marcador de posición si el campo está vacío y ajusta el color
        /// </summary>
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        /// <summary>
        /// Evento que se activa al entrar en el campo de texto de la contraseña
        /// Elimina el texto de marcador de posición y cambia el color del texto cuando está en foco
        /// </summary>
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Evento que se activa al salir del campo de texto de la contraseña
        /// Restaura el texto de marcador de posición si el campo está vacío, ajusta el color y muestra el texto como plano
        /// </summary>
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se detecta un evento MouseDown en el formulario
        /// Libera la captura del mouse y permite mover el formulario al arrastrarlo
        /// </summary>
        /// <param name="e"> Argumentos del evento MouseEventArgs </param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Método que se ejecuta cuando se detecta un evento MouseDown en el formulario
        /// Libera la captura del mouse y permite mover el formulario al arrastrarlo
        /// </summary>
        /// <param name="e"> Argumentos del evento MouseEventArgs </param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Metodo que se ejecuta cuando se activa el boton 'IconBtnEye_Click' para mostrar contraseña
        /// Cambia entre iconos 'IconChar.Eye' a 'IconChar.EyeSlash'
        /// </summary>
        private void IconBtnEye_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = false; // Mostrar contraseña
                IconBtnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                timer.Start();
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true; // Ocultar contraseña
                IconBtnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                timer.Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            IconBtnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            timer.Stop();
        }
    }
}
