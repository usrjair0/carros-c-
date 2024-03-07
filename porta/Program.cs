using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porta
{
    internal class Program
    {
        class Porta
        {
            private bool aberta;
            private string cor;

            public Porta()
            {
                this.aberta = false;
                this.cor = "branca";
            }

            public void abrir()
            {
                this.aberta = true;
            }

            public void fechar()
            {
                this.aberta = false;
            }

            public void pintar(string cor)
            {
                this.cor = cor;
            }
        }
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
