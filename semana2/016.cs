using System;
using System.Collections;
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
            // Desenvolva um programa para criar uma lista de compras

            ArrayList listaDeCompras = new ArrayList();
            string item = "teste";
            int op = 0;
            int cont = 1;

            while (true)
            {
                Console.WriteLine("\n--- LISTA DE COMPRAS ---");
                Console.WriteLine("[1] Adicionar item");
                Console.WriteLine("[2] Listar item");
                Console.WriteLine("[3] Alterar item");
                Console.WriteLine("[4] Deletar item");
                Console.WriteLine("[5] Limpar lista");
                Console.WriteLine("[0] Sair do Programa");
                Console.Write("Digite uma opção: ");

                try
                {
                    op = int.Parse(Console.ReadLine());

                } catch (Exception e) {
                    Console.WriteLine("Erro: " + e.Message);
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\n---* Adicionar Items *---");
                        Console.WriteLine("Digite o item ou deixe em branco para finalizar.\n");
                        while (item != "")
                        {
                            Console.Write($"Digite o {cont}º item da lista: ");
                            item = Console.ReadLine();
                            if (item == "")
                            {
                                break;
                            }

                            listaDeCompras.Add(item);
                            cont++;
                            
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n---* Listar Items *---");
                        if(listaDeCompras.Count == 0)
                        {
                            Console.WriteLine("Não há itens na lista.");
                        } 
                        else
                        {
                            int num = 1;
                            foreach (string i in listaDeCompras)
                            {
                                Console.WriteLine($"{num}. {i}");
                                num++;
                            };
                        }

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("\n---* Deletar Itens *---");
                        if (listaDeCompras.Count == 0)
                        {
                            Console.WriteLine("Não há itens na lista.");
                        }
                        else
                        {
                            int num = 1;
                            foreach (string i in listaDeCompras)
                            {
                                Console.WriteLine($"{num}. {i}");
                                num++;
                            };
                        }
                        Console.WriteLine("Digite o número do item que deseja deletar: ");
                        // int opDeletar = int.Parse(Console.ReadLine());
                        string opcao = Console.ReadLine();

                        foreach (string i in listaDeCompras)
                        {
                            if (listaDeCompras.Contains(opcao))
                            {
                                Console.WriteLine(i);
                                Console.WriteLine(listaDeCompras.IndexOf(i));
                                int indice = listaDeCompras.IndexOf(i);
                                Console.WriteLine(indice);
                                listaDeCompras.Remove(opcao);
                            }
                        };

                        break;
                    case 5:
                        if (listaDeCompras.Count == 0)
                        {
                            Console.WriteLine("Não há itens na lista.");
                        }
                        else
                        {
                            listaDeCompras.Clear();
                            Console.WriteLine("Limpando lista!");
                        }
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }




            


        }
    }
}
