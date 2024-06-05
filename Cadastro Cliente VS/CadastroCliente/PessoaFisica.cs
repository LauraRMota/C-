using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public class PessoaFisica : Pessoa
    {
        private string nome, endereco, RG, CPF;
        public override void GravarPessoa(string nome, string endereco, string documento1, string documento2)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.RG = documento1;
            this.CPF = documento2;
        }
        public string MostrarNome()
        {
            return nome;
        }
        public string MostrarEndereco() // posso mostrar outro? eu queria entedesisteo que?desisti de escrever entender
        {
            return endereco;
        }
        public string MostrarDocumento1()
        {
            return RG;
        }
        public string MostrarDocumento2()
        {
            return CPF;
        }
    }
}
