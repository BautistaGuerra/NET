using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Guerra.Entidades;
using Guerra.Negocio;

namespace Guerra.Web
{
    public partial class frmAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GuardarEntidad()
        {
            Guerra.Entidades.Docente docente = new Entidades.Docente();
            docente.Id = Convert.ToInt32(this.txtId.Text);
            docente.ApellidoNombre = this.txtApellidoNombre.Text;
            docente.Cuil = this.txtCuil.Text;
            docente.Email = this.txtEmail.Text;
            docente.FechaIngreso = Convert.ToDateTime(this.txtFechaIngreso.Text);
            docente.Salario = Convert.ToInt32(this.txtSalario.Text);
            Negocio.Docente.Agregar(docente);

            Response.Write("Operacion satisfactoria");

        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarEntidad();
        }

        private void ClearForm()
        {
            this.txtId.Text = string.Empty;
            this.txtApellidoNombre.Text = string.Empty;
            this.txtCuil.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtFechaIngreso.Text = string.Empty;
            this.txtSalario.Text = string.Empty;

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }
    }
}