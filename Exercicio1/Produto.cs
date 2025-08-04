using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAssistenteDev.Exercicio1
{
    public class Produto
    {

        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, decimal preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void Vender(int quantidade)
        {
            if (quantidade <= 0)
            {
                Console.WriteLine("Operação inválida: ");
                Console.WriteLine("A quantidade deve ser maior que zero");
                return;
            }

            if (quantidade <= Estoque)
            {
                Console.WriteLine($"Venda efetudada: {quantidade} unidades de {Nome}.");
            }
            else
            {
                Console.WriteLine($"Estoque insuficiente, quantidade disponível: {Estoque}");
            }



        }
        public override string ToString()
        {
            return $"Produto: {Nome}, Preço: R${Preco:F2}, Estoque: {Estoque} unidades";
        }
    }
}