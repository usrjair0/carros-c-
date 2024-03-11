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
            Porta p1 = new Porta();
            p1.abrir();
            p1.fechar();
            p1.pintar("amarela");
            p1.pintar("azul");
            p1.pintar("vermelha");

            Porta p2 = new Porta();
            p2.pintar("roxo");

            Porta p3 = p1;
            p3.abrir();

            p1.pintar("verde");
            p1.Area = 5;

            Porta p4 = new Porta();
            p4.Area = p1.Area;


            Console.ReadLine();

        }
    }
}
