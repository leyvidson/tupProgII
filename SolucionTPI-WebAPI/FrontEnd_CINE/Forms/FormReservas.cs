using AplicacionCINE.Entidades;
//using FrontEnd_CINE.Reportes;
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
    public partial class FormReservas : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;


        List<Reserva> lReservas;
        public FormReservas()
        {
            InitializeComponent();
            oFabrica = new FabricaServicioImp();    //Agregado nuevo
            oServicio = oFabrica.CrearServicio();   //estas 2 lineas reemplazan a GESTOR                  
            lReservas = new List<Reserva>();
            //cargarDGV();
        }

        private async void FormReservas_Load(object sender, EventArgs e)
        {
            await ConsultarReservas();
        }


        private async Task ConsultarReservas()
        {
            string URL = "https://localhost:7295/api/CINE";

            var result = await ClientSingleton.GetInstance().GetAsync(URL);
            List<Reserva> lReserva = new List<Reserva>();
            lReserva = JsonConvert.DeserializeObject<List<Reserva>>(result);
            
            foreach (Reserva r in lReserva)
            {
                dgvReserva.Rows.Add(new object[]
                {
                        r.Id_reserva,
                        r.id_Funcion,
                        r.cliente,
                        r.pelicula,
                        r.FechaReserva,
                        r.Cantidad
                });
            }
        }

        private void lblCerrar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDGV()
        {
            DataTable tabla = oServicio.ConsultarDB("SP_CONSULTAR_RESERVA");
            foreach (DataRow fila in tabla.Rows)
            {
                Reserva Reser = new Reserva();

                Reser.Id_reserva = (int)(fila["id_reserva"]);

                //Reser.Funcion.Descripcion = (fila["descripcion"].ToString());  <<<< antess
                Reser.id_Funcion = (int)fila["id_funcion"];

                //Reser.Cliente.Nombre = (string)(fila["nombreC"]);       <<<<<<<< antes
                Reser.cliente = (string)(fila["Cliente"]);

                //Reser.Pelicula.Titulo = (string)(fila["titulo"]);       <<<<<<< antes
                Reser.pelicula = (string)(fila["titulo"]);

                Reser.FechaReserva = Convert.ToDateTime(fila["fecha"]);
                Reser.Cantidad = (int)(fila["cantidad"]);

                lReservas.Add(Reser);
            }
            dgvReserva.Rows.Clear();
            foreach (Reserva Reser in lReservas)
            {
                dgvReserva.Rows.Add(new object[] { Reser.Id_reserva, Reser.id_Funcion,
                                                  Reser.cliente, Reser.pelicula,
                                                  Reser.FechaReserva, Reser.Cantidad});
            }

        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedorReservas.Controls.Count > 0)
            {
                this.panelContenedorReservas.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorReservas.Controls.Add(fh);
            this.panelContenedorReservas.Tag = fh;
            fh.Show();

        }
        private void btnNueva_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new NuevaReserva());
            dgvReserva.Dispose();
            btnNueva.Dispose();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReserva.CurrentCell.ColumnIndex == 6)
            {
                //aca mandamos a imprimir el ticket
                //MostrarReporte mostrar = new MostrarReporte();
                //mostrar.Id_ticket = dgvReserva.CurrentCell.ColumnIndex;

                //mostrar.ShowDialog();

                //este id se lo tengo q enviar al FormReporte                

            }
        }

       

    }
}
