using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionCINE.Datos;
using AplicacionCINE.Entidades;
using AplicacionCINE.Servicios;
using AplicacionCINE.Servicios.Interfaz;

namespace FrontEnd_CINE.Forms
{
    public partial class FormPelicula : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;
       
        List<Pelicula> lPeliculas;

        public FormPelicula()
        {
            InitializeComponent();
            
            oFabrica = new FabricaServicioImp();    //Agregado nuevo
            oServicio = oFabrica.CrearServicio();   //estas 2 lineas reemplazan a GESTOR
            
            lPeliculas = new List<Pelicula>();
            cargarDGV();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Pelicula_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarDGV()
        {

            DataTable tabla = oServicio.ConsultarDB("SP_CONSULTAR_PELICULA");
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula Peli = new Pelicula();

                Peli.Id_pelicula = (int)(fila["id_pelicula"]);
                Peli.Titulo = fila["titulo"].ToString();
                Peli.Duracion = (decimal)fila["duracion"];
                
                Peli.calificacion = (string)fila["calificacion"];
                //Peli.calificacion.Descripcion = fila["calificacion"].ToString();                
                
                Peli.Apto_toto_publico = Convert.ToBoolean(fila["apto_para_todo_publico"]);
                Peli.Subtitulo = Convert.ToBoolean(fila["subtitulos"]);
                Peli.Fecha_estreno = Convert.ToDateTime(fila["fecha_de_estreno"]);
                
                Peli.genero = (string)fila["genero"];
               //Peli.genero.Descripcion = fila["genero"].ToString();

                lPeliculas.Add(Peli);
            }
            dgvPeliculas.Rows.Clear();
            foreach (Pelicula Peli in lPeliculas)
            {
                dgvPeliculas.Rows.Add(new object[] { Peli.Id_pelicula, Peli.Titulo, Peli.Duracion, Peli.calificacion,
                                                Peli.Apto_toto_publico, Peli.Subtitulo, Peli.Fecha_estreno, Peli.genero});
            }
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedorPeliculas.Controls.Count > 0)
            {
                this.panelContenedorPeliculas.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorPeliculas.Controls.Add(fh);
            this.panelContenedorPeliculas.Tag = fh;
            fh.Show();

        }    

        private void btnNueva_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new NuevaPelicula());
            btnNueva.Visible = false;
        }

        private void panelContenedorPeliculas_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaPeli_Click(object sender, EventArgs e)
        {
            CerrarLbl.Visible = false;
            lblPelicula.Visible = false;
            dgvPeliculas.Dispose();
            btnNueva.Visible = false;
            AbrirFormInPanel(new NuevaPelicula());
        }

        private void CerrarLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
