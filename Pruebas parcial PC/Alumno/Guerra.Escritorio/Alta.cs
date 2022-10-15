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

namespace Guerra.Escritorio
{
    public partial class Alta : Form
    {

        public Alta()
        {
            InitializeComponent();
        }
        private void GuardarCambios()
        {
            Entidades.Alumno alumno = new Entidades.Alumno();
            alumno.ApellidoNombre = txtApellidoNombre.Text;
            alumno.Dni = txtDni.Text;
            alumno.Email = txtEmail.Text;
            alumno.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            alumno.NotaPromedio = Convert.ToDecimal(txtNotaPromedio.Text);
            Negocio.Alumno.Agregar(alumno);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            bool campos_no_vacios = txtApellidoNombre.Text != "" & txtDni.Text != "" & txtEmail.Text != "" & txtFechaNacimiento.Text != "" & txtNotaPromedio.Text != "";
            if (campos_no_vacios & Validaciones.EsMailValido(txtEmail.Text))
            {
                GuardarCambios();
                this.Close();
            }
            else
            {
                MessageBox.Show("No pasa las validaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
