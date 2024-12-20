﻿namespace Antioquia
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
            lblTipoEvento = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            lblInfo = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.FromArgb(68, 121, 171);
            btnReserva.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnReserva.FlatAppearance.BorderSize = 2;
            btnReserva.FlatStyle = FlatStyle.Flat;
            btnReserva.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReserva.ForeColor = Color.FromArgb(255, 128, 0);
            btnReserva.Location = new Point(534, 181);
            btnReserva.Margin = new Padding(3, 2, 3, 2);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(97, 35);
            btnReserva.TabIndex = 0;
            btnReserva.Text = "Reservar";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            btnReserva.MouseEnter += btnReserva_MouseEnter;
            btnReserva.MouseLeave += btnReserva_MouseLeave;
            // 
            // cbxTipodeEvento
            // 
            cbxTipodeEvento.Font = new Font("Century Gothic", 9.75F);
            cbxTipodeEvento.FormattingEnabled = true;
            cbxTipodeEvento.Items.AddRange(new object[] { "Cumpleaños", "Fiesta de 15", "Evento Empresarial", "Otros" });
            cbxTipodeEvento.Location = new Point(290, 128);
            cbxTipodeEvento.Margin = new Padding(3, 2, 3, 2);
            cbxTipodeEvento.Name = "cbxTipodeEvento";
            cbxTipodeEvento.Size = new Size(173, 25);
            cbxTipodeEvento.TabIndex = 18;
            cbxTipodeEvento.Text = "Tipo de Evento";
            // 
            // lblTipoEvento
            // 
            lblTipoEvento.AutoSize = true;
            lblTipoEvento.BackColor = Color.Transparent;
            lblTipoEvento.Font = new Font("Century Gothic", 9.75F);
            lblTipoEvento.ForeColor = SystemColors.Control;
            lblTipoEvento.Location = new Point(290, 101);
            lblTipoEvento.Name = "lblTipoEvento";
            lblTipoEvento.Size = new Size(112, 17);
            lblTipoEvento.TabIndex = 23;
            lblTipoEvento.Text = "Tipo de Evento :";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Century Gothic", 9.75F);
            lblFecha.ForeColor = SystemColors.Control;
            lblFecha.Location = new Point(290, 167);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(55, 17);
            lblFecha.TabIndex = 24;
            lblFecha.Text = "Fecha :";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Century Gothic", 9.75F);
            lblHora.ForeColor = SystemColors.Control;
            lblHora.Location = new Point(534, 36);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(47, 17);
            lblHora.TabIndex = 25;
            lblHora.Text = "Hora :";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(43, 62);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 26;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 9.75F);
            txtApellido.Location = new Point(44, 128);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(155, 23);
            txtApellido.TabIndex = 27;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 9.75F);
            txtTelefono.Location = new Point(43, 193);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 23);
            txtTelefono.TabIndex = 28;
            txtTelefono.Text = "Teléfono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 9.75F);
            txtEmail.Location = new Point(290, 62);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 29;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Century Gothic", 9.75F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(290, 193);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(173, 23);
            dtpFecha.TabIndex = 30;
            dtpFecha.Value = new DateTime(2024, 9, 10, 0, 0, 0, 0);
            // 
            // dtpHora
            // 
            dtpHora.CalendarForeColor = SystemColors.ActiveCaption;
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(534, 62);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(97, 23);
            dtpHora.TabIndex = 31;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.DarkGray;
            lblInfo.Location = new Point(44, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(149, 23);
            lblInfo.TabIndex = 32;
            lblInfo.Text = "Nueva Reserva";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(44, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 4);
            panel1.TabIndex = 33;
            // 
            // cargaReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 121, 171);
            ClientSize = new Size(659, 233);
            Controls.Add(panel1);
            Controls.Add(lblInfo);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(lblTipoEvento);
            Controls.Add(cbxTipodeEvento);
            Controls.Add(btnReserva);
            Margin = new Padding(3, 2, 3, 2);
            Name = "cargaReservas";
            Text = "cargaReservas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReserva;
        private ComboBox cbxTipodeEvento;
        private Label lblTipoEvento;
        private Label lblFecha;
        private Label lblHora;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private Label lblInfo;
        private Panel panel1;
    }
}