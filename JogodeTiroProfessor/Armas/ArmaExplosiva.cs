using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeTiroProfessor
{
    internal sealed class ArmaExplosiva:ArmadeFogo
        //Ela é meu ultimo nível de herança, ninguém pode usar ela 
    {
        public int RaioExplosao { get; }

        public ArmaExplosiva(string nome, int alcanceLinear, int raioExplosao)
            :base(nome, alcanceLinear)
        {
            this.RaioExplosao = raioExplosao;
        }
    }
}
