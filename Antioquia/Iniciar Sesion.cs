using Datos_;
using Logica_;

namespace Antioquia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                cargaReservas cambioForm = new cargaReservas();
                cambioForm.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                // Muestra los errores de validación al usuario
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
