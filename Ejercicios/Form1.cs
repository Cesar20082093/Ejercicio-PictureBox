using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";
            cotizacion = "Cotizacion de Auto para " + txtNombre.Text + "\r\n";
            //Obtener costo inicial
            costo = Convert.ToDouble(txtCosto.Text);

            //Verificar seguros
            if (rbnBasico.Checked == true)
            {
                costo = costo + 500.0;
                cotizacion += "lleva seguro basico de $500 \r\n";
            }
            if (rbnTerceros.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Lleva seguro a terceros de $700 \r\n";
            }
            if (rbnTotal.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "Lleva seguro total de $1000 \r\n";
            }

            //Verificar equipo

            if(chkAire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con aire acondicionado de $500.0 \r\n";
            }
            if(chkAudio.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Con sistema de audio de $700 \r\n";
            }

            //Mostramos Total
            cotizacion += "El total de pagar es de " + costo.ToString();

            txtCotización.Text = cotizacion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
