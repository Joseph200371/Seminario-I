namespace Antioquia
{
    partial class FormEditar
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
            btnConfirmar = new Button();
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
            pnLine = new Panel();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(68, 121, 171);
            btnConfirmar.FlatAppearance.BorderColor = Color.LightGreen;
            btnConfirmar.FlatAppearance.BorderSize = 2;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.LightGreen;
            btnConfirmar.Location = new Point(534, 182);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 34);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            btnConfirmar.MouseEnter += btnConfirmar_MouseEnter;
            btnConfirmar.MouseLeave += btnConfirmar_MouseLeave;
            // 
            // cbxTipodeEvento
            // 
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
            lblHora.ForeColor = SystemColors.Control;
            lblHora.Location = new Point(534, 36);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(47, 17);
            lblHora.TabIndex = 25;
            lblHora.Text = "Hora :";
            // 
            // txtNombre
            // 
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
            dtpHora.Size = new Size(101, 23);
            dtpHora.TabIndex = 31;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.DarkGray;
            lblInfo.Location = new Point(43, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(141, 23);
            lblInfo.TabIndex = 32;
            lblInfo.Text = "Editar Reserva";
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.DarkGray;
            pnLine.Location = new Point(44, 35);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(140, 4);
            pnLine.TabIndex = 33;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 121, 171);
            ClientSize = new Size(659, 233);
            Controls.Add(pnLine);
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
            Controls.Add(btnConfirmar);
            Font = new Font("Century Gothic", 9.75F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEditar";
            Text = "FormEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
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
        private Panel pnLine;
    }
}