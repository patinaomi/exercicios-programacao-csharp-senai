using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa que solicite ao usuário dois números e exiba: Adição,
             * Subtração, Multiplicação e Divisão entre esses números conforme a
             * escolha do usuário.
             */

            int op = 0;
            double num1 = 0;
            double num2 = 0;

            double somar(double n1, double n2)
            {
                return n1 + n2;
            }

            double subtrair(double n1, double n2)
            {
                return n1 - n2;
            }

            double multiplicar(double n1, double n2)
            {
                return n1 * n2;
            }

            double dividir(double n1, double n2)
            {
                try
                {
                    return n1 / n2;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    return 0;
                }
            }

                    


            while (true)
            {
                Console.WriteLine("--- Calculadora ---");
                try
                {
                    Console.Write("Digite o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                } 
                catch(Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    continue;
                }
                Console.WriteLine("[1] Adição");
                Console.WriteLine("[2] Subtração");
                Console.WriteLine("[3] Multiplicação");
                Console.WriteLine("[4] Divisão");
                Console.WriteLine("[0] Sair do Programa");
                Console.Write("Escolha uma opção: ");
                try
                {
                    op = int.Parse(Console.ReadLine());   
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                    continue;
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine("-- Adição --");
                            Console.WriteLine($"{num1} + {num2} = {somar(num1, num2)}\n");
                        break;
                    case 2:
                        Console.WriteLine("-- Subtração --");
                        Console.WriteLine($"{num1} - {num2} = {subtrair(num1, num2)}\n");
                        break;
                    case 3:
                        Console.WriteLine("-- Multiplicação --");
                        Console.WriteLine($"{num1} X {num2} = {multiplicar(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine("-- Divisão --");
                        double result =  dividir(num1, num2);

                        if(result == 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{num1} / {num2} = {dividir(num1, num2)}");
                        }

                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        Environment.Exit(0);
                        break;               
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }

        }
    }
}
