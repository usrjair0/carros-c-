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
        public DateTime DataNascimento { get; set; }
        public int Idade {
            get
            {
                return DateTime.Now.Year - this.DataNascimento.Year; 
                //Melhorar o cálculo da idade.
            }        
        }

        public Paciente(int codigo)
        {
            this.Codigo = codigo;
        }
    }
}
