using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if(_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get
            {
                return (FormModes)this.ViewState["FormMode"];
            }
            set
            {
                this.ViewState["FormModed"] = value;
            }
        }

        private Usuario Entity { get; set; }
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null) return (int)this.ViewState["SelectedID"];
                else return 0;
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        private bool IsEntitySelected
        {
            get { return (this.SelectedID != 0);}
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            gridView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) this.LoadGrid();
        }
    }
}