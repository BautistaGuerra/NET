
namespace UI.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(278, 286);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 25);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar campo de texto";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(442, 286);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 25);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar formulario";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

