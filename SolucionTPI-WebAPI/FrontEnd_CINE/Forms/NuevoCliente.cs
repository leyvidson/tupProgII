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
    public partial class NuevoCliente : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        public NuevoCliente()
        {
            InitializeComponent();
            
            oFabrica = new FabricaServicioImp();    //Agregado nuevo
            oServicio = oFabrica.CrearServicio();
            
        }

        private bool Valido()
        {
            bool x = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                x = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                x = false;
            }
            if (((DateTime.Today.Year) - (dtpFec_Nac.Value.Year)) <= 10)
            {
                MessageBox.Show("El cliente debe ser mayor a 10 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                x = false;
            }          
            return x;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Fecha_nacimiento = Convert.ToDateTime(dtpFec_Nac.Text);

                if (oServicio.EjecutarInsert(cliente))
                {
                    MessageBox.Show("Se inserto correctame una nuevo Cliente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo insertar una nuevo Cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblCerrarNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContenedorNuevoCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
