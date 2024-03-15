using System;


namespace P2Q2Escola
{
    internal class Program
    {
        public abstract class Pessoa
        {
            protected string primeiroNome;
            protected string ultimoNome;

            public Pessoa(string pNome, string uNome)
            {
                this.primeiroNome = pNome;
                this.ultimoNome = uNome;
            }

            public virtual double valorCopiasXerox(int quantidade)
            {
                return quantidade * 2;
            }
        }


        public sealed class Aluno : Pessoa
        {
            private string registro;

            public Aluno(string pNome, string uNome, string registro)
            : base(pNome, uNome)
            {
                this.registro = registro;
            }
            public override double valorCopiasXerox(int quantidade)
            {
                return quantidade * 1;
            }
        }


        public class Funcionario : Pessoa
        {
            public double salario { get; set; }

            public Funcionario(string pNome, string uNome, double salario)
            : base(pNome, uNome)
            {
                this.salario = salario;
            }

            //public double getSalario()
            //{
            //    return this.salario;
            //}

            //public void setSalario(double salario)
            //{
            //    this.salario = salario;
            //}
        }
        static void Main(string[] args)
        {
            //Pessoa maria = new Pessoa("Maria", "Joaquina");

            Funcionario joao = new Funcionario("Joao", "Silva", 1500);
            Console.WriteLine("Valor xerox para funcionario : {0}", joao.valorCopiasXerox(10));
            joao.salario = 200;
            Console.WriteLine(joao.salario);
            
            Aluno zeca = new Aluno("Zeca", "Beats", "RA3210");
            Console.WriteLine("Valor xerox para aluno : {0}", zeca.valorCopiasXerox(10));

            Console.ReadLine();
        }
    }
}
