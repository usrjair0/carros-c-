﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta
{
    internal class Porta
    {
        private bool aberta;
        private string cor;

        public double AreaM2 { get; set; }

        public Porta() 
        { 
            this.aberta = false;
            this.cor = "branca";
        }

        public void abrir()
        {
            this.aberta = true;
        }

        public void fechar()
        {
            this.aberta = false;
        }

        public void pintar(string cor)
        {
            this.cor = cor;
        }
    }
}
