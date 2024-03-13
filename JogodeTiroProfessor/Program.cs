using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeTiroProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArmaBranca faca = new ArmaBranca("facax");

            //Foi utilizada a herança na construção
            //ArmadeFogo pistola = new ArmadeFogo("pistolaX", 10);
            //pistola.Dano = 5;

            ArmadeFogo metralhadora = new ArmadeFogo("MetralhadoraJJ", 200);
            metralhadora.Dano = 20;

            ArmaExplosiva bomba = new ArmaExplosiva("Bombão", 10, 10);

            Console.WriteLine($"Número de armas: {Arma.getContador()}");


            Personagem p1 = new Personagem();
            p1.Nome = "Zequinha";
            p1.Time = "Terrorista";
            p1.adicionarInventario(faca);
        }
    }
}
