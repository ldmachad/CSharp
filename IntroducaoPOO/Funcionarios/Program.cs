using Funcionarios.Model;

namespace Funcionarios;

class Program
{
    static void Main(string[] args)
    {
        Gerente g1 = new Gerente (1, "Silas", "Gerente", "Administrativo", 10000.00, 5);
        
        Gerente g2 = new Gerente(2, "Charles", "Gerente", "Geral", 15000.00, 10);

        g1.Visualizar();

        Console.WriteLine();

        g2.Visualizar();

        Console.WriteLine();

        Vendedor v1 = new Vendedor (3, "Anderson", "Vendedor", "Roupas", 12000.00, 5000.00);
        
        Vendedor v2 = new Vendedor(4, "Kelvyn", "Vendedor", "Calçados", 1500.00, 6000.00);

        v1.Visualizar();

        Console.WriteLine();

        v2.Visualizar();        
    }
}
