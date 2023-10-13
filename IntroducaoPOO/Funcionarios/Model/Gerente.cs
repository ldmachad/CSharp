using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionarios.Model
{
    public class Gerente : Funcionario
    {
        private int equipe;

        public Gerente(int matricula, string nome, string cargo, string setor, double salario, int equipe) 
        : base(matricula, nome, cargo, setor, salario)
        {
            this.equipe = equipe;
        }
        public int Getequipe()
        {
            return this.equipe;
        }

        public void Setequipe(int equipe)
        {
            this.equipe = equipe;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Equipe: {this.equipe} pessoas");
        }
    }
}