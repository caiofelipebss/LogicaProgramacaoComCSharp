﻿using System;
using System.Globalization;

namespace MetodoEstaticoNaPropriaClasse
{
    class Program
    {
        static double Pi = 3.14; 
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return (4.0 / 3.0) * Pi * r * r * r; 
        }
    }
}

/*
 Métodos na própria classe do programa: 

- Nota: dentro de um método estático você não pode chamar membros de instância na mesma classe. 

*/