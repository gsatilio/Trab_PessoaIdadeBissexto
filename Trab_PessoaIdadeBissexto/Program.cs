using System;
using Trab_PessoaIdadeBissexto;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc = -1;
        PilhaPessoa pilha = new PilhaPessoa();
        do
        {
            Console.WriteLine("1 - Criar Pessoa e inserir na Pilha");
            Console.WriteLine("2 - Retornar resultados da Pilha");
            opc = int.Parse(Console.ReadLine());
            switch(opc)
            {
                case 0:
                    Console.WriteLine("Finalizando programa");
                    Console.ReadKey();
                    break;
                case 1:
                    pilha.push(criarPessoa());
                    break;
                case 2:
                    Console.WriteLine(pilha.print());
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;

            }
        } while (opc != 0);
    }
    static Pessoa criarPessoa()
    {
        Pessoa temp;
        string nome, profissao;
        int idade;
        Console.WriteLine("Informe o nome da pessoa");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a idade da pessoa");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a profissao da pessoa");
        profissao = Console.ReadLine();
        temp = new Pessoa(nome, idade, profissao);

        return temp;
    }
    static void retornarDados(Pessoa p)
    {
        int idade = 0, idadeaux = 0, anonascimento = 0;
        Console.WriteLine("Nome: " + p.getNome());
        Console.WriteLine("Idade: " + p.getIdade());
        Console.WriteLine("Profissão: " + p.getProfissao());
        idade = p.getIdade();
        anonascimento = (DateTime.Now.Year - idade);

        for(int i = 0; i <= idade; i++)
        {
            if(DateTime.DaysInMonth(anonascimento, 02) == 29)
            {
                idadeaux++;
            }
            anonascimento++;
        }
        Console.WriteLine("Idade em Anos Bissextos: " + idadeaux);
    }
}
