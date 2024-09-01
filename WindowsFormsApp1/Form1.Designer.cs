namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnReservar.Location = new System.Drawing.Point(160, 350);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 28);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(440, 350);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 28);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 350);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo De evento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha";
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
            this.cbxTipoEvento.Location = new System.Drawing.Point(160, 239);
            this.cbxTipoEvento.Name = "cbxTipoEvento";
            this.cbxTipoEvento.Size = new System.Drawing.Size(200, 24);
            this.cbxTipoEvento.TabIndex = 9;
            // 
            // dtFechaEvento
            // 
            this.dtFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaEvento.Location = new System.Drawing.Point(160, 281);
            this.dtFechaEvento.Name = "dtFechaEvento";
            this.dtFechaEvento.Size = new System.Drawing.Size(113, 22);
            this.dtFechaEvento.TabIndex = 10;
            this.dtFechaEvento.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 22);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(160, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 22);
            this.txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // lstReservas
            // 
            this.lstReservas.FormattingEnabled = true;
            this.lstReservas.ItemHeight = 16;
            this.lstReservas.Location = new System.Drawing.Point(440, 66);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(314, 196);
            this.lstReservas.TabIndex = 15;
            // 
            // lEmailCorrecto
            // 
            this.lEmailCorrecto.AutoSize = true;
            this.lEmailCorrecto.Location = new System.Drawing.Point(160, 217);
            this.lEmailCorrecto.Name = "lEmailCorrecto";
            this.lEmailCorrecto.Size = new System.Drawing.Size(0, 16);
            this.lEmailCorrecto.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lEmailCorrecto);
            this.Controls.Add(this.lstReservas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtFechaEvento);
            this.Controls.Add(this.cbxTipoEvento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnReservar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Antioquia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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

