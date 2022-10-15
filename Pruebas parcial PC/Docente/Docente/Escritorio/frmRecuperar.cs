using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guerra.Entidades;
using Guerra.Negocio;

namespace Escritorio
{
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }



        private void frmRecuperar_Load(object sender, EventArgs e)
        {

        }

        private void CargarEntidad()
        {
            try
            {
                Guerra.Entidades.Docente doc = Guerra.Negocio.Validaciones.RecuperarUno(txtCuilBuscado.Text);
                txtId.Text = doc.Id.ToString();
                txtApellidoNombre.Text = doc.ApellidoNombre;
                txtCuil.Text = doc.Cuil;
                txtEmail.Text = doc.Email;
                txtFechaIngreso.Text = doc.FechaIngreso.ToString();
                txtSalario.Text = doc.Salario.ToString();
                txtAntiguedad.Text = doc.Antiguedad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            CargarEntidad();
        }
    }
}
