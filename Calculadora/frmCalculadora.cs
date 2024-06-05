namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e) // evnto click dos botões
        {

            if (txtVisor.Text == "0") // se o visor estiver com o número 0

            {
                txtVisor.Clear(); // é para limpá-lo
            }

            Button botaoAcionado = (Button)sender; // o objeto botão que foi clicado será carregado no botaoAcionado

            switch (botaoAcionado.Name) // verifica o nome do botão acionado
            {
                case "btn1": // caso seja btn1
                    txtVisor.Text += "1"; // a propriedade text do visor receberá número 1
                    break; // parar a verificação

                case "btn2": // os próximos casos verificam qual foi o botão acionado e envia para a
                    txtVisor.Text += "2"; // propriedade text do mesmo, o número relacionado a ele.
                    break; // após a detecção de qual botão foi acionado, a verificação é finalizada

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