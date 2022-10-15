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
    public partial class ModulosDesktop : Form
    {
        Business.Entity.Modulo ModuloActual;
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        public FormModes Modo { get; set; }
        public ModulosDesktop()
        {
            InitializeComponent();
        }
        public ModulosDesktop(FormModes modo)
        {
            
            Modo = modo;
            InitializeComponent();
        }

        public ModulosDesktop(FormModes modo, int id)
        {
            Business.Logic.ModuloLogic ml = new ModuloLogic();
            ModuloActual = ml.GetOne(id);
            Modo = modo;
            InitializeComponent();

            MapearDeDatos();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MapearDeDatos()
        {
            this.txtIdModulo.Text = ModuloActual.idModulo.ToString();
            this.txtDescripcion.Text = ModuloActual.Descripcion;
            this.txtEjecuta.Text = ModuloActual.Ejecuta;
            this.txtIdModulo.ReadOnly = true;
            if (Modo == FormModes.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            else if(Modo == FormModes.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
                this.txtIdModulo.ReadOnly = true;
                this.txtDescripcion.ReadOnly = true;
                this.txtEjecuta.ReadOnly = true;
            }
            else
            {
                this.btnAceptar.Text = "Aceptar";

            }
        }

        private void MapearADatos()
        {
            if (Modo == FormModes.Alta)
            {
                ModuloActual = new Modulo();
                ModuloActual.Descripcion = this.txtDescripcion.Text;
                ModuloActual.Ejecuta = this.txtEjecuta.Text;
                ModuloActual.State = Modulo.States.New;
            }
            else if(Modo == FormModes.Modificacion)
            {
                ModuloActual.Descripcion = this.txtDescripcion.Text;
                ModuloActual.Ejecuta = this.txtEjecuta.Text;
                ModuloActual.State = Modulo.States.Modified;
            }
            else if (Modo == FormModes.Baja)
            {
                ModuloActual.State = Modulo.States.Deleted;
            }
        }

        private void GuardarCambios()
        {
            this.MapearADatos();
            Business.Logic.ModuloLogic ml = new ModuloLogic();
            ml.Save(ModuloActual);
        }



        private void ModulosDesktop_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }
    }
}
