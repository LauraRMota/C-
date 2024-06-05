using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public class PessoaJuridica : Pessoa 
    
        {
            private string nome, endereco, IE, CNPJ;
            public override void GravarPessoa(string nome, string endereco, string documento1, string documento2)
            {
                this.nome = nome;
                this.endereco = endereco;
                this.IE = documento1;
                this.CNPJ = documento2;
            }
            public string MostrarNome()
            {
                return nome;
            }
            public string MostrarEndereco()
            {
                return endereco;
            }
            public string MostrarDocumento1()
            {
                return IE;
            }
            public string MostrarDocumento2()
            {
                return CNPJ;
            }
        }
    }


