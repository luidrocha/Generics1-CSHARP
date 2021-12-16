using System;
using System.Collections.Generic;
using Generics1_Csharp.Service;

namespace Generics1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService print = new PrintService();

            Console.Write(" Entra com a quantidade de Valores a serem lidos: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int x =0; x<qtd; x++ )
            {

                Console.Write($"Digite {x}º valor: ");
                int val = int.Parse(Console.ReadLine());

                print.AddValor(val);

            }

            Console.WriteLine("Primeiro Elemento: " + print.Primeiro());

            Console.WriteLine("Todos os Elemento: ");
             print.Print();

        }
    }
}
