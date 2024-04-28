namespace calculadoraPrestamos
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
            Monto = new TextBox();
            Interes = new TextBox();
            label1 = new Label();
            Plazo = new TextBox();
            label2 = new Label();
            labelInteres = new Label();
            Plazolbl = new Label();
            button1 = new Button();
            RESULTADO = new TextBox();
            SuspendLayout();
            // 
            // Monto
            // 
            Monto.Location = new Point(316, 89);
            Monto.Name = "Monto";
            Monto.Size = new Size(125, 27);
            Monto.TabIndex = 0;
            Monto.TextChanged += textBox1_TextChanged;
            // 
            // Interes
            // 
            Interes.Location = new Point(316, 171);
            Interes.Name = "Interes";
            Interes.Size = new Size(125, 27);
            Interes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 2;
            label1.Text = "Calculadora de Prestamos";
            // 
            // Plazo
            // 
            Plazo.Location = new Point(316, 267);
            Plazo.Name = "Plazo";
            Plazo.Size = new Size(125, 27);
            Plazo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 49);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Monto";
            // 
            // labelInteres
            // 
            labelInteres.AutoSize = true;
            labelInteres.Location = new Point(316, 148);
            labelInteres.Name = "labelInteres";
            labelInteres.Size = new Size(53, 20);
            labelInteres.TabIndex = 5;
            labelInteres.Text = "Interes";
            // 
            // Plazolbl
            // 
            Plazolbl.AutoSize = true;
            Plazolbl.Location = new Point(316, 217);
            Plazolbl.Name = "Plazolbl";
            Plazolbl.Size = new Size(45, 20);
            Plazolbl.TabIndex = 6;
            Plazolbl.Text = "Plazo";
            Plazolbl.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(614, 368);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RESULTADO
            // 
            RESULTADO.Enabled = false;
            RESULTADO.Location = new Point(316, 357);
            RESULTADO.Name = "RESULTADO";
            RESULTADO.Size = new Size(125, 27);
            RESULTADO.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RESULTADO);
            Controls.Add(button1);
            Controls.Add(Plazolbl);
            Controls.Add(labelInteres);
            Controls.Add(label2);
            Controls.Add(Plazo);
            Controls.Add(label1);
            Controls.Add(Interes);
            Controls.Add(Monto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Monto;
        private TextBox Interes;
        private Label label1;
        private TextBox Plazo;
        private Label label2;
        private Label labelInteres;
        private Label Plazolbl;
        private Button button1;
        private TextBox RESULTADO;
    }
}
