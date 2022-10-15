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
    public partial class formEspecialidades : Form
    {
        Business.Logic.EspecialidadLogic EspecialidadNegocio;
        public formEspecialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
        }

        private void Listar()
        {
            Business.Logic.EspecialidadLogic EspecialidadNegocio = new EspecialidadLogic();
            dgvEspecialidades.DataSource = EspecialidadNegocio.GetAll();

        }

        private void formEspecialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if(!(dgvEspecialidades.SelectedRows is null))
            {
                int id = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).idEspecialidad;
                EspecialidadesDesktop formABM = new EspecialidadesDesktop(id,EspecialidadesDesktop.FormModes.Modificacion);
                formABM.ShowDialog();
                this.Listar();
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadesDesktop formABM = new EspecialidadesDesktop(EspecialidadesDesktop.FormModes.Alta);
            formABM.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!(dgvEspecialidades.SelectedRows is null))
            {
                int id = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).idEspecialidad;
                EspecialidadesDesktop formABM = new EspecialidadesDesktop(id,EspecialidadesDesktop.FormModes.Baja);
                formABM.ShowDialog();
                this.Listar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
