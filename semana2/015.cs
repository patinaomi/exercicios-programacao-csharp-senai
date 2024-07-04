using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que imprima na tela a tabuada de todos os números de 1 a 10.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"--- Tabuada do {i} ---");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
                Console.WriteLine();
            }

        }
    }
}
