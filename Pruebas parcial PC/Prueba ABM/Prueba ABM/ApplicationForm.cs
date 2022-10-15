using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_ABM
{
    public partial class ApplicationForm : Form
    {
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
        public FormModes FormMode { get; set; }
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
