namespace Antioquia
{
    partial class cargaReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            btnReserva = new Button();
            cbxTipodeEvento = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            btnListaDeReserva = new Button();
            lbMailInvalido = new Label();
            SuspendLayout();
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.FromArgb(255, 255, 192);
            btnReserva.Location = new Point(274, 391);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(94, 29);
            btnReserva.TabIndex = 0;
            btnReserva.Text = "Reservar";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // cbxTipodeEvento
            // 
            cbxTipodeEvento.FormattingEnabled = true;
            cbxTipodeEvento.Items.AddRange(new object[] { "Cumpleaños", "Fiesta de 15", "Evento Empresarial", "Otros" });
            cbxTipodeEvento.Location = new Point(276, 213);
            cbxTipodeEvento.Name = "cbxTipodeEvento";
            cbxTipodeEvento.Size = new Size(151, 28);
            cbxTipodeEvento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 84);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 128);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 176);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 221);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 6;
            label5.Text = "Tipo de Evento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 269);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 7;
            label6.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 316);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 8;
            label7.Text = "Hora";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(276, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(276, 125);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(274, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 27);
            txtEmail.TabIndex = 12;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(275, 264);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(124, 27);
            dtpFecha.TabIndex = 13;
            dtpFecha.Value = new DateTime(2024, 9, 10, 0, 0, 0, 0);
            // 
            // dtpHora
            // 
            dtpHora.CalendarForeColor = SystemColors.ActiveCaption;
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(276, 309);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(78, 27);
            dtpHora.TabIndex = 14;
            // 
            // btnListaDeReserva
            // 
            btnListaDeReserva.BackColor = Color.Lime;
            btnListaDeReserva.Location = new Point(28, 37);
            btnListaDeReserva.Name = "btnListaDeReserva";
            btnListaDeReserva.Size = new Size(103, 29);
            btnListaDeReserva.TabIndex = 15;
            btnListaDeReserva.Text = "Ver Reservas";
            btnListaDeReserva.UseVisualStyleBackColor = false;
            btnListaDeReserva.Click += btnListaDeReserva_Click;
            // 
            // lbMailInvalido
            // 
            lbMailInvalido.AutoSize = true;
            lbMailInvalido.Location = new Point(442, 174);
            lbMailInvalido.Name = "lbMailInvalido";
            lbMailInvalido.Size = new Size(0, 20);
            lbMailInvalido.TabIndex = 16;
            // 
            // cargaReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(lbMailInvalido);
            Controls.Add(btnListaDeReserva);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxTipodeEvento);
            Controls.Add(btnReserva);
            Name = "cargaReservas";
            Text = "cargaReservas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReserva;
        private ComboBox cbxTipodeEvento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private Button btnListaDeReserva;
        private Label lbMailInvalido;
    }
}