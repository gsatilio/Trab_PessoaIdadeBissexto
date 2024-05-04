using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_PessoaIdadeBissexto
{
    internal class PilhaPessoa
    {
        Pessoa topo;

        public PilhaPessoa()
        {
            topo = null;
        }
        public void push(Pessoa aux)
        {
            if (vazia() == true)
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }
        public void pop()
        {
            if (!vazia())
            {
                topo = topo.getAnterior();
            }
        }
        public int getContador()
        {
            int contador = 0;
            Pessoa aux = topo;
            if (!vazia())
            {
                do
                {
                    contador++;
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            return contador;
        }
        bool vazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string print()
        {
            Pessoa aux = topo;
            string texto = "";
            if (!vazia())
            {
                texto = "Topo da Pilha";
                do
                {
                    texto += $"\n{aux.ToString()} ";
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            return texto;
        }
    }
}
