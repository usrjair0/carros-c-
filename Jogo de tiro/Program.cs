using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_tiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador = new Personagem("Terrorista");
            jogador.Faccao = "Contraterrorista";


            Console.WriteLine("Pressione Enter para encerrar");
            Console.ReadLine();
        }
    }
}
