using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if(ousuario != null)
            {
                Inicio form = new Inicio();          //crear inicio con ingresar

                form.Show();                        //ir a inicio con ingresar
                this.Hide();                        //ocultar login

                form.FormClosing += frm_closing;    //volver a login al cerrar inicio
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();           //cerrar login con cancelar
        }

        private void frm_closing(object sender, FormClosingEventArgs e)  //volvemos a login y limpiamos celdas
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
