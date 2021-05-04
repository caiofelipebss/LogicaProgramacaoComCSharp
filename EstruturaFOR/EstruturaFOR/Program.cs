using System;

namespace EstruturaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você irá digitar? ");
            int quantidadeN = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= quantidadeN; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("Soma igual a: {0}", soma);
        }
    }
}
