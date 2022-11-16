namespace FrontEnd_CINE.Forms
{
    partial class FormConsultas
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
            this.panelContenedorConsultas = new System.Windows.Forms.Panel();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.cmbConsultas = new System.Windows.Forms.ComboBox();
            this.lblCerrarConsultas = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.panelContenedorConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorConsultas
            // 
            this.panelContenedorConsultas.Controls.Add(this.lblEnunciado);
            this.panelContenedorConsultas.Controls.Add(this.label1);
            this.panelContenedorConsultas.Controls.Add(this.dgvConsultas);
            this.panelContenedorConsultas.Controls.Add(this.cmbConsultas);
            this.panelContenedorConsultas.Controls.Add(this.lblCerrarConsultas);
            this.panelContenedorConsultas.Controls.Add(this.lblConsultas);
            this.panelContenedorConsultas.Location = new System.Drawing.Point(1, 2);
            this.panelContenedorConsultas.Name = "panelContenedorConsultas";
            this.panelContenedorConsultas.Size = new System.Drawing.Size(784, 448);
            this.panelContenedorConsultas.TabIndex = 0;
            this.panelContenedorConsultas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorConsultas_Paint);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(156, 179);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(356, 188);
            this.dgvConsultas.TabIndex = 3;
            // 
            // cmbConsultas
            // 
            this.cmbConsultas.FormattingEnabled = true;
            this.cmbConsultas.Items.AddRange(new object[] {
            "Consulta 1",
            "Consulta 2",
            "Consulta 3"});
            this.cmbConsultas.Location = new System.Drawing.Point(98, 70);
            this.cmbConsultas.Name = "cmbConsultas";
            this.cmbConsultas.Size = new System.Drawing.Size(121, 21);
            this.cmbConsultas.TabIndex = 2;
            this.cmbConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbConsultas_SelectedIndexChanged);
            // 
            // lblCerrarConsultas
            // 
            this.lblCerrarConsultas.AutoSize = true;
            this.lblCerrarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCerrarConsultas.Location = new System.Drawing.Point(759, 0);
            this.lblCerrarConsultas.Name = "lblCerrarConsultas";
            this.lblCerrarConsultas.Size = new System.Drawing.Size(22, 22);
            this.lblCerrarConsultas.TabIndex = 1;
            this.lblCerrarConsultas.Text = "X";
            this.lblCerrarConsultas.Click += new System.EventHandler(this.lblCerrarConsultas_Click);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblConsultas.Location = new System.Drawing.Point(297, 36);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(90, 22);
            this.lblConsultas.TabIndex = 0;
            this.lblConsultas.Text = "Consultas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consulta";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(11, 116);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(49, 22);
            this.lblEnunciado.TabIndex = 6;
            this.lblEnunciado.Text = "texto";
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.panelContenedorConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultas";
            this.Text = "Consultas";
            this.panelContenedorConsultas.ResumeLayout(false);
            this.panelContenedorConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorConsultas;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Label lblCerrarConsultas;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.ComboBox cmbConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnunciado;
    }
}