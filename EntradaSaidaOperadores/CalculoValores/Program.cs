namespace Exercicio_04;

class Program
{
    static void Main(string[] args)
    {
        float n1, n2, n3, n4, calculo;

       Console.WriteLine("Digite o primeiro valor: ");
       n1 = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite o segundo valor: ");
       n2 = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite o terceiro valor: ");
       n3 = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite o quarto valor: ");
       n4 = Convert.ToSingle(Console.ReadLine());

       calculo = (n1 * n2) - (n3 * n4);

       Console.WriteLine($"A diferença do produto entre os valores é: {calculo:F1}");
    }
}
