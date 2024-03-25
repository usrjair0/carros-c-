﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consultorio
{
    internal class Consulta
    {
        public int Codigo { get;}
        public DateTime DataHora { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }


        public Consulta (int codigo)
        {
            this.Codigo = codigo;
        }
    }
}
