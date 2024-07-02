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

            //Usando operador ternário
            Console.WriteLine("Digite V ou F: ");
            char resp1 = Convert.ToChar(Console.ReadLine());
            string msg = (resp1 == 'V') ? "Verdadeiro" : "Falso";
            Console.WriteLine($"Opção: {msg}");

            while (true)
            {
                Console.WriteLine("Digite V ou F: ");
                string resp = Console.ReadLine();
            
                if (Convert.ToChar(resp) == 'V')
                {
                    Console.WriteLine("Verdadeiro");
                }
                else if (Convert.ToChar(resp) == 'F')
                {
                    Console.WriteLine("Falso");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }

        }
    }
}
