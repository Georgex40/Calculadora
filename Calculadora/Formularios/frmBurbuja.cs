using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] ordenado = new int[dgvDesordenado.RowCount-1];
            Ordenamientos ordenar = new Ordenamientos();
            for (int i = 0; i < dgvDesordenado.RowCount-1; i++)
            {
                ordenado[i] = Convert.ToInt32(dgvDesordenado.Rows[i].Cells[0].Value);

            }
            ordenado = ordenar.Burbuja(ordenado);

            //Define el tamaño de las filas del DataGridView
            //de acuerdo al tamaño del arreglo

            dgvOrdenado.DataSource = ordenar;

            // Llena el DataGridView con los valores Ordenados
            for (int i = 0; i < ordenado.Length-1; i++)
            {
                dgvOrdenado.Rows[i].Cells[0].Value = ordenado[1];

            }
        }
    }
}
