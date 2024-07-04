using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ //Faça um programa que peça ao usuário um número e depois imprima a tabuada de 1 a 10.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"--- TABUADA DO {num} ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");

            }

        }
    }
}
