    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp5
    {
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Fazer um programa que efetue a leitura de 10 valores numéricos e apresente no final o total do 
             * somatório e a média dos valores lidos. 
             */

            int[] lista = new int[10];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write("Digite um número: ");
                lista[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nElementos da lista:");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($"[{lista[i]}] ");

            }

            Console.WriteLine($"\nSoma dos elementos da lista: {lista.Sum()}");
            Console.WriteLine($"Média dos elementos da lista: {lista.Average()}");


            // Exercício Sem utilizar os métodos

            double soma = 0;
            double media = 0;
            int qtd = 0;

            for(int i = 0;i < lista.Length; i++)
            {
                soma += lista[i];
                qtd ++;
            }

            media = soma / qtd;

            Console.WriteLine($"\nSoma dos elementos da lista: {soma}");
            Console.WriteLine($"Média dos elementos da lista: {media}");

        }
    }

    }
