using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro02
{
    class Carro 
    {
        public double potencia;
        public int numeroDePortas;
        public string cor;
        public string nome;
        public int velocidade;
        public void acelerar()
        {
            this.velocidade++; //o this faz referência a struct Carro
        }
        public void frear()
        {
            this.velocidade--;
        }

        public Carro()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.potencia = 10;

        }
    }
}
