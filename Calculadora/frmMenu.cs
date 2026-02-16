using Calculadora.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadoraSimple = new frmCalculadora();
            calculadoraSimple.Show();

        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizadores Reloj = new frmTemporizadores();
            Reloj.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContador contador = new frmContador();
            contador.Show();
        }

        private void xMLDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXMLAccess xmlAcceso = new frmXMLAccess();
            xmlAcceso.Show();
        }
    }
}
