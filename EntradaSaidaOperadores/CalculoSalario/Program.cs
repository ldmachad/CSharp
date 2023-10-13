namespace Exercicio_01;

class Program
{
    static void Main(string[] args)
    {
        float salario, abono, novoSalario;

        Console.WriteLine("Digite seu salário: ");
        salario = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Digite seu abono salarial: ");
        abono = Convert.ToSingle(Console.ReadLine());

        novoSalario = salario + abono;

        Console.WriteLine($"Seu novo salário é de: R${novoSalario:F2}");
    }
}
