using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triatleta
{
    public abstract class Pessoa
    {
        private string nome = string.Empty;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void Cansou()
        {
            Console.WriteLine("Cansou...");
        }
    }
}