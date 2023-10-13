namespace Notas;

class Program
{
    static void Main(string[] args)
    {
        float nota1, nota2, media;

        Console.Write("Digite a primeira nota: ");
        nota1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = Convert.ToSingle(Console.ReadLine());

        media = (nota1 + nota2) / 2;

        // if ternário -> (condição) ? verdadeiro : falso
        Console.WriteLine((media>=6) ? "Aprovado!" : "Reprovado!");
        // Console.WriteLine((media>=6) ? "Aprovado!" : (media >= 4 && media < 6) ? "Recuperação" : "Reprovado!");
    }
}
