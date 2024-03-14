using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carroLavajato
{
    internal class LavaJato
    {
        private Queue<Carro> listaEspera;
        private Dictionary<int,Carro> patio;

        public LavaJato() 
        { 
            this.listaEspera = new Queue<Carro>();
            this.patio = new Dictionary<int, Carro>();
        }

        public void adicionarFila(Carro carro)
        {
            this.listaEspera.Enqueue(carro);
        }

        public bool lavar()
        {
            if (listaEspera.Count > 0)
            {
                this.patio.Add(this.listaEspera.Peek().Id, this.listaEspera.Dequeue());
                return true;
            }
            else
                return false;
        }

        public bool entregar(int id)
        {
            return this.patio.Remove(id);
        }
    }
}
