using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreve uma função que receba o lado de um quadrado e retorne sua área (A = lado²)
            double areaQuadrado(double x)
            {
                double area = x * x;
                return area;
            }

            Console.Write("Digite o lado de um quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área: {areaQuadrado(lado)}");
        }
    }
}
