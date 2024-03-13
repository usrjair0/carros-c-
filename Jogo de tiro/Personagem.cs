using System;

namespace Jogo_de_tiro
{
    internal class Personagem
    {
        private string faccao;

        public string Faccao {
            get
            {
                return this.faccao;
            }
            set
            {
                if (value != "Terrorista" && value != "Contraterrorista")
                    throw new ArgumentException("Escolha inválida.");
                else
                    this.faccao = value;   
            }        
        }

        public Personagem()
        {

        }

        //Construtor
        public Personagem(string Faccao) 
        { 
            this.faccao = Faccao;
        }
    }

}
