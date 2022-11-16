namespace FrontEnd_CINE.Forms
{
    partial class FormPelicula
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
            this.lblPelicula = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.id_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacion_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apto_publico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitulos_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_estreno_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContenedorPeliculas = new System.Windows.Forms.Panel();
            this.CerrarLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.panelContenedorPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(282, 21);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(82, 22);
            this.lblPelicula.TabIndex = 0;
            this.lblPelicula.Text = "Peliculas";
            // 
            // btnNueva
            // 
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.Black;
            this.btnNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNueva.Location = new System.Drawing.Point(0, 342);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNueva.Size = new System.Drawing.Size(121, 55);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva   ";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNuevaPeli_Click);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(654, 21);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(22, 22);
            this.lblCerrar.TabIndex = 2;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pelicula,
            this.titulo_pelicula,
            this.duracion_pelicula,
            this.calificacion_pelicula,
            this.apto_publico,
            this.subtitulos_pelicula,
            this.fec_estreno_pelicula,
            this.genero_pelicula});
            this.dgvPeliculas.Location = new System.Drawing.Point(0, 56);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(716, 289);
            this.dgvPeliculas.TabIndex = 3;
            this.dgvPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellContentClick);
            // 
            // id_pelicula
            // 
            this.id_pelicula.HeaderText = "id_pelicula";
            this.id_pelicula.Name = "id_pelicula";
            this.id_pelicula.Visible = false;
            // 
            // titulo_pelicula
            // 
            this.titulo_pelicula.HeaderText = "Titulo";
            this.titulo_pelicula.Name = "titulo_pelicula";
            this.titulo_pelicula.Width = 250;
            // 
            // duracion_pelicula
            // 
            this.duracion_pelicula.HeaderText = "Duracion";
            this.duracion_pelicula.Name = "duracion_pelicula";
            this.duracion_pelicula.Width = 60;
            // 
            // calificacion_pelicula
            // 
            this.calificacion_pelicula.HeaderText = "Calificacion";
            this.calificacion_pelicula.Name = "calificacion_pelicula";
            this.calificacion_pelicula.Width = 70;
            // 
            // apto_publico
            // 
            this.apto_publico.HeaderText = "+18";
            this.apto_publico.Name = "apto_publico";
            this.apto_publico.Width = 40;
            // 
            // subtitulos_pelicula
            // 
            this.subtitulos_pelicula.HeaderText = "Subtitulos";
            this.subtitulos_pelicula.Name = "subtitulos_pelicula";
            this.subtitulos_pelicula.Width = 60;
            // 
            // fec_estreno_pelicula
            // 
            this.fec_estreno_pelicula.HeaderText = "Estreno";
            this.fec_estreno_pelicula.Name = "fec_estreno_pelicula";
            this.fec_estreno_pelicula.Width = 60;
            // 
            // genero_pelicula
            // 
            this.genero_pelicula.HeaderText = "Genero";
            this.genero_pelicula.Name = "genero_pelicula";
            // 
            // panelContenedorPeliculas
            // 
            this.panelContenedorPeliculas.Controls.Add(this.CerrarLbl);
            this.panelContenedorPeliculas.Controls.Add(this.dgvPeliculas);
            this.panelContenedorPeliculas.Controls.Add(this.btnNueva);
            this.panelContenedorPeliculas.Controls.Add(this.lblPelicula);
            this.panelContenedorPeliculas.Location = new System.Drawing.Point(2, 0);
            this.panelContenedorPeliculas.Name = "panelContenedorPeliculas";
            this.panelContenedorPeliculas.Size = new System.Drawing.Size(716, 421);
            this.panelContenedorPeliculas.TabIndex = 4;
            this.panelContenedorPeliculas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorPeliculas_Paint);
            // 
            // CerrarLbl
            // 
            this.CerrarLbl.AutoSize = true;
            this.CerrarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarLbl.Location = new System.Drawing.Point(691, 9);
            this.CerrarLbl.Name = "CerrarLbl";
            this.CerrarLbl.Size = new System.Drawing.Size(22, 22);
            this.CerrarLbl.TabIndex = 4;
            this.CerrarLbl.Text = "X";
            this.CerrarLbl.Click += new System.EventHandler(this.CerrarLbl_Click);
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(718, 454);
            this.Controls.Add(this.panelContenedorPeliculas);
            this.Controls.Add(this.lblCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPelicula";
            this.Text = "Pelicula";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.panelContenedorPeliculas.ResumeLayout(false);
            this.panelContenedorPeliculas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacion_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn apto_publico;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtitulos_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_estreno_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero_pelicula;
        private System.Windows.Forms.Panel panelContenedorPeliculas;
        private System.Windows.Forms.Label CerrarLbl;
    }
}