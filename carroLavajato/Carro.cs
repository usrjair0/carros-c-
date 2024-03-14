using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carroLavajato
{
    internal class Carro : ICarro
    {
        public int Id {  get; set; }

        public string Name { get; set; }


        public Carro() 
        {

        }

        public Carro(string name, int id) 
        { 
            this.Name = name;
            this.Id = id;
        }

    }
}
