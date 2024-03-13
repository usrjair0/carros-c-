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

        public int Dano { get; set; }

        public Arma(string nome)
        {
            this.Nome = nome;
            this.Dano = 0;
        }

    }
}
