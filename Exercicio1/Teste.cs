using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAssistenteDev.Exercicio1
{
    class Teste
    {

        static void Main(string[] args)
        {

            Produto produto1 = new Produto("Lápis", 2.99m, 25);
            Produto produto2 = new Produto("Caderno", 21.99m, 15);

            produto1.Vender(10);
            produto2.Vender(20);

            Console.WriteLine(produto1);
            Console.WriteLine(produto2);
        }
    }
}