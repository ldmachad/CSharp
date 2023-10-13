using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionarios.Model
{
    public class Vendedor : Funcionario
    {
        private double meta;


        public Vendedor(int matricula, string nome, string cargo, string setor, double salario, double meta) 
        : base(matricula, nome, cargo, setor, salario)
        {
            this.meta = meta;
        }
        public double GetMeta()
        {
            return this.meta;
        }

        public void SetMeta(double meta)
        {
            this.meta = meta;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Meta de vendas mensal: R${this.meta}");
        }
    }
}