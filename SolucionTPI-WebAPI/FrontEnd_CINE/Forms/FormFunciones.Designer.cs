namespace FrontEnd_CINE.Forms
{
    partial class FormFunciones
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
            this.panelContenedorFunciones = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.id_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lenguaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.panelContenedorFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorFunciones
            // 
            this.panelContenedorFunciones.Controls.Add(this.lblCerrar);
            this.panelContenedorFunciones.Controls.Add(this.dgvFunciones);
            this.panelContenedorFunciones.Controls.Add(this.lblFunciones);
            this.panelContenedorFunciones.Location = new System.Drawing.Point(2, 1);
            this.panelContenedorFunciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContenedorFunciones.Name = "panelContenedorFunciones";
            this.panelContenedorFunciones.Size = new System.Drawing.Size(743, 516);
            this.panelContenedorFunciones.TabIndex = 0;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCerrar.Location = new System.Drawing.Point(774, 0);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(22, 22);
            this.lblCerrar.TabIndex = 2;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_funcion,
            this.id_pelicula,
            this.horario,
            this.precio,
            this.id_lenguaje,
            this.id_sala});
            this.dgvFunciones.Location = new System.Drawing.Point(5, 69);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.Size = new System.Drawing.Size(794, 347);
            this.dgvFunciones.TabIndex = 1;
            // 
            // id_funcion
            // 
            this.id_funcion.HeaderText = "id_funcion";
            this.id_funcion.Name = "id_funcion";
            this.id_funcion.Visible = false;
            // 
            // id_pelicula
            // 
            this.id_pelicula.HeaderText = "Pelicula";
            this.id_pelicula.Name = "id_pelicula";
            // 
            // horario
            // 
            this.horario.HeaderText = "Horario";
            this.horario.Name = "horario";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // id_lenguaje
            // 
            this.id_lenguaje.HeaderText = "Lenguaje";
            this.id_lenguaje.Name = "id_lenguaje";
            // 
            // id_sala
            // 
            this.id_sala.HeaderText = "Sala";
            this.id_sala.Name = "id_sala";
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFunciones.Location = new System.Drawing.Point(336, 23);
            this.lblFunciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(93, 22);
            this.lblFunciones.TabIndex = 0;
            this.lblFunciones.Text = "Funciones";
            // 
            // FormFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 520);
            this.Controls.Add(this.panelContenedorFunciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFunciones";
            this.Text = "FormFunciones";
            this.Load += new System.EventHandler(this.FormFunciones_Load);
            this.panelContenedorFunciones.ResumeLayout(false);
            this.panelContenedorFunciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorFunciones;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lenguaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sala;
    }
}