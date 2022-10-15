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
    public partial class formModulos : Form
    {
        Business.Logic.ModuloLogic ModuloNegocio; 
        public formModulos()
        {
            InitializeComponent();
            dgvModulos.AutoGenerateColumns = false;

        }

        private void Listar()
        {
            ModuloNegocio = new ModuloLogic();
            dgvModulos.DataSource = ModuloNegocio.GetAll();
        }

        private void formModulos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModulosDesktop formABM = new ModulosDesktop(ModulosDesktop.FormModes.Alta);
            formABM.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if(!(dgvModulos.SelectedRows is null))
            {
                int id = ((Business.Entity.Modulo)dgvModulos.SelectedRows[0].DataBoundItem).idModulo;
                ModulosDesktop formABM = new ModulosDesktop(ModulosDesktop.FormModes.Modificacion, id);
                formABM.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!(dgvModulos.SelectedRows is null))
            {
                int id = ((Business.Entity.Modulo)dgvModulos.SelectedRows[0].DataBoundItem).idModulo;
                ModulosDesktop formABM = new ModulosDesktop(ModulosDesktop.FormModes.Baja, id);
                formABM.ShowDialog();
                this.Listar();
            }

        }
    }
}
