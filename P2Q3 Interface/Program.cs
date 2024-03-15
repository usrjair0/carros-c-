using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Q3_Interface
{
    interface IProgramador
    {
        void programar();
    }

    interface IAnalista
    {
        void analisar();
    }

    public class Aluno: IProgramador, IAnalista
    {
        public void analisar()
        {

        }
        public void programar()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
