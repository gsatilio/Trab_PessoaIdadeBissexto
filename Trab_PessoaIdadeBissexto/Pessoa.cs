using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Trab_PessoaIdadeBissexto
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string profissao;
        Pessoa anterior;

        public Pessoa(string nome, int idade, string profissao)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }

        public void setAnterior(Pessoa aux)
        {
            this.anterior = aux;
        }
        public Pessoa getAnterior()
        {
            return this.anterior;
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
        public string getAnoBissexto()
        {
            int idade = 0, idadeaux = 0, anonascimento = 0;
            idade = this.getIdade();
            anonascimento = (DateTime.Now.Year - idade);
            for (int i = 0; i <= idade; i++)
            {
                if (DateTime.DaysInMonth(anonascimento, 02) == 29)
                {
                    idadeaux++;
                }
                anonascimento++;
            }
            return " - Idade em Anos Bissextos: " + idadeaux;
        }
        public override string? ToString()
        {
            return "Nome: " + nome + " Idade: " + idade + " Profissão: " + profissao + getAnoBissexto();
        }
    }
}
