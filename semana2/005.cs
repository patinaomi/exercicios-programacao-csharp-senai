using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que calcule a média aritmética de dois números.

             Console.WriteLine("-- Cálculo de Média --");
             Console.WriteLine("Digite um número: ");
             float n1 = float.Parse(Console.ReadLine());
            
             Console.WriteLine("Digite o segundo número: ");
             float n2 = float.Parse(Console.ReadLine());
            
             float media = (n1 + n2) / 2;
             Console.WriteLine("Média: " + media);
             Console.WriteLine($"Média: {media}"); 
        }
    }
}
