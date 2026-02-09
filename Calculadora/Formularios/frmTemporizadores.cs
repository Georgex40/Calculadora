using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using MediaPlayer;
using CSCore.SoundOut;

namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        string alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
           
            lblHora.Text = DateTime.Now.ToLongTimeString();
          
            if (lblHora.Text == alarma1)
            {
               SoundPlayer player = new SoundPlayer("C:\\Users\\jorge\\source\\repos\\Calculadora\\Calculadora\\Sonidos\\dragon-studio-rooster-call-364474.wav");
                player.Play();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingresa la Hora", "Sistema","00:00:00 x.x");
        }
    }
}
