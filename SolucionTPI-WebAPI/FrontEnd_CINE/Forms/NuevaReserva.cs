using AplicacionCINE.Datos;
using AplicacionCINE.Entidades;
using AplicacionCINE.Servicios;
using AplicacionCINE.Servicios.Interfaz;
using FrontEnd_CINE.Http;
using Newtonsoft.Json;
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

        private async void NuevaReserva_Load(object sender, EventArgs e)
        {            
            CargarCombo(cboCliente, "SP_CONSULTAR_CLIENTES");            
            await ObtenerFuncionxReservas();
        }

        private async Task ObtenerFuncionxReservas()
        {
            string URL = "https://localhost:7295/api/CINE/Funciones";

            var result = await ClientSingleton.GetInstance().GetAsync(URL);
            var lfuncion = JsonConvert.DeserializeObject<List<Funcion>>(result);

            foreach (Funcion Func in lfuncion)
            {
                dgvFuncionReserva.Rows.Add(new object[]
                {
                        Func.Id_funcion, Func.Pelicula.Id_pelicula, Func.Pelicula.Titulo,
                        Func.Precio, Func.Sala.Id_sala
                });
            }
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            
           
            DataRowView ItemCLient = (DataRowView)cboCliente.SelectedItem;
            Cliente c = new Cliente();
            c.Id_cliente = (int)ItemCLient.Row.ItemArray[0];
            c.Nombre = (string)ItemCLient.Row.ItemArray[1];
            
                                
           
            Reserva r = new Reserva();
            r.Cliente = c;
            //r.Funcion.Id_funcion = null;
           // r.Pelicula.Id_pelicula = null
            r.Cantidad = (int)nudCantidad.Value;
            r.FechaReserva = dtpFechaReser.Value;   
            
            if(oServicio.EjecutarInsertReserva(r))
            {
                MessageBox.Show("Se genero una nueva reserva con exito!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR! No se pudo generar la reserva", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
