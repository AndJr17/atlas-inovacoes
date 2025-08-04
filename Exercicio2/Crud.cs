using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAssistenteDev.Exercicio2
{
    public class Crud
    {
        private List<String> nomes = new List<string>();

        public void AdicionarNome(string nome)
        {
            nomes.Add(nome);
            Console.WriteLine("Nome adicionado");
        }

        public void RemoverNome(string nome)
        {
            if (nomes.Remove(nome))
            {
                Console.WriteLine("Nome removido");
            }
            else
            {
                Console.WriteLine("Nome não encontrado");
            }
        }

        public void ListarNomes()
        {
            Console.WriteLine("--- NOMES ---");

            if (nomes.Count == 0)
            {
                Console.WriteLine("Nenhum nome castrado");
                return;
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }


    }
}