using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pais
{
    internal class Pais
    {
        public string Nome { get; set; }

        public string NomeCapital { get; set;}

        public double DimensaoKM2 { get; set; }


        //O método construtor está sobrecarregado, veja que chamei ele duas vezes, uma passando parâmetros e no outro não.
        //Sobrecarga - os metodos tem o mesmo nome com diferentes assinaturas e estão na mesma classe.
        //Assinatura - nome do método + quantidade ou ordem (tipo de dado) de parâmetros.

        public Pais()
        {

        }

        public Pais (string nome , string nomecapital,  double dimensaoKM2)
        {
            this.Nome = nome;
            this.NomeCapital = nomecapital;
            this.DimensaoKM2 = dimensaoKM2;
        }

        //recursividade função que chama a si mesmo

        public bool igual(Pais pais)
        {
            return this.Nome == pais.Nome && this.NomeCapital == pais.NomeCapital; 
            //retorna verdeiro ou falso     
        }

    }
}
