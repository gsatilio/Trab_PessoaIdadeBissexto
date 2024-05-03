using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_PessoaIdadeBissexto
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string profissao;

        public Pessoa(string nome, int idade, string profissao)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }

        public string getNome()
        {
            return this.nome;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public string getProfissao()
        {
            return this.profissao;
        }
    }
}
