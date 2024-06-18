using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MediaAluno
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculoMedia_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis responsáveis por receberem as notas calculadas com o peso
            double Nota1, Nota2, Trabalho; 

            // Converte o conteúdo dos componentes TextBox e ComboBox para double e realiza a multiplicação dos mesmos.
            Nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cboPesoNota1.Text);
            Nota2 = double.Parse(txtNota2.Text) * double.Parse(cboPesoNota2.Text);
            Trabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboTrabalho.Text);

            // Soma das variáveis para que se obtenha a média.
            double Media = Nota1 + Nota2 + Trabalho; 

            txtMediaFinal.Text = Media.ToString(); // Convertendo e atribuindo a variável Media para o txtMediaFinal.

            // Variáveis responsáveis por receberem a quantidade de aulas e faltas.

            double QdeAulas, QdeFaltas;

            // Converte o conteúdo dos componentes TextBox (QdeAulas e QdeFaltas)

            QdeAulas = Convert.ToDouble(txtQdeAulas.Text);
            QdeFaltas = Convert.ToDouble(txtQdeFaltas.Text);

            // Realiza a conta necessária para se achr a porcentagem de presença do aluno.

            double PorcentagemPresenca = 100 - ((QdeFaltas / QdeAulas) * 100);

            // Realiza a conta do aproveitamento do aluno e converte o valor em string para ser exibido no txtAproveitamento

            txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2 ) + "%";
            
            if (txtRecuperacao.Text == "")
            {
                if(Media >= Convert.ToDouble(numNotaCorte.Value) && PorcentagemPresenca >= 75)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }

                //Caso o if anterior retornar falso, será verificado se a média obtida é menor que 2,5
                //OU se a preseça é inferior a 75%

               else
                
               if(Media <= 2.5 || PorcentagemPresenca < 75)
                {
                    // No caso do else if  retornar verdade;

                    lblSituacao.Text = "Reprovado"; // irá aparecer Reprovado no campo lblSituacao.Text
                    lblSituacao.ForeColor = Color.Red;
                }
                else
                {
                    lblSituacao.Text = "Recuperação"; // irá aparecer Recuperação no campo lblSituacao.Text
                    lblSituacao.ForeColor = Color.Red;

                }   
            }
            else
            {
                Media = (Media + Convert.ToDouble(txtRecuperacao.Text)) / 2;

                txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";
                if (Media >= 5)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }
                else
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Red;
                }
                txtMediaFinal.Text = Media.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = "";
            txtRecuperacao.Text = string.Empty;

            foreach(Control Componente in this.Controls)
            {
                if (Componente is TextBox)
                {
                    (Componente as TextBox).Clear();

                }
                else 
                    if(Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
                else 
                    if(Componente is NumericUpDown)
                {
                    (Componente as NumericUpDown).Value = 5;
                }
            }
        }
    }
}
