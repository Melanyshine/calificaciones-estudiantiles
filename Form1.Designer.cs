namespace Ejercicio_Formulario_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            txtn4 = new TextBox();
            txtn3 = new TextBox();
            txtn2 = new TextBox();
            label3 = new Label();
            txtn1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtp = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txte = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtf = new TextBox();
            txtc = new TextBox();
            label7 = new Label();
            buttonc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 32);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de Promedio del Estudiante";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtn4);
            groupBox1.Controls.Add(txtn3);
            groupBox1.Controls.Add(txtn2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtn1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notas del Estudiante";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 159);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 0;
            label5.Text = "Nota 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 122);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 0;
            label4.Text = "Nota 3";
            // 
            // txtn4
            // 
            txtn4.Location = new Point(89, 156);
            txtn4.Name = "txtn4";
            txtn4.Size = new Size(74, 31);
            txtn4.TabIndex = 3;
            // 
            // txtn3
            // 
            txtn3.Location = new Point(89, 119);
            txtn3.Name = "txtn3";
            txtn3.Size = new Size(74, 31);
            txtn3.TabIndex = 3;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(89, 82);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(74, 31);
            txtn2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 82);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Nota 2";
            // 
            // txtn1
            // 
            txtn1.Location = new Point(89, 42);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(74, 31);
            txtn1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Nota 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtp);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(281, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 187);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Promedio";
            // 
            // txtp
            // 
            txtp.Location = new Point(29, 94);
            txtp.Name = "txtp";
            txtp.Size = new Size(150, 31);
            txtp.TabIndex = 1;
            txtp.TextChanged += txtp_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 48);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 0;
            label6.Text = "Promedio:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txte);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtf);
            groupBox3.Controls.Add(txtc);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(565, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 243);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Evaluación Adicional";
            // 
            // txte
            // 
            txte.Location = new Point(33, 148);
            txte.Name = "txte";
            txte.Size = new Size(126, 31);
            txte.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 114);
            label9.Name = "label9";
            label9.Size = new Size(170, 25);
            label9.TabIndex = 4;
            label9.Text = "Nota Extraordinario:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 178);
            label8.Name = "label8";
            label8.Size = new Size(96, 25);
            label8.TabIndex = 3;
            label8.Text = "Nota Final:";
            label8.Click += label8_Click;
            // 
            // txtf
            // 
            txtf.Location = new Point(33, 206);
            txtf.Name = "txtf";
            txtf.Size = new Size(126, 31);
            txtf.TabIndex = 2;
            txtf.TextChanged += txtf_TextChanged;
            // 
            // txtc
            // 
            txtc.Location = new Point(33, 70);
            txtc.Name = "txtc";
            txtc.Size = new Size(126, 31);
            txtc.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 41);
            label7.Name = "label7";
            label7.Size = new Size(177, 25);
            label7.TabIndex = 0;
            label7.Text = "Nota de Completivo:";
            // 
            // buttonc
            // 
            buttonc.Location = new Point(348, 347);
            buttonc.Name = "buttonc";
            buttonc.Size = new Size(112, 34);
            buttonc.TabIndex = 5;
            buttonc.Text = "Calcular";
            buttonc.UseVisualStyleBackColor = true;
            buttonc.Click += buttonc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonc);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtn1;
        private Label label2;
        private TextBox txtn4;
        private TextBox txtn3;
        private TextBox txtn2;
        private GroupBox groupBox2;
        private TextBox txtp;
        private Label label6;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox txtf;
        private TextBox txtc;
        private Label label7;
        private Button buttonc;
        private Button buttonl;
        private Button buttons;
        private Label label9;
        private TextBox txte;
    }
}
