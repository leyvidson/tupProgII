namespace FrontEnd_CINE.Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.MenuLeft = new System.Windows.Forms.Panel();
            this.iconButtonConsultas = new FontAwesome.Sharp.IconButton();
            this.iconButtonInicio = new FontAwesome.Sharp.IconButton();
            this.iconButtonFunciones = new FontAwesome.Sharp.IconButton();
            this.iconButtonReservas = new FontAwesome.Sharp.IconButton();
            this.iconButtonClientes = new FontAwesome.Sharp.IconButton();
            this.iconButtonPeliculas = new FontAwesome.Sharp.IconButton();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.iconButtonRestaurar = new FontAwesome.Sharp.IconButton();
            this.iconButtonCerrar = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimizar = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaximizar = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.MenuLeft.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLeft
            // 
            this.MenuLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuLeft.Controls.Add(this.iconButtonConsultas);
            this.MenuLeft.Controls.Add(this.iconButtonInicio);
            this.MenuLeft.Controls.Add(this.iconButtonFunciones);
            this.MenuLeft.Controls.Add(this.iconButtonReservas);
            this.MenuLeft.Controls.Add(this.iconButtonClientes);
            this.MenuLeft.Controls.Add(this.iconButtonPeliculas);
            this.MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.MenuLeft.Name = "MenuLeft";
            this.MenuLeft.Size = new System.Drawing.Size(250, 640);
            this.MenuLeft.TabIndex = 0;
            // 
            // iconButtonConsultas
            // 
            this.iconButtonConsultas.FlatAppearance.BorderSize = 0;
            this.iconButtonConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonConsultas.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonConsultas.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.iconButtonConsultas.IconColor = System.Drawing.Color.White;
            this.iconButtonConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConsultas.Location = new System.Drawing.Point(0, 452);
            this.iconButtonConsultas.Name = "iconButtonConsultas";
            this.iconButtonConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonConsultas.Size = new System.Drawing.Size(244, 46);
            this.iconButtonConsultas.TabIndex = 11;
            this.iconButtonConsultas.Text = "Consultas";
            this.iconButtonConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonConsultas.UseVisualStyleBackColor = true;
            this.iconButtonConsultas.Click += new System.EventHandler(this.iconButtonConsultas_Click);
            // 
            // iconButtonInicio
            // 
            this.iconButtonInicio.FlatAppearance.BorderSize = 0;
            this.iconButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonInicio.IconColor = System.Drawing.Color.White;
            this.iconButtonInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInicio.Location = new System.Drawing.Point(0, 0);
            this.iconButtonInicio.Name = "iconButtonInicio";
            this.iconButtonInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonInicio.Size = new System.Drawing.Size(250, 46);
            this.iconButtonInicio.TabIndex = 10;
            this.iconButtonInicio.Text = "Inicio CINE";
            this.iconButtonInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonInicio.UseVisualStyleBackColor = true;
            this.iconButtonInicio.Click += new System.EventHandler(this.iconButtonInicio_Click);
            // 
            // iconButtonFunciones
            // 
            this.iconButtonFunciones.FlatAppearance.BorderSize = 0;
            this.iconButtonFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonFunciones.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonFunciones.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconButtonFunciones.IconColor = System.Drawing.Color.White;
            this.iconButtonFunciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFunciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFunciones.Location = new System.Drawing.Point(0, 382);
            this.iconButtonFunciones.Name = "iconButtonFunciones";
            this.iconButtonFunciones.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonFunciones.Size = new System.Drawing.Size(250, 46);
            this.iconButtonFunciones.TabIndex = 9;
            this.iconButtonFunciones.Text = "Funciones";
            this.iconButtonFunciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFunciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFunciones.UseVisualStyleBackColor = true;
            this.iconButtonFunciones.Click += new System.EventHandler(this.iconButtonFunciones_Click);
            // 
            // iconButtonReservas
            // 
            this.iconButtonReservas.FlatAppearance.BorderSize = 0;
            this.iconButtonReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReservas.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonReservas.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.iconButtonReservas.IconColor = System.Drawing.Color.White;
            this.iconButtonReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReservas.Location = new System.Drawing.Point(0, 312);
            this.iconButtonReservas.Name = "iconButtonReservas";
            this.iconButtonReservas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonReservas.Size = new System.Drawing.Size(250, 46);
            this.iconButtonReservas.TabIndex = 8;
            this.iconButtonReservas.Text = "Reservas";
            this.iconButtonReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReservas.UseVisualStyleBackColor = true;
            this.iconButtonReservas.Click += new System.EventHandler(this.iconButtonReservas_Click);
            // 
            // iconButtonClientes
            // 
            this.iconButtonClientes.FlatAppearance.BorderSize = 0;
            this.iconButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonClientes.IconColor = System.Drawing.Color.White;
            this.iconButtonClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClientes.Location = new System.Drawing.Point(0, 242);
            this.iconButtonClientes.Name = "iconButtonClientes";
            this.iconButtonClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonClientes.Size = new System.Drawing.Size(250, 46);
            this.iconButtonClientes.TabIndex = 7;
            this.iconButtonClientes.Text = "Clientes";
            this.iconButtonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClientes.UseVisualStyleBackColor = true;
            this.iconButtonClientes.Click += new System.EventHandler(this.iconButtonClientes_Click);
            // 
            // iconButtonPeliculas
            // 
            this.iconButtonPeliculas.FlatAppearance.BorderSize = 0;
            this.iconButtonPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPeliculas.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonPeliculas.IconChar = FontAwesome.Sharp.IconChar.Clapperboard;
            this.iconButtonPeliculas.IconColor = System.Drawing.Color.White;
            this.iconButtonPeliculas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPeliculas.Location = new System.Drawing.Point(0, 172);
            this.iconButtonPeliculas.Name = "iconButtonPeliculas";
            this.iconButtonPeliculas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPeliculas.Size = new System.Drawing.Size(250, 46);
            this.iconButtonPeliculas.TabIndex = 6;
            this.iconButtonPeliculas.Text = "Peliculas";
            this.iconButtonPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPeliculas.UseVisualStyleBackColor = true;
            this.iconButtonPeliculas.Click += new System.EventHandler(this.iconButtonPeliculas_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Transparent;
            this.MenuVertical.Controls.Add(this.iconButtonRestaurar);
            this.MenuVertical.Controls.Add(this.iconButtonCerrar);
            this.MenuVertical.Controls.Add(this.iconButtonMinimizar);
            this.MenuVertical.Controls.Add(this.iconButtonMaximizar);
            this.MenuVertical.Controls.Add(this.iconButtonMenu);
            this.MenuVertical.Controls.Add(this.btnRestaurar);
            this.MenuVertical.Controls.Add(this.btnMinimizar);
            this.MenuVertical.Controls.Add(this.btnMaximizar);
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuVertical.Location = new System.Drawing.Point(250, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(785, 56);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // iconButtonRestaurar
            // 
            this.iconButtonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRestaurar.FlatAppearance.BorderSize = 0;
            this.iconButtonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRestaurar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButtonRestaurar.IconColor = System.Drawing.Color.Black;
            this.iconButtonRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRestaurar.IconSize = 20;
            this.iconButtonRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRestaurar.Location = new System.Drawing.Point(724, 0);
            this.iconButtonRestaurar.Name = "iconButtonRestaurar";
            this.iconButtonRestaurar.Size = new System.Drawing.Size(32, 36);
            this.iconButtonRestaurar.TabIndex = 14;
            this.iconButtonRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRestaurar.UseVisualStyleBackColor = true;
            this.iconButtonRestaurar.Click += new System.EventHandler(this.iconButtonRestaurar_Click);
            // 
            // iconButtonCerrar
            // 
            this.iconButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCerrar.FlatAppearance.BorderSize = 0;
            this.iconButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonCerrar.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButtonCerrar.IconColor = System.Drawing.Color.Black;
            this.iconButtonCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCerrar.IconSize = 20;
            this.iconButtonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCerrar.Location = new System.Drawing.Point(753, 0);
            this.iconButtonCerrar.Name = "iconButtonCerrar";
            this.iconButtonCerrar.Size = new System.Drawing.Size(32, 36);
            this.iconButtonCerrar.TabIndex = 13;
            this.iconButtonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCerrar.UseVisualStyleBackColor = true;
            this.iconButtonCerrar.Click += new System.EventHandler(this.iconButtonCerrar_Click);
            // 
            // iconButtonMinimizar
            // 
            this.iconButtonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimizar.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonMinimizar.IconColor = System.Drawing.Color.Black;
            this.iconButtonMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinimizar.IconSize = 20;
            this.iconButtonMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMinimizar.Location = new System.Drawing.Point(695, 0);
            this.iconButtonMinimizar.Name = "iconButtonMinimizar";
            this.iconButtonMinimizar.Size = new System.Drawing.Size(32, 36);
            this.iconButtonMinimizar.TabIndex = 12;
            this.iconButtonMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMinimizar.UseVisualStyleBackColor = true;
            this.iconButtonMinimizar.Click += new System.EventHandler(this.iconButtonMinimizar_Click);
            // 
            // iconButtonMaximizar
            // 
            this.iconButtonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMaximizar.FlatAppearance.BorderSize = 0;
            this.iconButtonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaximizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMaximizar.IconColor = System.Drawing.Color.Black;
            this.iconButtonMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaximizar.IconSize = 20;
            this.iconButtonMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaximizar.Location = new System.Drawing.Point(724, 0);
            this.iconButtonMaximizar.Name = "iconButtonMaximizar";
            this.iconButtonMaximizar.Size = new System.Drawing.Size(32, 36);
            this.iconButtonMaximizar.TabIndex = 11;
            this.iconButtonMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMaximizar.UseVisualStyleBackColor = true;
            this.iconButtonMaximizar.Click += new System.EventHandler(this.iconButtonMaximizar_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButtonMenu.IconColor = System.Drawing.Color.Black;
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 0);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Size = new System.Drawing.Size(63, 56);
            this.iconButtonMenu.TabIndex = 10;
            this.iconButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(993, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(23, 23);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(963, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(993, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1022, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 23);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelContenedor.BackgroundImage")));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 56);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(785, 584);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Click += new System.EventHandler(this.btnDesplegar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.MenuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.MenuLeft.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuLeft;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton iconButtonFunciones;
        private FontAwesome.Sharp.IconButton iconButtonReservas;
        private FontAwesome.Sharp.IconButton iconButtonClientes;
        private FontAwesome.Sharp.IconButton iconButtonPeliculas;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private FontAwesome.Sharp.IconButton iconButtonInicio;
        private FontAwesome.Sharp.IconButton iconButtonConsultas;
        private FontAwesome.Sharp.IconButton iconButtonRestaurar;
        private FontAwesome.Sharp.IconButton iconButtonCerrar;
        private FontAwesome.Sharp.IconButton iconButtonMinimizar;
        private FontAwesome.Sharp.IconButton iconButtonMaximizar;
    }
}

