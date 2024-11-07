namespace _1_Marca_CobrarBecaGUI
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
            this.Edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.im = new System.Windows.Forms.Label();
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edad
            // 
            this.Edad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Edad.Location = new System.Drawing.Point(78, 66);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(177, 20);
            this.Edad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su edad";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entre 0 - 50,000",
            "50,001 - 100,000",
            "100,001 - 200,000",
            "Más de 200,000"});
            this.comboBox1.Location = new System.Drawing.Point(61, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // im
            // 
            this.im.AutoSize = true;
            this.im.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.im.Location = new System.Drawing.Point(58, 101);
            this.im.Name = "im";
            this.im.Size = new System.Drawing.Size(214, 15);
            this.im.TabIndex = 3;
            this.im.Text = "Ingrese sus ingresos mensuales";
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton.Location = new System.Drawing.Point(113, 146);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(102, 33);
            this.boton.TabIndex = 4;
            this.boton.Text = "Verificar";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 246);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.im);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label im;
        private System.Windows.Forms.Button boton;
    }
}

