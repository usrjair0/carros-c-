using carroLavajato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LavaJato lavajato = new LavaJato();

            int idCarro = 0;
            bool sair = false;

            do
            {
                Console.WriteLine("[1] - Adicionar carro na fila de lavagem");
                Console.WriteLine("[2] - Lavar carro da fila de lavagem");
                Console.WriteLine("[3] - Retirar carro do pátio");
                Console.WriteLine("[4] - Sair do lava jato");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Qual o nome do carro?");
                        Carro carro = new Carro();
                        carro.Name = Console.ReadLine();

                        carro.Id = ++idCarro;
                        lavajato.adicionarFila(carro);
                        Console.WriteLine($"Seu carro possui o id: {idCarro}");

                        Console.WriteLine("Carro adicionado na fila!");
                        Console.WriteLine("Pressione Enter para continuar");
                        Console.ReadLine();
                        break;


                    case 2:

                        if (lavajato.lavar())
                            Console.WriteLine("Carro lavado com sucesso.");
                        else
                            Console.WriteLine("Sem carro na fila.");

                        Console.WriteLine("Pressione Enter para continuar.");
                        Console.ReadLine();

                        break;


                    case 3:
                        Console.WriteLine("Informe o Id do carro: ");
                        int id = int.Parse(Console.ReadLine());

                        if (lavajato.entregar(id))
                            Console.WriteLine("Carro entregue.");
                        else
                            Console.WriteLine("carro não encontrado");

                        Console.WriteLine("Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case 4:
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("opção Inválida");
                        Console.WriteLine("Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();

            } while (!sair);

            Console.WriteLine("Pressione Enter para sair");
            Console.ReadLine();
        }
    }
}
