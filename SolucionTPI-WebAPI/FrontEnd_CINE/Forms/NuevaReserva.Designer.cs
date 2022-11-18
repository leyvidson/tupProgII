namespace FrontEnd_CINE.Forms
{
    partial class NuevaReserva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFechaReser = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardarNuevaReserva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.dtpFechaReser);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.cboPelicula);
            this.panel1.Controls.Add(this.lblPelicula);
            this.panel1.Controls.Add(this.cboCliente);
            this.panel1.Controls.Add(this.cboFuncion);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblFuncion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 377);
            this.panel1.TabIndex = 0;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(136, 251);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 23);
            this.nudCantidad.TabIndex = 33;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(63, 253);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 32;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dtpFechaReser
            // 
            this.dtpFechaReser.Location = new System.Drawing.Point(136, 205);
            this.dtpFechaReser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaReser.Name = "dtpFechaReser";
            this.dtpFechaReser.Size = new System.Drawing.Size(233, 23);
            this.dtpFechaReser.TabIndex = 31;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(63, 212);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 30;
            this.lblFecha.Text = "Fecha";
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(136, 165);
            this.cboPelicula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(140, 23);
            this.cboPelicula.TabIndex = 29;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(63, 168);
            this.lblPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(48, 15);
            this.lblPelicula.TabIndex = 28;
            this.lblPelicula.Text = "Pelicula";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(136, 135);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(140, 23);
            this.cboCliente.TabIndex = 27;
            // 
            // cboFuncion
            // 
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(136, 103);
            this.cboFuncion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(140, 23);
            this.cboFuncion.TabIndex = 26;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(63, 135);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(63, 103);
            this.lblFuncion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(50, 15);
            this.lblFuncion.TabIndex = 24;
            this.lblFuncion.Text = "Funcion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(779, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnGuardarNuevaReserva
            // 
            this.btnGuardarNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNuevaReserva.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarNuevaReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarNuevaReserva.Location = new System.Drawing.Point(1, 385);
            this.btnGuardarNuevaReserva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarNuevaReserva.Name = "btnGuardarNuevaReserva";
            this.btnGuardarNuevaReserva.Size = new System.Drawing.Size(150, 63);
            this.btnGuardarNuevaReserva.TabIndex = 2;
            this.btnGuardarNuevaReserva.Text = "Guardar";
            this.btnGuardarNuevaReserva.UseVisualStyleBackColor = true;
            this.btnGuardarNuevaReserva.Click += new System.EventHandler(this.btnGuardarNuevaReserva_Click);
            // 
            // NuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 520);
            this.Controls.Add(this.btnGuardarNuevaReserva);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevaReserva";
            this.Text = "NuevaReserva";
            this.Load += new System.EventHandler(this.NuevaReserva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarNuevaReserva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboFuncion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaReser;
        private System.Windows.Forms.Label lblFecha;
        private NumericUpDown nudCantidad;
    }
}