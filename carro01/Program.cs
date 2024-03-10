using System;
using System.Collections.Generic;

namespace carro01
{
    struct Carro //padrão é começar com letra maiúscula. Aqui estou definindo o tipo carro
    {
        //a Struct trabalha com a heap
        //Estou criando um tipo de dado chamado Carro
        //O public é o modificador de acesso, logo consigo acessar ele dentro do meu Main
        public double potencia; 
        public int numeroDePortas;
        public string cor;
        public string nome;
        public int velocidade;
        

        //Criação do construtor.
        //public Carro(double potencia, int numeroDePortas, string cor, string nome, int velocidade)
        //{
        //    this.potencia = potencia;
        //    this.numeroDePortas = 0;
        //    this.cor = "";
        //    this.nome = "";
        //    this.velocidade = 0;
        //}  não precisaria dessa linha, mas poderia criar

        public void acelerar() 
        {
            this.velocidade++; //o this faz referência a struct Carro
        }
        public void frear()
        {
            this.velocidade--;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region variáveis
            double carro1Potencia = 1.4;
            int carro1NumeroDePortas = 2;
            string carro1Cor = "branca";
            string carro1Nome = "gol";

            double carro2Potencia = 1.6;
            int carro2NumeroDePortas = 2;
            string carro2Cor = "branca";
            string carro2Nome = "gol";

            #endregion fimVariaveis

            #region Listas
            List<double> potencias = new List<double>();
            potencias.Add(1.4);
            potencias.Add(1.6);

            List<int> numeroDePortas = new List<int>();
            potencias.Add(2);
            potencias.Add(4);

            List<string> cores = new List<string>();
            cores.Add("branca");
            cores.Add("vermelha");

            List<string> nomes = new List<string>();
            nomes.Add("gol");
            nomes.Add("ferrari");
            #endregion fimListas

            #region Estrutura
            //Após definir o tipo Carro
            //se eu definir o carro1 por completo eu posso dispensar o new Carro()
            Carro carro1;
            carro1.potencia = 1.4;
            carro1.numeroDePortas = 2;
            carro1.cor = "branco";
            carro1.nome = "gol";

            //se eu definir o carro2 por completo eu posso dispensar o new Carro()
            Carro carro2 = new Carro();
            carro2.potencia = 1.6;
            carro2.numeroDePortas = 2;
            carro2.cor = "vermelho";
            carro2.nome = "ferrari";
            carro2.velocidade = 0;
            carro2.acelerar();

            Carro carro3;

            //A estrutura é um tipo por valor, não um tipo por referência.

            //estrutura (struct é um tipo por valor)
           
            carro3 = carro2;

            carro3.nome = "fusca";


            Carro carro4 = new Carro(); //Agora posso colocar funções dentro dele
            carro2.potencia = 1.6;
            carro2.numeroDePortas = 2;
            carro2.cor = "vermelho";
            carro2.nome = "ferrari";


            List<Carro> carros = new List<Carro>();
            for(int i = 0; i < 5; i++)
            {
                Carro carro = new Carro();
                carro.potencia = 1.4;
                carro.numeroDePortas = 4;
                carro.cor = "branco";
                carro.nome = "gol";
                carro.velocidade = 0;

                //também posso fazer isso, pois fiz o que está escrito na linha 20
                //Carro carro = new Carro(1.4, 4, "branco", "gol", 0);

                //se eu definir o carro por completo eu posso dispensar o new Carro()

                carros.Add(carro);
            }
            #endregion fim_Estrutura
        }
    }
}
