using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAssistenteDev.Exercicio2
{
    public class Teste
    {
        static void Main(String[] args)
        {
            Crud crud = new Crud();

            while (true)
            {
                Menu();

                string? opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome para adicionar: ");
                        string? nomeAdicionar = Console.ReadLine()!;
                        crud.AdicionarNome(nomeAdicionar);
                        break;
                    case "2":
                        Console.Write("Digite o nome para remover: ");
                        string? nomeRemover = Console.ReadLine()!;
                        crud.RemoverNome(nomeRemover);
                        break;
                    case "3":
                        crud.ListarNomes();
                        break;
                    case "0":
                        Console.WriteLine("Fim do programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("--- CRUD ---");
            Console.WriteLine("1 - Adicionar nome");
            Console.WriteLine("2 - Remover nome");
            Console.WriteLine("3- Lista nomes");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção: ");
        }
    }
}