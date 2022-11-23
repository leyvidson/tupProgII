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
    public partial class NuevaPelicula : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        public NuevaPelicula()
        {
            InitializeComponent();
            
            oFabrica = new FabricaServicioImp();    //Agregado nuevo
            oServicio = oFabrica.CrearServicio();   //estas 2 lineas reemplazan a GESTOR
            
        }

        private void CargarCombo(ComboBox Combo, string SP)
        {
            DataTable tabla = oServicio.ConsultarDB(SP);
            Combo.DataSource = tabla;
            Combo.ValueMember = tabla.Columns[0].ColumnName;
            Combo.DisplayMember = tabla.Columns[1].ToString();
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaPelicula_Load(object sender, EventArgs e)
        {
            btnGuardarPelicula.Enabled = true;
            CargarCombo(cbCalificacion, "SP_CONSULTAR_CALIFICACIONES");
            CargarCombo(cbActorPrincipal, "SP_CONSULTAR_ACTORES");
            CargarCombo(cbOrigen, "SP_CONSULTAR_ORIGENES");
            CargarCombo(cbGenero, "SP_CONSULTAR_GENEROS");
        }

        private void btnGuardarPelicula_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                DataRowView CboCalif = (DataRowView)(cbCalificacion.SelectedItem);
                int Idcal = Convert.ToInt32(CboCalif.Row.ItemArray[0]);
                string DescCal = Convert.ToString(CboCalif.Row.ItemArray[1]);
                Calificacion calif = new Calificacion(Idcal, DescCal);              //Instanciamos Calificacion

                DataRowView CboActor = (DataRowView)(cbActorPrincipal.SelectedItem);
                int IdAct = Convert.ToInt32(CboActor.Row.ItemArray[0]);
                string ActNombApell = Convert.ToString(CboActor.Row.ItemArray[1]);
                ActorPrincipal actor = new ActorPrincipal(IdAct, ActNombApell);    //Instanciamos ActorPrincipal

                DataRowView CboOrigen = (DataRowView)(cbOrigen.SelectedItem);
                int idOrig = Convert.ToInt32(CboOrigen.Row.ItemArray[0]);
                string DescOrg = Convert.ToString(CboOrigen.Row.ItemArray[1]);
                Origen origen = new Origen(idOrig, DescOrg);                     //Instanciamos Origen

                DataRowView CboGenero = (DataRowView)(cbGenero.SelectedItem);
                int IdGen = Convert.ToInt32(CboGenero.Row.ItemArray[0]);
                string DescGen = Convert.ToString(CboGenero.Row.ItemArray[1]);
                Genero gen = new Genero(IdGen, DescGen);                       //Instanciamos Genero

                string ti = txtTitulo.Text;
                decimal du = 180.5M;
                DateTime fe = dtpEstreno.Value;

                bool sub = cbSubtitulos.Checked;
                bool apto = cbAptoTodoPublico.Checked;
                string sinop = txtSinopsis.Text;

                Pelicula p = new Pelicula(gen, calif, du, sub, fe, apto, actor, origen, sinop, ti);//Por ultimo Instanciamos Peliculas


                if (oServicio.EjecutarInsertPeliculas(p))
                {
                    MessageBox.Show("Se inserto correctame una nueva Pelicula", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar una nueva Pelicula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void limpiar()
        {
            txtTitulo.Text = "";
            cbCalificacion.SelectedIndex = -1;
            txtDuracion.Text = "";
            cbSubtitulos.Checked = false;
            cbAptoTodoPublico.Checked = false;
            cbActorPrincipal.SelectedIndex = -1;
            cbOrigen.SelectedIndex = -1;
            txtSinopsis.Text = "";
            cbGenero.SelectedIndex = -1;
        }

        private bool Valido()
        {
            bool x = true;
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe completar el Titulo de la Pelicula","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtTitulo.Focus();
                x = false;
            }
            if (cbCalificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Calificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbCalificacion.Focus();
                x = false;
            }
            if (string.IsNullOrEmpty(txtDuracion.Text))
            {
                MessageBox.Show("Debe completar la duracion de la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDuracion.Focus();
                x = false;
            }
            if (cbActorPrincipal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar al Actor Principal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbActorPrincipal.Focus();
                x = false;
            }
            if (cbOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el Origen de la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbOrigen.Focus();
                x = false;
            }
            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                MessageBox.Show("Debe completar la Sinopsis de la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSinopsis.Focus();
                x = false;
            }
            if (cbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el Genero de la Pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbGenero.Focus();
                x = false;
            }

            return x;
        }
        ////Aca estan los metodos de boton Guardar ABAJO
        
        //private void btnGuardarPelicula_Click_1(object sender, EventArgs e)
        //{
        //    if (Valido())
        //    {
        //        Pelicula p = new Pelicula();
        //        p.Titulo = txtTitulo.Text;

        //        Calificacion cali = new Calificacion();
        //        DataRowView CboCalif = (DataRowView)(cbCalificacion.SelectedItem);
        //        p.Calificacion.Id_calificacion = Convert.ToInt32(CboCalif.Row.ItemArray[0]);
        //        p.Calificacion.Descripcion = Convert.ToString(CboCalif.Row.ItemArray[1]);
        //        cali.Id_calificacion = p.Calificacion.Id_calificacion;
        //        cali.Descripcion = p.Calificacion.Descripcion;


        //        p.Duracion = Convert.ToDecimal(txtDuracion.Text);
        //        p.Subtitulo = cbSubtitulos.Checked;
        //        p.Fecha_estreno = dtpEstreno.Value;
        //        p.Apto_toto_publico = cbAptoTodoPublico.Checked;

        //        DataRowView CboActor = (DataRowView)(cbActorPrincipal.SelectedItem);
        //        p.Actor_principal.Id_actor_principal = Convert.ToInt32(CboActor.Row.ItemArray[0]);
        //        p.Actor_principal.Nombre = Convert.ToString(CboActor.Row.ItemArray[1]);
        //        p.Actor_principal.Apellido = Convert.ToString(CboActor.Row.ItemArray[2]);


        //        DataRowView CboOrigen = (DataRowView)(cbOrigen.SelectedItem);
        //        p.Origen.Id_origen = Convert.ToInt32(CboOrigen.Row.ItemArray[0]);
        //        p.Origen.Descripcion = Convert.ToString(CboOrigen.Row.ItemArray[1]);

        //        p.Sinopsis = txtSinopsis.Text;

        //        DataRowView CboGenero = (DataRowView)(cbGenero.SelectedItem);
        //        p.Genero.Id_genero = Convert.ToInt32(CboGenero.Row.ItemArray[0]);
        //        p.Genero.Descripcion = Convert.ToString(CboGenero.Row.ItemArray[1]);

        //        oServicio.EjecutarInsert(p);
        //    }
        //}

        //-----------------------------------------------------------------------------------------
        //private void btnGuardarPelicula_Click(object sender, EventArgs e)
        //{
        //    if (Valido())
        //    {
        //        //Genero,Calificacion,ActorPrincipal y Origen
        //        Genero genero = new Genero();
        //        genero.Id_genero = cbGenero.SelectedIndex;
        //        genero.Descripcion = cbGenero.DisplayMember;

        //        Calificacion calificacion = new Calificacion();
        //        calificacion.Id_calificacion = cbCalificacion.SelectedIndex;
        //        calificacion.Descripcion = cbCalificacion.DisplayMember;

        //        ActorPrincipal actorP = new ActorPrincipal();
        //        actorP.Id_actor_principal = Convert.ToInt32(cbActorPrincipal.SelectedValue);
        //        actorP.Nombre = cbActorPrincipal.DisplayMember;


        //        Origen origen = new Origen();
        //        origen.Id_origen = cbOrigen.SelectedIndex;
        //        origen.Descripcion = cbOrigen.DisplayMember;

        //        Pelicula p = new Pelicula();
        //        p.Titulo = txtTitulo.Text;

        //        /*DataRowView CboCalif = (DataRowView)(cbCalificacion.SelectedItem)*/
        //        ;
        //        //p.Calificacion.Id_calificacion = Convert.ToInt32(CboCalif.Row.ItemArray[0]);
        //        //p.Calificacion.Descripcion = Convert.ToString(CboCalif.Row.ItemArray[1]);

        //        p.Calificacion = calificacion;
        //        p.Duracion = Convert.ToDecimal(txtDuracion.Text);
        //        p.Subtitulo = cbSubtitulos.Checked;
        //        p.Fecha_estreno = dtpEstreno.Value;
        //        p.Apto_toto_publico = cbAptoTodoPublico.Checked;
        //        p.Actor_principal = actorP;
        //        p.Origen = origen;
        //        p.Sinopsis = txtSinopsis.Text;
        //        p.Genero = genero;

        //        //DataRowView CboActor = (DataRowView)(cbActorPrincipal.SelectedItem);
        //        //p.Actor_principal.Id_actor_principal = Convert.ToInt32(CboActor.Row.ItemArray[0]);
        //        //p.Actor_principal.Nombre = Convert.ToString(CboActor.Row.ItemArray[1]);
        //        //p.Actor_principal.Apellido = Convert.ToString(CboActor.Row.ItemArray[2]);


        //        //DataRowView CboOrigen = (DataRowView)(cbOrigen.SelectedItem);
        //        //p.Origen.Id_origen = Convert.ToInt32(CboOrigen.Row.ItemArray[0]);
        //        //p.Origen.Descripcion = Convert.ToString(CboOrigen.Row.ItemArray[1]);



        //        //DataRowView CboGenero = (DataRowView)(cbGenero.SelectedItem);
        //        //p.Genero.Id_genero = Convert.ToInt32(CboGenero.Row.ItemArray[0]);
        //        //p.Genero.Descripcion = Convert.ToString(CboGenero.Row.ItemArray[1]);

        //        oServicio.EjecutarInsert(p);
        //    }

        //}   

    }
}
