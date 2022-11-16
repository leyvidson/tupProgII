namespace FrontEnd_CINE.Forms
{
    partial class FormReservas
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
            this.panelContenedorReservas = new System.Windows.Forms.Panel();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblReservas = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.panelContenedorReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorReservas
            // 
            this.panelContenedorReservas.Controls.Add(this.lbl_cerrar);
            this.panelContenedorReservas.Controls.Add(this.dgvReserva);
            this.panelContenedorReservas.Controls.Add(this.lblReservas);
            this.panelContenedorReservas.Controls.Add(this.btnNueva);
            this.panelContenedorReservas.Location = new System.Drawing.Point(4, 1);
            this.panelContenedorReservas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContenedorReservas.Name = "panelContenedorReservas";
            this.panelContenedorReservas.Size = new System.Drawing.Size(960, 487);
            this.panelContenedorReservas.TabIndex = 0;
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cerrar.Location = new System.Drawing.Point(931, 0);
            this.lbl_cerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(22, 22);
            this.lbl_cerrar.TabIndex = 5;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_funcion,
            this.id_cliente,
            this.id_pelicula,
            this.fecha,
            this.cantidad,
            this.btnImprimir});
            this.dgvReserva.Location = new System.Drawing.Point(0, 68);
            this.dgvReserva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(957, 344);
            this.dgvReserva.TabIndex = 4;
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserva_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 90;
            // 
            // id_funcion
            // 
            this.id_funcion.HeaderText = "Funcion";
            this.id_funcion.Name = "id_funcion";
            this.id_funcion.Width = 150;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // id_pelicula
            // 
            this.id_pelicula.HeaderText = "Pelicula";
            this.id_pelicula.Name = "id_pelicula";
            this.id_pelicula.Width = 150;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 95;
            // 
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "Acciones";
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnImprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseColumnTextForButtonValue = true;
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservas.Location = new System.Drawing.Point(324, 9);
            this.lblReservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(86, 22);
            this.lblReservas.TabIndex = 3;
            this.lblReservas.Text = "Reservas";
            // 
            // btnNueva
            // 
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNueva.ForeColor = System.Drawing.Color.Black;
            this.btnNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNueva.Location = new System.Drawing.Point(0, 419);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNueva.Size = new System.Drawing.Size(154, 63);
            this.btnNueva.TabIndex = 2;
            this.btnNueva.Text = "Nueva   ";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 525);
            this.Controls.Add(this.panelContenedorReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormReservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            this.panelContenedorReservas.ResumeLayout(false);
            this.panelContenedorReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorReservas;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnImprimir;
    }
}