namespace Exercicio_02;

class Program
{
    static void Main(string[] args)
    {
        float nota1, nota2, nota3, nota4, calcularNotas;

       Console.WriteLine("Digite sua primeira nota: ");
       nota1 = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite sua segunda nota: ");
       nota2 = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite sua terceira nota: ");
       nota3 = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite sua quarta nota: ");
       nota4 = Convert.ToSingle(Console.ReadLine());

       calcularNotas = (nota1 + nota2 + nota3 + nota4)/4;

       Console.WriteLine($"Sua média final é de: {calcularNotas:F1}");
    }
}
