namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e) // evnto click dos bot�es
        {

            if (txtVisor.Text == "0") // se o visor estiver com o n�mero 0

            {
                txtVisor.Clear(); // � para limp�-lo
            }

            Button botaoAcionado = (Button)sender; // o objeto bot�o que foi clicado ser� carregado no botaoAcionado

            switch (botaoAcionado.Name) // verifica o nome do bot�o acionado
            {
                case "btn1": // caso seja btn1
                    txtVisor.Text += "1"; // a propriedade text do visor receber� n�mero 1
                    break; // parar a verifica��o

                case "btn2": // os pr�ximos casos verificam qual foi o bot�o acionado e envia para a
                    txtVisor.Text += "2"; // propriedade text do mesmo, o n�mero relacionado a ele.
                    break; // ap�s a detec��o de qual bot�o foi acionado, a verifica��o � finalizada

                case "btn3":
                    txtVisor.Text += "3";
                    break;

                case "btn4":
                    txtVisor.Text += "4";
                    break;

                case "btn5":
                    txtVisor.Text += "5";
                    break;

                case "btn6":
                    txtVisor.Text += "6";
                    break;

                case "btn7":
                    txtVisor.Text += "7";
                    break;

                case "btn8":
                    txtVisor.Text += "8";
                    break;

                case "btn9":
                    txtVisor.Text += "9";
                    break;

                case "btn0":
                    txtVisor.Text += "0";
                    break;

                case "btnVirgula":
                    if (txtVisor.Text == "")
                    {
                        txtVisor.Text += "0,";
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;
                default:
                    break;
            }

        }
    }
}