using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Apresentar o valor de uma potência de uma base qualquer, elevada a um expoente qualquer.

            Console.WriteLine("Digite o número da base: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do expoente: ");
            int exp = int.Parse(Console.ReadLine());

            double result = Math.Pow(num, exp);


            Console.WriteLine($"{num} elevado a {exp} = {result}");
        }
    }
}
