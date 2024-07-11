using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente
    {
        
        // Atributos
        private string nome { get; set; }
        private string cpf { get; set; }
        private string numConta { get; set; }

        // Construtores
        public Cliente()
        {

        }

        public Cliente(string nome, string cpf)
        {
            Random r = new Random();
            int num = r.Next(9999);
            int op = r.Next(10);

            this.nome = nome;
            this.cpf = cpf;
            this.numConta = string.Concat(num + "-" + op);
        }

        public void ConsultarCliente()
        {
            Console.WriteLine($"Nome do Cliente: {this.nome}\n" +
                              $"CPF: {this.cpf}\n" +
                              $"Conta: {this.numConta}");
        }

        public string getNome() { return nome; }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf() { return cpf; }

        public void setCpf(string cpf)
            { this.cpf = cpf; }

        public string getNumConta() { return numConta; }

        ~Cliente() 
        {
            Console.WriteLine($"Destrutor Executado para cliente: {this.nome}");
            Console.ReadKey();
        }
    }
}
