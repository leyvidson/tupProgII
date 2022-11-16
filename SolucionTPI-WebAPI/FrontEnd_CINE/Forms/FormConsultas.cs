using AplicacionCINE.Servicios.Interfaz;
using AplicacionCINE.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd_CINE.Forms
{
    public partial class FormConsultas : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;
        
        public FormConsultas()
        {
            InitializeComponent();            
            oFabrica = new FabricaServicioImp();    //Agregado nuevo
            oServicio = oFabrica.CrearServicio();
            lblEnunciado.Text = string.Empty;
        }

        


        private void lblCerrarConsultas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsultas.Text.Equals("Consulta 1"))
            {
                lblEnunciado.Text = "Se muestra la pelicula cuyo promedio actual de recaudacion es mayor a la del mes anterior";
                dgvConsultas.DataSource = oServicio.ConsultarDB("sp_peli_prom_mes_actual_mayor_mes_anterior");
            }
            if (cmbConsultas.Text.Equals("Consulta 2"))
            {
                lblEnunciado.Text = "Se muestra el Cliente que asistio mas de dos veces este año";
                dgvConsultas.DataSource = oServicio.ConsultarDB("sp_cli_mas_dos_veces_anio_actual");
            }
            if (cmbConsultas.Text.Equals("Consulta 3"))
            {
                lblEnunciado.Text = "Muestra datos si el ingreso del año en curso es mayor al ingreso del año pasado ";
                dgvConsultas.DataSource = oServicio.ConsultarDB("sp_ingresos_mensuales_mayor_anio_pasado");
            }


        }

        private void panelContenedorConsultas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
