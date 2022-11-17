using AplicacionCINE.Datos;
using AplicacionCINE.Entidades;
using AplicacionCINE.Servicios;
using AplicacionCINE.Servicios.Interfaz;
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
    public partial class NuevaReserva : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

       

        public NuevaReserva()
        {
            InitializeComponent();
            oFabrica = new FabricaServicioImp();        //estas 2 lineas reemplazan a GESTOR
            oServicio = oFabrica.CrearServicio();       //             
        }
        private void CargarCombo(ComboBox Combo, string SP)
        {
            DataTable tabla = oServicio.ConsultarDB(SP);
            Combo.DataSource = tabla;
            Combo.ValueMember = tabla.Columns[0].ColumnName;
            Combo.DisplayMember = tabla.Columns[1].ColumnName;
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaResrva_Load(object sender, EventArgs e)
        {
            
        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {            
            btnGuardarNuevaReserva.Enabled = true;
            CargarCombo(cboFuncion, "SP_CONSULTAR_FUNCION");
            CargarCombo(cboCliente, "SP_CONSULTAR_CLIENTES");
            CargarCombo(cboPelicula, "SP_CONSULTAR_PELICULA");
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            //Reserva r = new Reserva();
            //DataRowView ItemCLient = (DataRowView)cboCliente.SelectedItem;
            //r.id_pelicula = (int)ItemCLient.Row.ItemArray[0];
            
            //DataRowView ItemFunci = (DataRowView)cboFuncion.SelectedItem;
            //r.id_Funcion = (DataRowView)ItemFunci.Row.ItemArray[0];
          
            //DataRowView ItemPeli = (DataRowView)cboPelicula.SelectedItem;
            //r.
            //     oServicio.EjecutarInsert(reserva);
        }
    }
}
