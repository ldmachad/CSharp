using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionarios.Model
{
    public class Funcionario
    {
        // Atributos
        private int matricula;
        private string nome = string.Empty;
        private string cargo = string.Empty;
        private string setor = string.Empty;
        private double salario;

        // Construtor
        public Funcionario(int matricula, string nome, string cargo, string setor, double salario)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cargo = cargo;
            this.setor = setor;
            this.salario = salario;
        }

        public int Getmatricula()
        {
            return matricula;
        }

        public void Setmatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string Getcargo()
        {
            return cargo;
        }

        public void Setcargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string Getsetor()
        {
            return setor;
        }

        public void Setsetor(string setor)
        {
            this.setor = setor;
        }

        public double Getsalario()
        {
            return salario;
        }

        public void Setsalario(double salario)
        {
            this.salario = salario;
        }

        public virtual void Visualizar()
        {
            int matricula = this.matricula;
            string nome = this.nome;
            string cargo = this.cargo;
            string setor = this.setor;
            double salario = this.salario;

            Console.WriteLine("*******************************************");
            Console.WriteLine("             Dados do Cliente              ");
            Console.WriteLine("*******************************************");
            Console.WriteLine($"matricula: {this.matricula}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Cargo: {this.cargo}");
            Console.WriteLine($"Setor: {this.setor}");
            Console.WriteLine($"Salário: R${this.salario}");

        }
    }
}