using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultorio
{
    internal class Paciente
    {
        public string Nome;
        public int Codigo;
        public string DataNascimento;

        public Paciente(int codigo)
        {
            this.Codigo = codigo;
        }
    }
}
