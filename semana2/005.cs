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
            /*
             * Escreva um programa que solicite ao usuário dois números e exiba a soma,
             * subtração, multiplicação e divisão entre eles */

            Console.WriteLine("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            float soma = n1 + n2;
            float subtracao = n1 - n2;
            float multiplicacao = n1 * n2;
            float divisao = n1 / n2;

            Console.WriteLine(" --- Resultado --- ");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");  
        }
    }
}
