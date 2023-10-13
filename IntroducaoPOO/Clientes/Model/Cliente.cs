using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clientes.Model
{
    public class Cliente
    {
        // Atributos
        private int id;
        private string nome = string.Empty;
        private string email = string.Empty;
        private string telefone = string.Empty;
        private string endereco = string.Empty;

        // Construtor
        public Cliente(int id, string nome, string email, string telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string Getemail()
        {
            return email;
        }

        public void Setemail(string email)
        {
            this.email = email;
        }

        public string Gettelefone()
        {
            return telefone;
        }

        public void Settelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public virtual void Visualizar()
        {
           
            Console.WriteLine("*******************************************");
            Console.WriteLine("             Dados do Cliente              ");
            Console.WriteLine("*******************************************");
            Console.WriteLine($"Id: #{this.id}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"email: {this.email}");
            Console.WriteLine($"telefone: {this.telefone}");
            Console.WriteLine($"Endereço: {this.endereco}");

        }
    }
}