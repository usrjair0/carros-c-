using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultorio
{
    internal class Medico
    {
        public string CRM { get; set; }

        public string Nome { get; set;}

        public List<string> Especialidade { get; set; }

        public Medico(string crm)
        {
            this.CRM = crm;
            this.Especialidade = new List<string>();
        }
    }
}
