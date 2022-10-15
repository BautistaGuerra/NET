using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entity;
using Business.Logic;

namespace Prueba_ABM
{
    public partial class EspecialidadesDesktop : Form
    {
        Business.Entity.Especialidad EspecialidadActual;
        Business.Logic.EspecialidadLogic EspecialidadNegocio;

        public FormModes Modo { get; set; }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }

        public EspecialidadesDesktop(FormModes modo)
        {
            this.Modo = modo;
            InitializeComponent();
        }
        public EspecialidadesDesktop(int id, FormModes modo)
        {
            this.Modo = modo;
            Business.Logic.EspecialidadLogic EspecialidadNegocio = new EspecialidadLogic();
            EspecialidadActual = EspecialidadNegocio.GetOne(id);
            InitializeComponent();
            MapearDeDatos();
        }

        public void MapearDeDatos()
        {
            this.txtIdEspecialidad.Text = EspecialidadActual.idEspecialidad.ToString();
            this.txtDescripcion.Text = EspecialidadActual.Descripcion;
            if(Modo == FormModes.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else
            {
                btnAceptar.Text = "Eliminar";
                txtIdEspecialidad.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
            }

        }

        public void MapearADatos()
        {
            if(Modo == FormModes.Alta){
                EspecialidadActual = new Especialidad();
                EspecialidadActual.Descripcion = txtDescripcion.Text;
                EspecialidadActual.State = Especialidad.States.New;
            }
            else if(Modo == FormModes.Modificacion)
            {
                EspecialidadActual.Descripcion = txtDescripcion.Text;
                EspecialidadActual.State = Especialidad.States.Modified;

            }
            else
            {
                EspecialidadActual.State = Especialidad.States.Deleted;
            }
        }

        public void GuardarCambios()
        {
            this.MapearADatos();
            EspecialidadLogic el = new EspecialidadLogic();
            el.Save(EspecialidadActual);
            this.Close();
        }


        private void EspecialidadesDesktop_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }
    }
}
