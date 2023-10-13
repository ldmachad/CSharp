using Clientes.Model;

namespace Clientes;

class Program
{
    static void Main(string[] args)
    {    
        PessoaFisica pf1 = new PessoaFisica(1, "Julia", "julia.dev@fullstack.com", "(11) 912548759", "Rua das Pedras, 19 - Jardim das Flores - São Paulo/SP", "123.456.789-10\n");
        PessoaFisica pf2 = new PessoaFisica(2, "Milena", "Milena@gmail.com", "(11) 998456845", "Rua das Laranjeiras, 87 - Jardim das Acácias - São Paulo/SP", "789.456.123-11\n");
        pf1.Visualizar();
        pf2.Visualizar();

        PessoaJuridica pj1 = new PessoaJuridica(3, "Boutique da Mia", "boutiquedamia@gmail.com", "(11) 989745235", "Rua João da Silva, 99 - Vila Maria - São Paulo/SP", "55.317.972/0001-04\n");
        PessoaJuridica pj2 = new PessoaJuridica(4, "Melmo Doceria", "melmodoceria@gmail.com", "(11) 975896541", "Rua Gilberto Gil, 431 - Vila Rosália - São Paulo/SP", "60.957.230/0001-75\n");
        pj1.Visualizar();
        pj2.Visualizar();
    }
}
