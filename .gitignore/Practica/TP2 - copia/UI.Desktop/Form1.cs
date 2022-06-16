using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Form1 : Form
    {
        TextBox nuevoTextBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.nuevoTextBox = new TextBox();

            this.nuevoTextBox.Location = new Point(299, 168);

            this.Controls.Add(nuevoTextBox);
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.nuevoTextBox);
            this.Close();
        }

        private void nuevoTextBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
