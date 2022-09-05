using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace frmAlvarezProduccion
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmLocalidades frmL = new frmLocalidades();
            frmL.Show();
           
        }

        private void culltivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmCultivos frmL = new frmCultivos();
            frmL.Show();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmL = new frmProduccion();
            frmL.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
