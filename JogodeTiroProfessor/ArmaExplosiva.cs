using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeTiroProfessor
{
    internal class ArmaExplosiva:ArmadeFogo
    {
        public int RaioExplosao { get; }

        public ArmaExplosiva(string nome, int alcanceLinear, int raioExplosao)
            :base(nome, alcanceLinear)
        {
            this.RaioExplosao = raioExplosao;
        }
    }
}
