using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFrankyUi
{
    public partial class FrmReparacion : Form
    {
        
        public FrmReparacion()
        {
            InitializeComponent();
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            //TODO: Asocio el evento que va a imprimir el ticket
            //TODO: Instanciar y comenzar el hilo que se va a encargar de reparar los barcos del taller
           
           
        }

        private void FrmReparacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void lblBarcoTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
