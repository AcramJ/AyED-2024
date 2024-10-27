namespace _3_Marca_TerminosYCondiciones
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
            this.mensaje = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.CheckBox();
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(41, 92);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(493, 19);
            this.mensaje.TabIndex = 0;
            this.mensaje.Text = "Acepta los términos y condiciones del programa sin leer";
            // 
            // Aceptar
            // 
            this.Aceptar.AutoSize = true;
            this.Aceptar.BackColor = System.Drawing.Color.CadetBlue;
            this.Aceptar.Checked = true;
            this.Aceptar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Aceptar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(124, 114);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(347, 21);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "He leído y acepto los términos y condiciones";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.CheckedChanged += new System.EventHandler(this.Aceptar_CheckedChanged);
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton.ForeColor = System.Drawing.Color.Black;
            this.boton.Location = new System.Drawing.Point(231, 141);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(130, 35);
            this.boton.TabIndex = 2;
            this.boton.Text = "CERRAR";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(580, 481);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.mensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.CheckBox Aceptar;
        private System.Windows.Forms.Button boton;
    }
}

