using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente c1 = new Cliente("Patricia", "123456789");
            //c1.ConsultarCliente();

            //Conta clienteConta = new Conta(c1.getNumConta());

            //clienteConta.ConsultarConta(clienteConta.getNumero());
            //clienteConta.Depositar(clienteConta.getNumero());
            //clienteConta.Sacar(clienteConta.getNumero());


            while (true)
            {
                Console.WriteLine("--- BANCO DA PATI ---");
                Console.WriteLine("[1] Criar Conta");
                Console.WriteLine("[2] Saque");
                Console.WriteLine("[3] Depósito");
                Console.WriteLine("[4] Saldo");
                Console.WriteLine("[0] Encerrar");
                Console.WriteLine("---------------------");
                Console.Write("Digite uma opção: ");

                string op = Console.ReadLine();
                bool sucesso = int.TryParse(op, out int opNum);

                if (sucesso)
                {
                    switch (opNum)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("--- Criar Conta ---");
                            Console.Write("Digite o nome: ");
                            string nome = Console.ReadLine();

                            Console.Write("Digite o CPF: ");
                            string cpf = Console.ReadLine();

                            Cliente c1 = new Cliente(nome, cpf);
                            Console.WriteLine("Conta criada com sucesso!");
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("saque");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("dep");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("saldo");
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Saindo do programa...");
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Digite um número válido");
                }
            }
        }
    }
}
