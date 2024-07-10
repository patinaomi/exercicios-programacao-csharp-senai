using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public class Flor
        {
            // Atributos
            private string nome;
            private string cor;

            // Construtores

            // Construtor Vazio
            public Flor()
            {

            }

            // Construtor com parâmetros
            public Flor(string nome, string cor)
            {
                this.nome = nome;
                this.cor = cor;
            }

            // Getters & Setters
            public string getNome()
            {
                return nome;
            }


            public void setNome(string nome)
            {
                this.nome = nome;
            }

            public string getCor()
            {
                return cor;
            }

            public void setCor(string cor)
            {
                this.cor = cor;
            }


        }
        static void Main(string[] args)
        {

            Flor f = new Flor();
            f.setNome("Tulipa");
            f.setCor("Rosa");

            Console.WriteLine($"A {f.getNome()} é da cor {f.getCor()}");


            Flor f2 = new Flor("Margarida", "Branca");
            Console.WriteLine($"A {f2.getNome()} é da cor {f2.getCor()}");

        }
    }
}
