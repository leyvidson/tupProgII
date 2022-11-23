using FrontEnd_CINE.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyCINE_01.Reportes
{
    public partial class MostrarReporte : Form
    {
        public MostrarReporte()
        {
            InitializeComponent();
        }
        public int Id_ticket { get; set; }
        private void MostrarReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.p_imprimir_ticket' Puede moverla o quitarla según sea necesario.
            this.p_imprimir_ticketTableAdapter.Fill(this.dataSetPrincipal.p_imprimir_ticket,Id_ticket);    
            //rvReporte.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            //this.reportViewer1.RefreshReport();

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MostrarReporte
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MostrarReporte";
            this.ResumeLayout(false);

        }
    }
}
