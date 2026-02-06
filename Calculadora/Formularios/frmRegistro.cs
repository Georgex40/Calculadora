using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmRegistro : Form
    {
        List<Persona> personas = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            personas.Add(new Persona() { Nombre = txtNombre.Text, Apellido = txtApellidos.Text, Fecha = dtpFechaN.Value });
            MessageBox.Show("Datos registrados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = personas;
                VerificarRegistros();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            personas.RemoveAt(dgvPersonas.CurrentRow.Index);// Para seleccionar cual quieres que se elimine
            dgvPersonas.DataSource = null; //Limpiar el DataGridView
            dgvPersonas.DataSource = personas; //Volver a colorcar valores para que no quede en nulo
            VerificarRegistros();
        }
        private void VerificarRegistros()
        {
            if(personas.Count==0) 
                btnEliminar.Enabled = false;
            else 
                btnEliminar.Enabled=true;
        }
    }
}
