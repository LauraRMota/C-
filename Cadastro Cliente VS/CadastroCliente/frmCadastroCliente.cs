using CadastroCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            pnlPessoaFisica.Visible = true; // deixa visível o painel destinado a pessoa fisica
            pnlPessoaJuridica.Visible = false; // deixa invisivel o painel destinado a pessoa juridica
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            pnlPessoaFisica.Visible = false;// deixa invisivel o painel destinado a pessoa fisica
            pnlPessoaJuridica.Visible = true;// deixa visível o painel destinado a pessoa juridica
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pnlPessoaFisica.Visible == true)
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica();
                
                novaPessoaFisica.GravarPessoa(txtNomePF.Text, txtEndereçoPF.Text, txtCPF.Text, txtRG.Text);

                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarNome() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarEndereco() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarDocumento1() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarDocumento2() + "\r\n");

                txtNomePF.Text = string.Empty;
                txtEndereçoPF.Text = string.Empty;
                txtRG.Text = string.Empty;
                txtCPF.Text = string.Empty;
            }
            else
            {
                PessoaJuridica novaPessoaJuridica = new PessoaJuridica (); // instanciando a classe Pessoa Juridica para utilizá-la

                novaPessoaJuridica.GravarPessoa(txtNomePJ.Text, txtEndereçoPJ.Text, txtIE.Text, txtCNPJ.Text);

                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarNome() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarEndereco() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarDocumento1() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarDocumento2() + "\r\n");

                txtNomePJ.Text = string.Empty;
                txtEndereçoPJ.Text = string.Empty;
                txtCNPJ.Text = string.Empty;
                txtIE.Text = string.Empty;
            }
        }
    }
   
} // passo 13 aula 11 do exercicio da apostila é executar e clicar em pessoa juridica

    




