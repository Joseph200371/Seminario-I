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
            btnAcceder = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblLogin = new Label();
            IconBtnEye = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.LightGray;
            btnAcceder.Location = new Point(307, 217);
            btnAcceder.Margin = new Padding(2);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(297, 40);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(307, 74);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(297, 21);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(307, 149);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(297, 21);
            txtContraseña.TabIndex = 4;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(11, 53);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 142);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 290);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(307, 173);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 4);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(307, 97);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 4);
            panel3.TabIndex = 8;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.DimGray;
            lblLogin.Location = new Point(399, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(100, 32);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "LOGIN";
            // 
            // IconBtnEye
            // 
            IconBtnEye.BackgroundImageLayout = ImageLayout.None;
            IconBtnEye.FlatAppearance.BorderSize = 0;
            IconBtnEye.FlatStyle = FlatStyle.Flat;
            IconBtnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            IconBtnEye.IconColor = Color.DarkGray;
            IconBtnEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconBtnEye.IconSize = 30;
            IconBtnEye.Location = new Point(574, 145);
            IconBtnEye.Name = "IconBtnEye";
            IconBtnEye.Size = new Size(30, 25);
            IconBtnEye.TabIndex = 10;
            IconBtnEye.UseVisualStyleBackColor = true;
            IconBtnEye.Click += IconBtnEye_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(631, 290);
            Controls.Add(IconBtnEye);
            Controls.Add(lblLogin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnAcceder);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Secion";
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAcceder;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblLogin;
        private FontAwesome.Sharp.IconButton IconBtnEye;
    }
}
