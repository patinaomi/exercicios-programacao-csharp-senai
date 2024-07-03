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
             * Desenvolva um programa para criar uma lista de compras, conforme o input do usuário.
             * Ao fim da lista, ordenar e imprimir cada item da lista, linha a linha. 
             */

            Console.Write("Digite a quantidade de items da lista: ");
            int quantidade = int.Parse(Console.ReadLine());
            int cont = 0; // Contador pra poder iterar na lista

            string[] listaDeCompras = new string[quantidade]; // Aqui a lista fica do tamanho da qtd que o usuário quer

            while (cont < quantidade)
            {
                Console.Write("Digite um novo item da lista: ");
                listaDeCompras[cont] = Console.ReadLine();
                cont++;
                
            }

            Array.Sort(listaDeCompras); //Aqui ordenamos a lista de compras em ordem alfabética

            for(int i = 0; i< listaDeCompras.Length; i++)
            {
                Console.WriteLine($"[{i+1}] - {listaDeCompras[i]}"); //Apresentamos a lista, fiz i+1 pra não começar do zero
            }

            }
        }

        }
