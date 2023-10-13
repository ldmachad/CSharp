namespace Exercicio_03;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numeros = new HashSet<int>();
        int num = 0;

        for (int i = 0; i <  10; i++)
        {
            Console.WriteLine($"Insira o {i + 1}° número: ");
            num = Convert.ToInt32(Console.ReadLine());

            numeros.Add(num);
        }

        Console.WriteLine("\nLista de números:\n");

        foreach (var elemento in numeros)
        {
            Console.WriteLine(elemento);
        }

    }
}
