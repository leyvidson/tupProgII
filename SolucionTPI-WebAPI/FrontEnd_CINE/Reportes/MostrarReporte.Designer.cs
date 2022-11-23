namespace FrontEnd_CINE.Reportes
{
    partial class MostrarReporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pimprimirticketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal = new FrontEnd_CINE.Reportes.DataSetPrincipal();
            this.p_imprimir_ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pimprimirticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pimprimirticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pimprimirticketBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.p_imprimir_ticketTableAdapter = new FrontEnd_CINE.Reportes.DataSetPrincipalTableAdapters.p_imprimir_ticketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_imprimir_ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pimprimirticketBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd_CINE.Reportes.ReporteTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pimprimirticketBindingSource2
            // 
            this.pimprimirticketBindingSource2.DataMember = "p_imprimir_ticket";
            this.pimprimirticketBindingSource2.DataSource = this.dataSetPrincipal;
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_imprimir_ticketBindingSource
            // 
            this.p_imprimir_ticketBindingSource.DataMember = "p_imprimir_ticket";
            this.p_imprimir_ticketBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // pimprimirticketBindingSource1
            // 
            this.pimprimirticketBindingSource1.DataMember = "p_imprimir_ticket";
            this.pimprimirticketBindingSource1.DataSource = this.dataSetPrincipal;
            // 
            // pimprimirticketBindingSource
            // 
            this.pimprimirticketBindingSource.DataMember = "p_imprimir_ticket";
            this.pimprimirticketBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // pimprimirticketBindingSource3
            // 
            this.pimprimirticketBindingSource3.DataMember = "p_imprimir_ticket";
            this.pimprimirticketBindingSource3.DataSource = this.dataSetPrincipal;
            // 
            // p_imprimir_ticketTableAdapter
            // 
            this.p_imprimir_ticketTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarReporte";
            this.Text = "MostrarReporte";
            this.Load += new System.EventHandler(this.MostrarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_imprimir_ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pimprimirticketBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pimprimirticketBindingSource;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource pimprimirticketBindingSource1;
        private System.Windows.Forms.BindingSource p_imprimir_ticketBindingSource;
        private System.Windows.Forms.BindingSource pimprimirticketBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pimprimirticketBindingSource3;
        private FrontEnd_CINE.Reportes.DataSetPrincipalTableAdapters.p_imprimir_ticketTableAdapter p_imprimir_ticketTableAdapter;
    }
}