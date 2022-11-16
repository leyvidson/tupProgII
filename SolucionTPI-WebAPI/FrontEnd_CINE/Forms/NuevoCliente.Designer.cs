namespace FrontEnd_CINE.Forms
{
    partial class NuevoCliente
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
            this.panelContenedorNuevoCliente = new System.Windows.Forms.Panel();
            this.lblCerrarNuevoCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.dtpFec_Nac = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.panelContenedorNuevoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedorNuevoCliente
            // 
            this.panelContenedorNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContenedorNuevoCliente.CausesValidation = false;
            this.panelContenedorNuevoCliente.Controls.Add(this.lblCerrarNuevoCliente);
            this.panelContenedorNuevoCliente.Controls.Add(this.label3);
            this.panelContenedorNuevoCliente.Controls.Add(this.btnGuardarCliente);
            this.panelContenedorNuevoCliente.Controls.Add(this.dtpFec_Nac);
            this.panelContenedorNuevoCliente.Controls.Add(this.txtApellido);
            this.panelContenedorNuevoCliente.Controls.Add(this.txtNombre);
            this.panelContenedorNuevoCliente.Controls.Add(this.Apellido);
            this.panelContenedorNuevoCliente.Controls.Add(this.label2);
            this.panelContenedorNuevoCliente.Controls.Add(this.Nombre);
            this.panelContenedorNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelContenedorNuevoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorNuevoCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContenedorNuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorNuevoCliente.Name = "panelContenedorNuevoCliente";
            this.panelContenedorNuevoCliente.Size = new System.Drawing.Size(442, 397);
            this.panelContenedorNuevoCliente.TabIndex = 0;
            this.panelContenedorNuevoCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorNuevoCliente_Paint);
            // 
            // lblCerrarNuevoCliente
            // 
            this.lblCerrarNuevoCliente.AutoSize = true;
            this.lblCerrarNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarNuevoCliente.Location = new System.Drawing.Point(417, 0);
            this.lblCerrarNuevoCliente.Name = "lblCerrarNuevoCliente";
            this.lblCerrarNuevoCliente.Size = new System.Drawing.Size(22, 22);
            this.lblCerrarNuevoCliente.TabIndex = 9;
            this.lblCerrarNuevoCliente.Text = "X";
            this.lblCerrarNuevoCliente.Click += new System.EventHandler(this.lblCerrarNuevoCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nuevo Cliente";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCliente.FlatAppearance.BorderSize = 0;
            this.btnGuardarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Location = new System.Drawing.Point(12, 253);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(85, 36);
            this.btnGuardarCliente.TabIndex = 6;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // dtpFec_Nac
            // 
            this.dtpFec_Nac.Location = new System.Drawing.Point(140, 152);
            this.dtpFec_Nac.Name = "dtpFec_Nac";
            this.dtpFec_Nac.Size = new System.Drawing.Size(200, 20);
            this.dtpFec_Nac.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(140, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(53, 115);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(53, 72);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 397);
            this.Controls.Add(this.panelContenedorNuevoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.panelContenedorNuevoCliente.ResumeLayout(false);
            this.panelContenedorNuevoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.DateTimePicker dtpFec_Nac;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        public System.Windows.Forms.Panel panelContenedorNuevoCliente;
        private System.Windows.Forms.Label lblCerrarNuevoCliente;
    }
}