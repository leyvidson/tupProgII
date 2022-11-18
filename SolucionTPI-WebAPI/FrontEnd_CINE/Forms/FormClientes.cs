using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionCINE.Entidades;
using AplicacionCINE.Servicios.Interfaz;
using AplicacionCINE.Servicios;
using FrontEnd_CINE.Http;
using Newtonsoft.Json;
using AplicacionCINE.Datos;

namespace FrontEnd_CINE.Forms
{
    public partial class FormClientes : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        private Cliente cliente;
        List<Cliente> lClientes;      

        public FormClientes()
        {
            InitializeComponent();

            oFabrica = new FabricaServicioImp();        //estas 2 lineas reemplazan a GESTOR
            oServicio = oFabrica.CrearServicio();
            cliente = new Cliente();
            lClientes = new List<Cliente>();
        }

        private async void FormClientes_Load(object sender, EventArgs e)
        {
            await ObtenerClientes();
            lblNvoNombre.Visible = false;
            txtNvoNombre.Visible = false;
            btnGuardar.Visible = false;
        }

        private async Task ObtenerClientes()
        {
            string URL = "https://localhost:7295/api/CINE/Clientes";
            var result = await ClientSingleton.GetInstance().GetAsync(URL);
            var lClientes = JsonConvert.DeserializeObject<List<Cliente>>(result);

            foreach (Cliente cliente in lClientes)
            {
                dgvClientes.Rows.Add(new object[]
                {
                        cliente.Id_cliente,
                        cliente.Nombre,
                        cliente.Apellido,
                        cliente.Fecha_nacimiento.ToString("dd/MM/yyyy")
                });
            }
        }


        private void AgregarClientes() // Este no se esta usando ahora!...... LEO
        {
            DataTable tabla = oServicio.ConsultarDB("SP_CONSULTAR_CLIENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente cl = new Cliente();

                cl.Id_cliente = (int)(fila["id_cliente"]);
                cl.Nombre = fila["nombre"].ToString();
                cl.Apellido = fila["apellido"].ToString();
                cl.Fecha_nacimiento = Convert.ToDateTime(fila["fec_nac"]);

                lClientes.Add(cl);
            }
            dgvClientes.Rows.Clear();
            foreach (Cliente cl in lClientes)
            {
                dgvClientes.Rows.Add(new object[] { cl.Id_cliente, cl.Nombre, cl.Apellido, cl.Fecha_nacimiento });
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedorClientes.Controls.Count > 0)
            {
                this.panelContenedorClientes.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorClientes.Controls.Add(fh);
            this.panelContenedorClientes.Tag = fh;
            fh.Show();
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            lblCerrarClientes.Visible = false;
            lblClientes.Visible = false;
            dgvClientes.Dispose();
            btnNuevoCliente.Visible = false;
            AbrirFormInPanel(new NuevoCliente());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            lblNvoNombre.Visible = true;
            txtNvoNombre.Visible = true;
            btnGuardar.Visible = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNvoNombre.Text))
            {
                int id = (dgvClientes.CurrentCell.RowIndex) + 1;
                string nomNvo = txtNvoNombre.Text;
                if (oServicio.EjecutarUpdateCliente(id, nomNvo))
                {
                    MessageBox.Show("Se actualizo con exito", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe compretar con un nombre", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNvoNombre.Focus();
            }
        }
        public void limpiar()
        {
            txtNvoNombre.Clear();
            dgvClientes.Refresh();
        }
    }
}
