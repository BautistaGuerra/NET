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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
            dgvDocentes.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            dgvDocentes.DataSource = Guerra.Negocio.Docente.RecuperarTodos();
        }
        private void frmListado_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
