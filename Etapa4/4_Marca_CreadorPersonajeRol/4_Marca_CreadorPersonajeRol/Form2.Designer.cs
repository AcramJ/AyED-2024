namespace _4_Marca_CreadorPersonajeRol
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NOMBRE2 = new System.Windows.Forms.TextBox();
            this.Vida2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Habilidades2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Raza2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton2
            // 
            this.Boton2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton2.Location = new System.Drawing.Point(129, 227);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(82, 37);
            this.Boton2.TabIndex = 0;
            this.Boton2.Text = "Atras";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NOMBRE2
            // 
            this.NOMBRE2.Location = new System.Drawing.Point(37, 143);
            this.NOMBRE2.Name = "NOMBRE2";
            this.NOMBRE2.Size = new System.Drawing.Size(100, 20);
            this.NOMBRE2.TabIndex = 2;
            this.NOMBRE2.TextChanged += new System.EventHandler(this.NOMBRE2_TextChanged);
            // 
            // Vida2
            // 
            this.Vida2.Location = new System.Drawing.Point(161, 143);
            this.Vida2.Name = "Vida2";
            this.Vida2.Size = new System.Drawing.Size(100, 20);
            this.Vida2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vida:";
            // 
            // Habilidades2
            // 
            this.Habilidades2.Location = new System.Drawing.Point(286, 143);
            this.Habilidades2.Name = "Habilidades2";
            this.Habilidades2.Size = new System.Drawing.Size(133, 20);
            this.Habilidades2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Habilidad Extra:";
            // 
            // Raza2
            // 
            this.Raza2.Location = new System.Drawing.Point(448, 143);
            this.Raza2.Name = "Raza2";
            this.Raza2.Size = new System.Drawing.Size(100, 20);
            this.Raza2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raza:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(396, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(122, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datos del Personaje";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(596, 332);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Raza2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Habilidades2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vida2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NOMBRE2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NOMBRE2;
        private System.Windows.Forms.TextBox Vida2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Habilidades2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Raza2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}