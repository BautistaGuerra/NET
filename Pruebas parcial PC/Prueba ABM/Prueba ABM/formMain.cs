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
    public partial class formMain : Form
    {
        Business.Logic.UsuarioLogic UsuarioNegocio;
        
        public formMain()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;        
        }

        private void MapearDeDatos()
        {

        }

        private void Listar()
        {
            UsuarioNegocio = new Business.Logic.UsuarioLogic();
            this.dgvUsuarios.DataSource = UsuarioNegocio.GetAll();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuariosDesktop formABM = new UsuariosDesktop(UsuariosDesktop.FormModes.Alta);
            formABM.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if(!(this.dgvUsuarios.SelectedRows is null))
            {
                int id = ((Business.Entity.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).idUsuario;
                UsuariosDesktop formABM = new UsuariosDesktop(id, UsuariosDesktop.FormModes.Modificacion);
                formABM.ShowDialog();
                Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!(this.dgvUsuarios.SelectedRows is null))
            {
                int id = ((Business.Entity.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).idUsuario;
                UsuariosDesktop formABM = new UsuariosDesktop(id, UsuariosDesktop.FormModes.Baja);
                formABM.ShowDialog();
                Listar();
            }
        }
    }
}
