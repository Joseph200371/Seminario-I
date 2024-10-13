using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System;

namespace Antioquia
{
    partial class ListaDeReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeReservas));
            btnVolver = new Button();
            dgvReservaciones = new DataGridView();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblHora = new Label();
            ldlFecha = new Label();
            lblTipoEvento = new Label();
            lblEmails = new Label();
            lblTelefono = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            cbxTipodeEvento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(27, 273);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(156, 22);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvReservaciones
            // 
            dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservaciones.Location = new Point(3, 46);
            dgvReservaciones.Margin = new Padding(3, 2, 3, 2);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.RowHeadersWidth = 51;
            dgvReservaciones.Size = new Size(735, 141);
            dgvReservaciones.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(27, 247);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 22);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 255, 192);
            btnEditar.Location = new Point(27, 221);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(156, 22);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 255, 192);
            btnGuardar.Location = new Point(551, 172);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 28, 112);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnVolver);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 451);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources._453650905_1609472593166796_4331187445224533546_n;
            pictureBox1.InitialImage = Properties.Resources._453650905_1609472593166796_4331187445224533546_n;
            pictureBox1.Image = Image.FromFile(@"T:\JM_ES\Desktop\Antioquia V3.0\Antioquia\Resources\logo.jpg");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 28, 112);
            panel2.Controls.Add(dgvReservaciones);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(216, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 216);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(7, 28, 112);
            panel3.Controls.Add(dtpHora);
            panel3.Controls.Add(dtpFecha);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtTelefono);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(lblHora);
            panel3.Controls.Add(ldlFecha);
            panel3.Controls.Add(lblTipoEvento);
            panel3.Controls.Add(lblEmails);
            panel3.Controls.Add(lblTelefono);
            panel3.Controls.Add(lblApellido);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(cbxTipodeEvento);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(216, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 236);
            panel3.TabIndex = 6;
            // 
            // dtpHora
            // 
            dtpHora.CalendarForeColor = SystemColors.ActiveCaption;
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(551, 39);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(69, 23);
            dtpHora.TabIndex = 31;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(307, 170);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(170, 23);
            dtpFecha.TabIndex = 30;
            dtpFecha.Value = new DateTime(2024, 9, 10, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(307, 39);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 23);
            txtEmail.TabIndex = 29;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(60, 170);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 23);
            txtTelefono.TabIndex = 28;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(61, 105);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 23);
            txtApellido.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 39);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 26;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.ForeColor = SystemColors.Control;
            lblHora.Location = new Point(551, 13);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(42, 15);
            lblHora.TabIndex = 25;
            lblHora.Text = " Hora :";
            // 
            // ldlFecha
            // 
            ldlFecha.AutoSize = true;
            ldlFecha.ForeColor = SystemColors.Control;
            ldlFecha.Location = new Point(307, 144);
            ldlFecha.Name = "ldlFecha";
            ldlFecha.Size = new Size(44, 15);
            ldlFecha.TabIndex = 24;
            ldlFecha.Text = "Fecha :";
            // 
            // lblTipoEvento
            // 
            lblTipoEvento.AutoSize = true;
            lblTipoEvento.ForeColor = SystemColors.Control;
            lblTipoEvento.Location = new Point(307, 78);
            lblTipoEvento.Name = "lblTipoEvento";
            lblTipoEvento.Size = new Size(91, 15);
            lblTipoEvento.TabIndex = 23;
            lblTipoEvento.Text = "Tipo de Evento :";
            // 
            // lblEmails
            // 
            lblEmails.AutoSize = true;
            lblEmails.ForeColor = SystemColors.Control;
            lblEmails.Location = new Point(307, 13);
            lblEmails.Name = "lblEmails";
            lblEmails.Size = new Size(42, 15);
            lblEmails.TabIndex = 22;
            lblEmails.Text = "Email :";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = SystemColors.Control;
            lblTelefono.Location = new Point(60, 144);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 15);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Telefono :";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = SystemColors.Control;
            lblApellido.Location = new Point(60, 78);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 15);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(61, 13);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre :";
            // 
            // cbxTipodeEvento
            // 
            cbxTipodeEvento.FormattingEnabled = true;
            cbxTipodeEvento.Items.AddRange(new object[] { "Cumpleaños", "Fiesta de 15", "Evento Empresarial", "Otros" });
            cbxTipodeEvento.Location = new Point(307, 105);
            cbxTipodeEvento.Margin = new Padding(3, 2, 3, 2);
            cbxTipodeEvento.Name = "cbxTipodeEvento";
            cbxTipodeEvento.Size = new Size(170, 23);
            cbxTipodeEvento.TabIndex = 18;
            // 
            // ListaDeReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 451);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListaDeReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeReservas";
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private DataGridView dgvReservaciones;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblEmails;
        private Label lblTipoEvento;
        private Label ldlFecha;
        private Label lblHora;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private ComboBox cbxTipodeEvento;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;

    }
}