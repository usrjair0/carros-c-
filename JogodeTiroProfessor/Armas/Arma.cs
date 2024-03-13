using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeTiroProfessor
{
    internal abstract class Arma
    //Nenhum objeto pode ser instanciado a partir dessa class
    {
        public string Nome { get; }

        //Esse protected me permite usar tanto na classe Arma quanto na sua herança Arma de fogo
        //protected int Dano { get; set; }
        public int Dano { get; set; }

        private static int contador = 0;
        //Estático é algo que pode mudar independente da referência.
        //Caso não usassemos isso, nosso contador não funcionaria da forma que gostariamos
        //O estatic fica fora da instancia da classe
        //Ele é compartilhado entre instâncias, pois ele não pertence a cada instância
        //ele pertence a classe.
        public Arma(string nome)
        {
            contador++; //Não é possivel utilizar o this, pois não temos ref de instância.
            this.Nome = nome;
            this.Dano = 1;
        }

        public static int getContador() //para a classe
            //usei assim para que no meu program eu chame Arma.getContador()
        {
            return contador;
        }

        //public int getContador() //para a instância                         
        //{
        //    return contador;
        //}

    }
}
