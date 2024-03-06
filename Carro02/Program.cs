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

        public Carro() //Aqui estou criando uma instancia toda vez que faço um new ele passa por aqui.
            //deve ter o mesmo nome da class
            //importante para definir os valores padrões do seu objeto
        {
            this.potencia = 1.6;
            this.numeroDePortas = 2;
            this.cor = string.Empty;
            this.nome = "ferrari";
            this.velocidade = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //ferrari => variável => objeto (recebe um endereço de memória - heap)
            Carro ferrari = new Carro(); //new é uma palavra reservada do c# para invocar o método construtor
            ferrari.potencia = 10; 

            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            List < Carro > carros = new List<Carro>();

            for(int i = 0; i< 5; i++ )
            {
                Carro carro = new Carro();
                carros.Add(carro);
            }

            ferrari.nome = "Ferrari do zequinha";

            carros[2].nome = "fusca";
        }
    }
}
