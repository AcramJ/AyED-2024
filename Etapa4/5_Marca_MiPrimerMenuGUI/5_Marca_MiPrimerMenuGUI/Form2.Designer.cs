﻿namespace _5_Marca_MiPrimerMenuGUI
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 18);
            label1.Name = "label1";
            label1.Size = new Size(130, 36);
            label1.TabIndex = 0;
            label1.Text = "RESTO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 75);
            label2.Name = "label2";
            label2.Size = new Size(405, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese dos numeros para poder realizar la operación";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 153);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 4;
            label3.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(370, 154);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 5;
            label4.Text = "=";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(395, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 23);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(372, 289);
            button2.Name = "button2";
            button2.Size = new Size(102, 32);
            button2.TabIndex = 8;
            button2.Text = "CERRAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 130);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "1° num";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 132);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 10;
            label6.Text = "2° num";
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(182, 208);
            button1.Name = "button1";
            button1.Size = new Size(126, 39);
            button1.TabIndex = 11;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(34, 289);
            button3.Name = "button3";
            button3.Size = new Size(102, 32);
            button3.TabIndex = 21;
            button3.Text = "ATRAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(492, 350);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button3;
    }
}