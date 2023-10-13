using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Model
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj = string.Empty;

        public PessoaJuridica(int id, string nome, string email, string telefone, string endereco, string cnpj) 
        : base(id, nome, email, telefone, endereco)
        {
            this.cnpj = cnpj;
        }
        
        public string Getcnpj()
        {
            return this.cnpj;
        }

        public void Setcnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CNPJ: {this.cnpj}");
        }
    }
}