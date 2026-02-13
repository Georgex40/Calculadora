namespace Calculadora.Formularios
{
    partial class frmContador
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
            components = new System.ComponentModel.Container();
            lblCuenta = new Label();
            btnDetener = new Button();
            btnInicio = new Button();
            tkbVelocidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(176, 28);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(39, 42);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(221, 133);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(151, 56);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(12, 133);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(151, 56);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // tkbVelocidad
            // 
            tkbVelocidad.Enabled = false;
            tkbVelocidad.Location = new Point(12, 82);
            tkbVelocidad.Maximum = 5;
            tkbVelocidad.Minimum = 1;
            tkbVelocidad.Name = "tkbVelocidad";
            tkbVelocidad.Size = new Size(360, 45);
            tkbVelocidad.TabIndex = 3;
            tkbVelocidad.TickStyle = TickStyle.Both;
            tkbVelocidad.Value = 1;
            tkbVelocidad.Scroll += tkbVelocidad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 227);
            Controls.Add(tkbVelocidad);
            Controls.Add(btnInicio);
            Controls.Add(btnDetener);
            Controls.Add(lblCuenta);
            Name = "frmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnDetener;
        private Button btnInicio;
        private TrackBar tkbVelocidad;
        private System.Windows.Forms.Timer tmrContador;
    }
}