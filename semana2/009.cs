    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp3
    {
        internal class Program
        {
        static void Main(string[] args)
        {

            // Faça um programa que solicite a idade de uma pessoa e exiba se ela é maior de idade ou não.

            while (true)
            {
                Console.WriteLine("Digite sua idade: ");
                try
                {
                    int idade = int.Parse(Console.ReadLine());

                    if (idade == 0) 
                    {
                        break;
                    } 
                    else if(idade > 0 && idade < 18)
                    {
                        Console.WriteLine($"Idade {idade}, MENOR de idade");
                    }
                    else if (idade >= 18)
                    {
                        Console.WriteLine($"Idade {idade}, MAIOR de idade");
                    }
                    else
                    {
                        Console.WriteLine($"Idade {idade} inválida");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}");
                }
            }
        }
        }
    }
