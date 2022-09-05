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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);
            swProduccion.WriteLine("Localidad: " + cbLocalidades.Text + " " + "Cultivo: " + cbCultivos.Text + " " + "Cantidad: " + nudTonelada.Value);
            MessageBox.Show("Se han cargado los datos con exito");
            swProduccion.Close();


        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader lectorLocalidad = new StreamReader("./Localidades.txt");
            StreamReader lectorProduccion = new StreamReader("./Cultivos.txt");
            char separador = Convert.ToChar(",");
            StreamWriter Produccion = new StreamWriter("./Produccion.txt");
            Produccion.Close();

            while (!lectorLocalidad.EndOfStream)
            {
                string[] informacionLocalidad = lectorLocalidad.ReadLine().Split(separador);
                cbLocalidades.Items.Add(informacionLocalidad[1]);
            }
            while (!lectorProduccion.EndOfStream)
            {
                string[] informacionCultivos = lectorProduccion.ReadLine().Split(separador);
                cbCultivos.Items.Add(informacionCultivos[1]);
            }

        }
    }
}
