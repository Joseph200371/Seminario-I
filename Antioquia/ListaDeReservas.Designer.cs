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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnLeft = new Panel();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevaReserva = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnTop = new Panel();
            dgvReservaciones = new DataGridView();
            pnFormHijo = new Panel();
            pnLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(100, 0, 142);
            pnLeft.Controls.Add(btnEliminar);
            pnLeft.Controls.Add(btnEditar);
            pnLeft.Controls.Add(btnNuevaReserva);
            pnLeft.Controls.Add(panel1);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(216, 451);
            pnLeft.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.FlatAppearance.BorderColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Red;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(0, 284);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(216, 34);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseEnter += btnEliminar_MouseEnter;
            btnEliminar.MouseLeave += btnEliminar_MouseLeave;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Top;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.LightGreen;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.LightGreen;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(0, 250);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(216, 34);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            btnEditar.MouseEnter += btnEditar_MouseEnter;
            btnEditar.MouseLeave += btnEditar_MouseLeave;
            // 
            // btnNuevaReserva
            // 
            btnNuevaReserva.Dock = DockStyle.Top;
            btnNuevaReserva.FlatAppearance.BorderSize = 2;
            btnNuevaReserva.FlatStyle = FlatStyle.Flat;
            btnNuevaReserva.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaReserva.ForeColor = Color.FromArgb(255, 128, 0);
            btnNuevaReserva.IconChar = FontAwesome.Sharp.IconChar.File;
            btnNuevaReserva.IconColor = Color.FromArgb(255, 128, 0);
            btnNuevaReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaReserva.IconSize = 25;
            btnNuevaReserva.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaReserva.Location = new Point(0, 216);
            btnNuevaReserva.Name = "btnNuevaReserva";
            btnNuevaReserva.Size = new Size(216, 34);
            btnNuevaReserva.TabIndex = 1;
            btnNuevaReserva.Text = "Nueva Reserva";
            btnNuevaReserva.UseVisualStyleBackColor = true;
            btnNuevaReserva.Click += btnNuevaReserva_Click;
            btnNuevaReserva.MouseEnter += btnNuevaReserva_MouseEnter;
            btnNuevaReserva.MouseLeave += btnNuevaReserva_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 216);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(68, 121, 171);
            pnTop.Controls.Add(dgvReservaciones);
            pnTop.Dock = DockStyle.Top;
            pnTop.ForeColor = SystemColors.ControlLight;
            pnTop.Location = new Point(216, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(741, 216);
            pnTop.TabIndex = 5;
            // 
            // dgvReservaciones
            // 
            dgvReservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReservaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReservaciones.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvReservaciones.BorderStyle = BorderStyle.None;
            dgvReservaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservaciones.ColumnHeadersHeight = 30;
            dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReservaciones.Dock = DockStyle.Top;
            dgvReservaciones.EnableHeadersVisualStyles = false;
            dgvReservaciones.GridColor = Color.SteelBlue;
            dgvReservaciones.Location = new Point(0, 0);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservaciones.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvReservaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvReservaciones.Size = new Size(741, 213);
            dgvReservaciones.TabIndex = 0;
            // 
            // pnFormHijo
            // 
            pnFormHijo.BackColor = Color.FromArgb(68, 121, 171);
            pnFormHijo.Dock = DockStyle.Bottom;
            pnFormHijo.Location = new Point(216, 215);
            pnFormHijo.Name = "pnFormHijo";
            pnFormHijo.Size = new Size(741, 236);
            pnFormHijo.TabIndex = 6;
            // 
            // ListaDeReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 451);
            Controls.Add(pnFormHijo);
            Controls.Add(pnTop);
            Controls.Add(pnLeft);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListaDeReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeReservas";
            pnLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnLeft;
        private Panel pnTop;
        private Panel pnFormHijo;
        private PictureBox pictureBox1;
        private DataGridView dgvReservaciones;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevaReserva;
    }
}