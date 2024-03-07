using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Porta porta = new Porta();

            porta.abrir();
            porta.fechar();
            porta.pintar("amarela");
            porta.pintar("azul");
            porta.pintar("vermelha");
            Console.ReadLine();

        }
    }
}
