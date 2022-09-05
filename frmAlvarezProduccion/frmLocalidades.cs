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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnCrearLocalidad_Click(object sender, EventArgs e)
        {
            string idLocalidad;
            string NombLocalidad, datos;
            bool bandera = false;

            idLocalidad = txtIdentificadorLocal.Text;
            NombLocalidad = txtNombreLocalidad.Text;

            TextWriter cultivo = new StreamWriter("./Localidades.txt", true);
            cultivo.Close();

            if (idLocalidad != "0" && NombLocalidad != "")
            {
                datos = idLocalidad + "," + NombLocalidad;
                char separador = Convert.ToChar(",");
                StreamReader srLocalidad = new StreamReader("./Localidades.txt");
                while (!srLocalidad.EndOfStream && bandera == false)
                {
                    string[] arrayLocalidades = srLocalidad.ReadLine().Split(separador);
                    string idLoca = Convert.ToString(arrayLocalidades[0]);
                    if (idLocalidad == idLoca)
                    {
                        bandera = true;
                        MessageBox.Show("Esta ID ya esta registrada");
                    }
                }
                srLocalidad.Close();
                using (StreamWriter swLocalidades = File.AppendText("./Localidades.txt"))
                {
                    if (bandera == false)
                    {
                        swLocalidades.WriteLine(datos);
                        MessageBox.Show("Datos Agregados con exito");
                    }
                }
            }


        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {

        }
    }
    
}
