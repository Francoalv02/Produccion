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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnCrearCultivos_Click(object sender, EventArgs e)
        {
            int idCultivos;
            string NombreCultivos;
            string datos;
            bool bandera = false;

            idCultivos = Convert.ToInt32(txtIdentificadorCultivos.Text);
            NombreCultivos = txtNombrecultivos.Text;

            StreamWriter swCultivos = new StreamWriter("./Cultivos.txt", true);
            swCultivos.Close();

            if (idCultivos != 0 && NombreCultivos != "")
            {
                datos = idCultivos + "," + NombreCultivos;
                char separador = Convert.ToChar(",");
                StreamReader srCultivos = new StreamReader("./Cultivos.txt");
                while (!srCultivos.EndOfStream && bandera == false)
                {
                    string[] Cultivos = srCultivos.ReadLine().Split(separador);
                    string idArray = (Cultivos[0]);
                    if (idArray == Convert.ToString(idCultivos))
                    {
                        bandera = true;
                        MessageBox.Show("Esta ID ya esta en los datos");
                    }
                }
                srCultivos.Close();

                using (StreamWriter sw = File.AppendText("./Cultivos.txt"))
                    if (bandera == false)
                    {
                        sw.WriteLine(datos);
                        MessageBox.Show("Datos agregados con exito");
                    }
            }

        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {

        }
    }
}
