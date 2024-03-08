using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pais Brasil = new Pais();

            Pais zequinha = new Pais("zequinha", "zecolandia", 56000);

            if (Brasil.igual(zequinha))
                Console.WriteLine("Paises são iguais");
            else 
                Console.WriteLine("países são diferentes");
        }
    }
}
