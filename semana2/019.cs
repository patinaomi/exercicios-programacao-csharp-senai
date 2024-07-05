using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que imprima na tela a tabuada de todos os números de 1 a 10.

            StreamWriter ARQ = new StreamWriter("C:\\Users\\senai\\Downloads\\pati\\ConsoleApp4\\arq02.txt", true);

            for (int i = 1; i <= 10; i++)
            {

                ARQ.Write($"\n--- Tabuada do {i} ---");
                for (int j = 1; j <= 10; j++)
                {
                    ARQ.Write($"\n{i} X {j} = {i * j}");
                }
                ARQ.Write("\n\n");
            }
            ARQ.Close();
        }
    }
}
