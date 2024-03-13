using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeTiroProfessor
{
    internal class ArmadeFogo:Arma
    {

        public int AlcanceLinear { get; }

        public ArmadeFogo(string nome, int alcance)
            :base(nome)
        {
            this.AlcanceLinear = alcance;
        }
    }
}
