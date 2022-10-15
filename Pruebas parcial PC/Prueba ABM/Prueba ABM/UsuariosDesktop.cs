using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba_ABM
{
    public partial class UsuariosDesktop : Form
    {
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
        public FormModes FormMode { get; set; }
        Business.Entity.Usuario UsuarioActual;
        public UsuariosDesktop()
        {
            InitializeComponent();
        }
        public UsuariosDesktop(FormModes modo)
        {
            FormMode = modo;
            InitializeComponent();
        }
        public UsuariosDesktop(int id, FormModes modo)
        {
            Business.Logic.UsuarioLogic user = new Business.Logic.UsuarioLogic();
            UsuarioActual = user.GetOne(id);
            FormMode = modo;
            InitializeComponent();

            this.MapearDeDatos();
        }
        private void MapearDeDatos()
        {
            if (this.FormMode == FormModes.Alta | this.FormMode == FormModes.Modificacion)
            {
                btnAceptar.Text = "Guardar";
                this.txtIdUsuario.Text = UsuarioActual.idUsuario.ToString();
                this.txtNombre.Text = UsuarioActual.Nombre;
                this.txtApellido.Text = UsuarioActual.Apellido;
                this.txtIdUsuario.ReadOnly = true;
            }
            else if (this.FormMode == FormModes.Baja)
            {
                btnAceptar.Text = "Eliminar";
                this.txtIdUsuario.Text = UsuarioActual.idUsuario.ToString();
                this.txtNombre.Text = UsuarioActual.Nombre;
                this.txtApellido.Text = UsuarioActual.Apellido;
                this.txtIdUsuario.ReadOnly = true;
                this.txtNombre.ReadOnly = true;
                this.txtApellido.ReadOnly = true;
            }
            else btnAceptar.Text = "Aceptar";
        }

        private void MapearADatos()
        {
            if(this.FormMode == FormModes.Alta)
            {
                UsuarioActual = new Business.Entity.Usuario();
                UsuarioActual.Nombre = txtNombre.Text;
                UsuarioActual.Apellido = txtApellido.Text;
                UsuarioActual.State = Business.Entity.Usuario.States.New;
            }
            else if(this.FormMode == FormModes.Modificacion)
            {
                UsuarioActual.Nombre = txtNombre.Text;
                UsuarioActual.Apellido = txtApellido.Text;
                UsuarioActual.State = Business.Entity.Usuario.States.Modified;
            }
            else
            {
                UsuarioActual.State = Business.Entity.Usuario.States.Deleted;
            }
        }

        private void GuardarCambios()
        {
            this.MapearADatos();

            Business.Logic.UsuarioLogic user = new Business.Logic.UsuarioLogic();
            user.Save(UsuarioActual);
        }
        private void UsuariosDesktop_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }
    }
}
