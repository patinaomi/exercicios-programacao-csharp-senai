using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conta
    {
        
        // Atributos
        private string numero { get; set; }
        private double saldo { get; set; }

        // Construtor
        public Conta()
        {

        }

        public Conta(string numero)
        {
            this.numero = numero;
            this.saldo = 0;
        }

        // Getters & Setters
        public string getNumero()
        {
            return numero;
        }
        public double getSaldo()
        {
            return saldo;
        }


        // Métodos
        public void ConsultarConta(string numero)
        {
            Console.WriteLine($"Número da conta: {this.numero}\n" +
                              $"Saldo R${this.saldo,2}");
        }

        public double Depositar(string numero)
        {
            Console.Write("Digite o valor que deseja depositar: ");
            double valor = double.Parse(Console.ReadLine());

            if(valor <= 0)
            {
                Console.WriteLine("Valor inválido");
                return valor;
            } 
            else
            {
                Console.WriteLine("Depósito realizado com sucesso!");
                double valorAtualizado = this.saldo += valor;
                Console.WriteLine($"Saldo atualizado: R${valorAtualizado}");
                return valorAtualizado;
            }
        }
        public double Sacar(string numero)
        {
            Console.Write("Digite o valor que deseja sacar: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido");
                return this.saldo;
            } 
            else if (this.saldo > valor)
            {
                Console.WriteLine("Saque efetuado com sucesso!");
                Console.WriteLine(this.saldo);
                return this.saldo -= valor;
            } else
            {
                Console.WriteLine("Saldo insuficiente: R$" + this.saldo);
                return this.saldo;
            }

        }


    }
}
