using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeTiroProfessor
{
    internal class Arma
    {
        public string Nome { get; }

        //Esse protected me permite usar tanto na classe Arma quanto na sua herança Arma de fogo
        //protected int Dano { get; set; }
        public int Dano { get; set; }

        public Arma(string nome)
        {
            this.Nome = nome;
            this.Dano = 1;
        }

    }
}
