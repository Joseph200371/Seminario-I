namespace Antioquia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(108, 125);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario :";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(108, 167);
            lblContraseña.Margin = new Padding(2, 0, 2, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(73, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña :";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(157, 226);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(79, 28);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(108, 142);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(194, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Location = new Point(108, 184);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(194, 23);
            txtContraseña.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._453650905_1609472593166796_4331187445224533546_n;
            pictureBox1.Location = new Point(108, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 280);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Secion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
    }
}
