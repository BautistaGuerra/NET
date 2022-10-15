using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado listadoApp = new frmListado();
            listadoApp.ShowDialog();
        }

        private void recuperarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecuperar recuperarApp = new frmRecuperar();
            recuperarApp.ShowDialog();
        }
    }
}
