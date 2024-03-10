using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro02
{
    class Carro 
    {
        private string cor;
        private string nome;
//caso eu deixe como private eu não consigo acessar os meus métodos fora do escopo da classe
        private int velocidade;  
        public int numeroDePortas { get; set; }
        public double potencia { get; set; }

        /*public int numeroDePortas 
        {
            get
            {  
                return thisnumeroDePortas; 
            }

            set
            {
                if (value > 4)
                    throw new ArgumentException("número de portas inválidos");
                this.numeroDePortas = value;
            }
        }*/

        public void acelerar() //método ou função, mas é mais chamado de método
        {
            this.velocidade++; //o this faz referência a struct Carro
        }
        public void frear()
        {
            this.velocidade--;
        }

        public int getVelocidade() 
        { 
            return this.velocidade;
        }

        public void setNome(string nome) //string nome é parâmetro
        {
            //return early
            if (nome.Length > 100)
                throw new ArgumentException("numero de caracteres de nome foi excedido - 100 é o máximo");    
            
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string Cor //é uma convenção deixar como maiúsculo
        {
            //Essa forma é exclusiva do framework
            get 
            { 
                return this.cor; 
            }
            set 
            { 
                this.cor = value; 
            }
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

            //Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            //Carro carro3 = new Carro();

            List < Carro > carros = new List<Carro>();

            for(int i = 0; i< 5; i++ )
            {
                Carro carro = new Carro();
                carros.Add(carro);
            }

            ferrari.setNome("Ferrari do zequinha");

            carros[2].setNome("fusca");
            carros[1].setNome(ferrari.getNome());
            carros[2] = carro2;
            //Nessa parte o carro dentro da lista carros no indice 2 passa a ter o mesmo
            //endereço de memória do objeto instanciado carros2. Logo ao setar o nome
            //chevete em carros[2] eu mudo o nome do carro2.
            carros[2].setNome("chevete");
            carro2.setNome("celtinha chiqueirinho");

            Console.WriteLine($"{carro2.numeroDePortas}");

            carro2.acelerar();
            carro2.getVelocidade();

            ferrari.Cor = "branca"; // como estou atribuindo ele vai passar no método set
            Console.WriteLine($"A cor da ferrari é {ferrari.Cor}");
        }
    }
}
