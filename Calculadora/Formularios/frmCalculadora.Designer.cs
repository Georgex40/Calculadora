namespace Calculadora
{
    partial class frmCalculadora
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
            lblVariableA = new Label();
            lblVariableB = new Label();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rbdSuma = new RadioButton();
            rbdResta = new RadioButton();
            rbdMultiplicacion = new RadioButton();
            rbdDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblVariableA
            // 
            lblVariableA.AutoSize = true;
            lblVariableA.Location = new Point(11, 28);
            lblVariableA.Name = "lblVariableA";
            lblVariableA.Size = new Size(59, 15);
            lblVariableA.TabIndex = 0;
            lblVariableA.Text = "Vairbale A";
            // 
            // lblVariableB
            // 
            lblVariableB.AutoSize = true;
            lblVariableB.Location = new Point(12, 102);
            lblVariableB.Name = "lblVariableB";
            lblVariableB.Size = new Size(58, 15);
            lblVariableB.TabIndex = 1;
            lblVariableB.Text = "Variable B";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(11, 46);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(120, 23);
            txtVariableA.TabIndex = 2;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(11, 120);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(120, 23);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(384, 45);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(384, 84);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbdDivision);
            groupBox1.Controls.Add(rbdMultiplicacion);
            groupBox1.Controls.Add(rbdResta);
            groupBox1.Controls.Add(rbdSuma);
            groupBox1.Location = new Point(152, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 131);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rbdSuma
            // 
            rbdSuma.AutoSize = true;
            rbdSuma.Location = new Point(22, 27);
            rbdSuma.Name = "rbdSuma";
            rbdSuma.Size = new Size(55, 19);
            rbdSuma.TabIndex = 0;
            rbdSuma.TabStop = true;
            rbdSuma.Text = "Suma";
            rbdSuma.UseVisualStyleBackColor = true;
            // 
            // rbdResta
            // 
            rbdResta.AutoSize = true;
            rbdResta.Location = new Point(22, 53);
            rbdResta.Name = "rbdResta";
            rbdResta.Size = new Size(53, 19);
            rbdResta.TabIndex = 1;
            rbdResta.TabStop = true;
            rbdResta.Text = "Resta";
            rbdResta.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplicacion
            // 
            rbdMultiplicacion.AutoSize = true;
            rbdMultiplicacion.Location = new Point(22, 78);
            rbdMultiplicacion.Name = "rbdMultiplicacion";
            rbdMultiplicacion.Size = new Size(101, 19);
            rbdMultiplicacion.TabIndex = 2;
            rbdMultiplicacion.TabStop = true;
            rbdMultiplicacion.Text = "Multiplicación";
            rbdMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbdDivision
            // 
            rbdDivision.AutoSize = true;
            rbdDivision.Location = new Point(22, 103);
            rbdDivision.Name = "rbdDivision";
            rbdDivision.Size = new Size(67, 19);
            rbdDivision.TabIndex = 3;
            rbdDivision.TabStop = true;
            rbdDivision.Text = "División";
            rbdDivision.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 262);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(lblVariableB);
            Controls.Add(lblVariableA);
            Name = "frmCalculadora";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVariableA;
        private Label lblVariableB;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rbdDivision;
        private RadioButton rbdMultiplicacion;
        private RadioButton rbdResta;
        private RadioButton rbdSuma;
    }
}
