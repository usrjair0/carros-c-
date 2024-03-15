using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Q1Contas
{
    internal class Conta
    {
        public DateTime Data { get; }
        public double Valor { get; set; }
        public Conta(DateTime data, double valor)
        {
            this.Data = data;
            this.Valor = valor;
        }
    }
    internal class Contas
    {
        private List<Conta> ListaContas;

        public double getValorTotal()
        {
            double ValorTotal = 0;
            foreach (var conta in ListaContas)
            {
                ValorTotal += conta.Valor;
            }
            return ValorTotal;
        }

        public void adicionar(Conta conta)
        {
            this.ListaContas.Add(conta);
        }

        public Contas()
        {
            this.ListaContas = new List<Conta>();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Contas contas = new Contas();

            Conta conta1 = new Conta(new DateTime(2004, 09, 02), 200);
            contas.adicionar(conta1);

            Conta conta2 = new Conta(new DateTime(2004, 09, 03), 300);
            contas.adicionar(conta2);

            Conta conta3 = new Conta(new DateTime(2004, 09, 04), 400);
            contas.adicionar(conta3);

            Console.WriteLine(contas.getValorTotal());
            Console.ReadLine();
        }
    }
}
