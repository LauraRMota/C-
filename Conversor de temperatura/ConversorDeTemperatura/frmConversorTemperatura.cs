using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperatura
{
    public partial class frmConversorTemperatura : Form
    {
        public frmConversorTemperatura()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear();

            foreach(Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
            foreach (Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if(rbCelsiusEntrada.Checked == true)
            {
                if(rbKelvinSaida.Checked ==true)
                {
                    txtResultado.Text = (valor + 273.15) + "K";
                }
                else
                    if(rbFahrenheitSaida.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 + 32) + "°F";
                }
                else
                {
                    txtResultado.Text = valor + "°C";
                }


            }

            else
                if (rbKelvinEntrada.Checked == true)
            {
                if(rbCelsiusSaida.Checked == true)
                {
                    txtResultado.Text = (valor - 273,15) + "°C";
                }
                else
                    if(rbFahrenheitSaida.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
                }
                else
                {
                    txtResultado.Text = valor + "K";
                }
               
            }
            else
                if(rbFahrenheitEntrada.Checked == true)
            {
                if(rbCelsiusSaida.Checked == true)
                {
                    txtResultado.Text = ((valor - 32) * 1.8) + "°C";
                }
                else
                    if (rbKelvinSaida.Checked == true)
                {
                    txtResultado.Text = ((valor + 459.67) / 1.8) + "K";
                }
                else
                {
                    txtResultado.Text = valor + "°F";
                }
            }
            else
            {
                txtResultado.Text = valor.ToString();
            }

        }
        

        private void rbCelsiusEntrada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
