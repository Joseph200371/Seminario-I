namespace WindowsFormsApp1
{
    partial class RegistrosDeEventos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.cbxTipoEvento = new System.Windows.Forms.ComboBox();
            this.dtFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstReservas = new System.Windows.Forms.ListBox();
            this.lEmailCorrecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(120, 284);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(330, 284);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 54);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(26, 88);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(26, 123);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 158);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(26, 194);
            this.lblTipoEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(84, 13);
            this.lblTipoEvento.TabIndex = 7;
            this.lblTipoEvento.Text = "Tipos de evento";
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Location = new System.Drawing.Point(26, 234);
            this.lblFechaEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(90, 13);
            this.lblFechaEvento.TabIndex = 8;
            this.lblFechaEvento.Text = "Fecha del evento";
            // 
            // cbxTipoEvento
            // 
            this.cbxTipoEvento.FormattingEnabled = true;
            this.cbxTipoEvento.Items.AddRange(new object[] {
            "Fiesta de 15 ",
            "Casamientos",
            "Despedidas de Soltero/a",
            "Fiesta de Egresados",
            "Otros"});
            this.cbxTipoEvento.Location = new System.Drawing.Point(120, 194);
            this.cbxTipoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoEvento.Name = "cbxTipoEvento";
            this.cbxTipoEvento.Size = new System.Drawing.Size(151, 21);
            this.cbxTipoEvento.TabIndex = 9;
            // 
            // dtFechaEvento
            // 
            this.dtFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaEvento.Location = new System.Drawing.Point(120, 228);
            this.dtFechaEvento.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaEvento.Name = "dtFechaEvento";
            this.dtFechaEvento.Size = new System.Drawing.Size(86, 20);
            this.dtFechaEvento.TabIndex = 10;
            this.dtFechaEvento.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 158);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 123);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 88);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 54);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lstReservas
            // 
            this.lstReservas.FormattingEnabled = true;
            this.lstReservas.Location = new System.Drawing.Point(330, 54);
            this.lstReservas.Margin = new System.Windows.Forms.Padding(2);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(236, 160);
            this.lstReservas.TabIndex = 15;
            // 
            // lEmailCorrecto
            // 
            this.lEmailCorrecto.AutoSize = true;
            this.lEmailCorrecto.Location = new System.Drawing.Point(120, 176);
            this.lEmailCorrecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEmailCorrecto.Name = "lEmailCorrecto";
            this.lEmailCorrecto.Size = new System.Drawing.Size(0, 13);
            this.lEmailCorrecto.TabIndex = 16;
            // 
            // RegistrosDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lEmailCorrecto);
            this.Controls.Add(this.lstReservas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtFechaEvento);
            this.Controls.Add(this.cbxTipoEvento);
            this.Controls.Add(this.lblFechaEvento);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnReservar);
            this.Name = "RegistrosDeEventos";
            this.Text = "Antioquia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.ComboBox cbxTipoEvento;
        private System.Windows.Forms.DateTimePicker dtFechaEvento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstReservas;
        private System.Windows.Forms.Label lEmailCorrecto;
    }
}