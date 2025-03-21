namespace Operaciones
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
            cmbOperaciones = new ComboBox();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(12, 34);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(121, 23);
            cmbOperaciones.TabIndex = 0;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 106);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(197, 106);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(83, 181);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(197, 135);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Operaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 86);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Número 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 184);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(333, 237);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(cmbOperaciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperaciones;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
