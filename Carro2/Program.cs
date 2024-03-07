using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro2
{
    class Carro // Princípio fundamental da OO => Encapsulamento
    {
        //public => modificador de acesso

        
        private string cor;
        private string nome;
        private int velocidade; // atributos => encapsulamento (proteção)

        public int Velocidade { 
            get 
            { 
                return this.velocidade; 
            } 
        }
        
        public int NumeroDePortas { get; set; }
        public double Potencia { get; set; }

        public Carro() //método construtor. //Deve ter o mesmo nome da Classe. //Importante: Definir os valores padrões.
        {
            this.Potencia = 0;
            this.NumeroDePortas = 2;
            this.cor = string.Empty;
            this.nome = "";
            this.velocidade = 0;
        }
        public void acelerar()
        {
            this.velocidade++;
        }

        public void frear() // método
        {
            this.velocidade--;
        }

        //public int getVelocidade()
        //{
        //    return this.velocidade;
        //}

        public void setNome(string nome)
        {
            //return early.
            if (nome.Length > 100)
                throw new ArgumentException("Número de caracteres do nome foi excedido - máximo de 100."); 
            
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string Cor
        { 
            get 
            { 
                return this.cor; 
            } 
            set 
            { 
                this.cor = value; 
            }   
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //ferrari => variável => objeto (recebe um endereço de memória - heap)            
            Carro ferrari = new Carro();  //new => palavra reservada do C# para invocar o método construtor
                        
            Carro carro2 = new Carro();
            
            List<Carro> carros = new List<Carro>();

            for (int i = 0; i < 3; i++)
            {
                Carro carro = new Carro();
                carros.Add(carro);
            }

            ferrari.setNome("Ferrari do Zequinha");

            carros[2].setNome("Fusca");

            carros[1].setNome(ferrari.getNome());

            carros[2] = carro2;

            carros[2].setNome("Chevete");

            carro2.setNome("Celtinha Chiqueirinho");

            carro2.acelerar();

            Console.WriteLine($"A velocidade do carro é {carros[1].Velocidade}");
            Console.WriteLine($"A velocidade do carro2 é {ferrari.Velocidade}");

            ferrari.Cor = "Branca";

            Console.WriteLine($"A cor da ferrari é {ferrari.Cor}");

            ferrari.setNome("aksdjsaklçd akljdklçsajdkçlsa jdkçlsajdklsajçdklsaj dlsajkdsa jdklsajdklsaj dkljçklasjdklasjdskaldj sa kl djsakçldjsaklçd jsakçldjsakçdaskdj kalsçdj açskldjaskçldkaçlsjd ksadjklaçsjdlçkasjdk");


            ferrari.NumeroDePortas = 2;

            //ferrari.velocidade = 56;
            //carro2.velocidade = 10;
        }
    }
}
