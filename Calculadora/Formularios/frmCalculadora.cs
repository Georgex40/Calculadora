namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int a = 0, b = 0, resultado=0;
                a = int.Parse(txtVariableA.Text);
                b = Convert.ToInt32(txtVariableB.Text);

                if (rbdSuma.Checked)
                
                    resultado = a + b;
                
                if (rbdResta.Checked)
                    resultado = a - b;
                if (rbdMultiplicacion.Checked)
                    resultado = a * b;
                if (rbdDivision.Checked)
                    resultado = a / b;
               
                MessageBox.Show("El Resultado es: " + resultado.ToString(),
                    "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la conversión de datos",
                    "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();

            }
        }

        private void Reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
