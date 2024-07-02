    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp4
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Escolha a sua estação do ano favorita: \n[P] Primavera\n[V] Verão\n[O] Outono\n[I] Inverno");
                string resp = Console.ReadLine();
                char resp1 = Convert.ToChar(resp.ToUpper());

                switch (resp1)
                {
                    case 'P':
                        Console.WriteLine("Primavera");
                        break;
                    case 'V':
                        Console.WriteLine("Verão");
                        break;
                    case 'O':
                        Console.WriteLine("Outono");
                        break;
                    case 'I':
                        Console.WriteLine("Inverno");
                        break;
                    default:
                        Console.WriteLine("Você escolheu todas as opções!!");
                        break;
                }
            }
        }
    }
