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
    public partial class Listado : System.Web.UI.Page
    {
        public void LoadGrid()
        {
            dgvAlumnos.DataSource = Negocio.Alumno.RecuperarTodos();
            dgvAlumnos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LoadGrid();
            }
        }
    }
}