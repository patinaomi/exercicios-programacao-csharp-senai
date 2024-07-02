    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Escolha uma opção:\n[1] Ônibus\n[2] Bike\n[3] Táxi\n[4] Trem\n[5] Outros");

                try
                {
                    int op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Ônibus");
                            break;

                        case 2:
                            Console.WriteLine("Bike");
                            break;

                        case 3:
                            Console.WriteLine("Táxi");
                            break;

                        case 4:
                            Console.WriteLine("Trem");
                            break;

                        case 5:
                            Console.WriteLine("Outros");
                            break;

                        default:
                            Console.WriteLine("Nenhuma das opções");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
            }
        }
    }
