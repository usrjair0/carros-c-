using System.Collections.Generic;

namespace JogodeTiroProfessor
{
    internal class Personagem
    {
        public string Nome { get; set; }

        public string Time { get; set; }

        private List<Arma> armas;
        private List<Acessorio> acessorios;

        public Personagem() 
        { 
            this.armas = new List<Arma>();
            this.acessorios = new List<Acessorio>();
        }

        public void adicionarInventario(Arma arma)
        {
            this.armas.Add(arma);
        }

        public void adicionarInventario(Acessorio acessorio)
        {
            this.acessorios.Add(acessorio);
        }
    }
}
