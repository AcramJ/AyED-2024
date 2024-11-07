namespace _4_Marca_CreadorPersonajeRol
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Raza = new System.Windows.Forms.ComboBox();
            this.Vida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Habilidades = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(145, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crea tu Personaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Habilidad Extra:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(33, 123);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(127, 20);
            this.Nombre.TabIndex = 5;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre1_TextChanged);
            // 
            // Raza
            // 
            this.Raza.FormattingEnabled = true;
            this.Raza.Items.AddRange(new object[] {
            "Humano",
            "Enano",
            "Hbbit"});
            this.Raza.Location = new System.Drawing.Point(468, 122);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(103, 21);
            this.Raza.TabIndex = 6;
            // 
            // Vida
            // 
            this.Vida.Location = new System.Drawing.Point(186, 123);
            this.Vida.Name = "Vida";
            this.Vida.Size = new System.Drawing.Size(100, 20);
            this.Vida.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(152, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Habilidades
            // 
            this.Habilidades.BackColor = System.Drawing.Color.CadetBlue;
            this.Habilidades.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Habilidades.FormattingEnabled = true;
            this.Habilidades.Items.AddRange(new object[] {
            "Invisibilidad",
            "Fuerza Sobrehumana",
            "Curación Rapida"});
            this.Habilidades.Location = new System.Drawing.Point(310, 123);
            this.Habilidades.Name = "Habilidades";
            this.Habilidades.Size = new System.Drawing.Size(137, 64);
            this.Habilidades.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(408, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(607, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Habilidades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vida);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.ComboBox Raza;
        private System.Windows.Forms.TextBox Vida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox Habilidades;
        private System.Windows.Forms.Button button2;
    }
}

