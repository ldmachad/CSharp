using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Model
{
    public class PessoaFisica : Cliente
    {
        private string cpf = string.Empty;

        public PessoaFisica(int id, string nome, string email, string telefone, string endereco, string cpf) 
        : base(id, nome, email, telefone, endereco)
        {
            this.cpf = cpf;
        }
        
        public string GetCpf()
        {
            return this.cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CPF: {this.cpf}");
        }
    }
}