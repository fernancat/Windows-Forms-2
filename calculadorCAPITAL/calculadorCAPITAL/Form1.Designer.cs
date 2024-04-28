namespace calculadorCAPITAL
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
            capitalInicial = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            tasaInteres = new Label();
            tiempo = new Label();
            textBox1 = new TextBox();
            Resultado = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 44);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA DE CAPITAL";
            // 
            // capitalInicial
            // 
            capitalInicial.Location = new Point(24, 98);
            capitalInicial.Name = "capitalInicial";
            capitalInicial.Size = new Size(326, 27);
            capitalInicial.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 341);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 27);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 59);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 4;
            label2.Text = "Capital Inicial";
            label2.Click += label2_Click;
            // 
            // tasaInteres
            // 
            tasaInteres.AutoSize = true;
            tasaInteres.Location = new Point(38, 166);
            tasaInteres.Name = "tasaInteres";
            tasaInteres.Size = new Size(114, 20);
            tasaInteres.TabIndex = 5;
            tasaInteres.Text = "Tasa de Interes";
            // 
            // tiempo
            // 
            tiempo.AutoSize = true;
            tiempo.Location = new Point(47, 288);
            tiempo.Name = "tiempo";
            tiempo.Size = new Size(62, 20);
            tiempo.TabIndex = 6;
            tiempo.Text = "Tiempo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 7;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Enabled = false;
            Resultado.Location = new Point(504, 98);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(79, 20);
            Resultado.TabIndex = 8;
            Resultado.Text = "Resultado";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(468, 228);
            button1.Name = "button1";
            button1.Size = new Size(131, 70);
            button1.TabIndex = 9;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(900, 450);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(textBox1);
            Controls.Add(tiempo);
            Controls.Add(tasaInteres);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(capitalInicial);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox capitalInicial;
        private TextBox textBox3;
        private Label label2;
        private Label tasaInteres;
        private Label tiempo;
        private TextBox textBox1;
        private Label Resultado;
        private Button button1;
        private TextBox textBox2;
    }
}
