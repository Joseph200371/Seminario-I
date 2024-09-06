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
    public partial class RegistrosDeEventos : Form
    {
        public RegistrosDeEventos()
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
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtTelefono.Text) && string.IsNullOrEmpty(cbxTipoEvento.Text) && string.IsNullOrEmpty(dtFechaEvento.Text)) 
                {
                    throw new Exception("Todos los campos debe ser completado");
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    throw new Exception("Deber llenar el campo nombre");
                }
                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    throw new Exception("Deber llenar el campo apellido");
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    throw new Exception("Deber llenar el campo Email");
                }
                else if (ComprobarFormatoEmail(txtEmail.Text) == false)
                {
                    //MessageBox.Show("Error");

                    lEmailCorrecto.Text = "Dirección de Email no valida";
                    lEmailCorrecto.ForeColor = Color.Red;
                }
                // else
                // {
                //     lEmailCorrecto.Text = "Dirección valida";
                //     lEmailCorrecto.ForeColor = Color.Green;
                // }
                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    throw new Exception("Deber llenar el campo telefono");
                }
                if (string.IsNullOrEmpty(cbxTipoEvento.Text))
                {
                    throw new Exception("Deber llenar el campo tipo de evento");
                }
                if (string.IsNullOrEmpty(dtFechaEvento.Text))
                {
                    throw new Exception("Deber llenar el campo fecha de evento");
                }
                string reserva = $"{txtNombre.Text} - {txtApellido.Text} " +
                            $"- {txtEmail.Text} - {txtTelefono.Text} - {cbxTipoEvento.Text} - {dtFechaEvento.Text}";
                lstReservas.Items.Add(reserva);
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                txtTelefono.Clear();
                // lEmailCorrecto.Clear();
                //  cbxTipoEvento.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");


            }
            //MessageBox.Show(reserva);
        }

    }
}
