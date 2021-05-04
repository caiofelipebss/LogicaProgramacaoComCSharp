using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Composta 
            /*
            Console.WriteLine("Entre com um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Este número é par! ");
            } else
            {
                Console.WriteLine("Este número é ímpar!" );
            }
            */

            // Encadeamentos

            Console.WriteLine("Entre com a hora atual (ex: 1, 9, 24): ");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora < 12)
            {
                Console.WriteLine("Bom dia! ");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora >= 18 && hora <= 24)
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
