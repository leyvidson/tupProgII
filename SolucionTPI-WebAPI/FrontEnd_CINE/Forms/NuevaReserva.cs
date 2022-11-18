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

        private IReservas app;

        public NuevaReserva()
        {
            InitializeComponent();
            oFabrica = new FabricaServicioImp();        //estas 2 lineas reemplazan a GESTOR
            oServicio = oFabrica.CrearServicio();       //             
            app = new ReservasDAO();
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
            CargarCombo(cboFuncion, "SP_CONSULTAR_FUNCION"); //Este SP esta trayendo mal la info! hay que hacer otro sp
            CargarCombo(cboCliente, "SP_CONSULTAR_CLIENTES");
            CargarCombo(cboPelicula, "SP_CONSULTAR_PELICULA");
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            
           
            DataRowView ItemCLient = (DataRowView)cboCliente.SelectedItem;
            Cliente c = new Cliente();
            c.Id_cliente = (int)ItemCLient.Row.ItemArray[0];
            c.Nombre = (string)ItemCLient.Row.ItemArray[1];
            
            DataRowView ItemFunci = (DataRowView)cboFuncion.SelectedItem;
            Funcion fun =  new Funcion();
            fun.Id_funcion = (int)ItemFunci.Row.ItemArray[0];
            
            
            DataRowView ItemPeli = (DataRowView)cboPelicula.SelectedItem;
            Pelicula p = new Pelicula();
            p.Id_pelicula = (int)ItemPeli.Row.ItemArray[0];
            p.Titulo = (string)ItemPeli.Row.ItemArray[1];
           
            Reserva r = new Reserva();
            r.Cliente = c;
            r.Funcion = fun;
            r.Pelicula = p;
            r.Cantidad = (int)nudCantidad.Value;
            r.FechaReserva = dtpFechaReser.Value;   
            
            if(app.EjecutarInsertReserva(r))
            {
                MessageBox.Show("Se genero una nueva reserva con exito!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR! No se pudo generar la reserva", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
