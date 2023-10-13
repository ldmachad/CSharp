namespace Exercicio_01;

class Program
{
    static void Main(string[] args)
    {
       List<string> cores = new List<string>();
       string cor = "";

       for (int i  = 0; i < 5; i++)
       {
            Console.WriteLine($"Insira {i + 1}° cor:");
            cor = Console.ReadLine();

            cores.Add(cor);
       }

       Console.WriteLine("\nCores adicionadas:\n");

       foreach (var elemento in cores)
       {
         Console.WriteLine(elemento);
       }

       cores.Sort();

       Console.WriteLine("\nCores ordenadas em ordem crescente:\n");

       foreach (var elemento in cores)
       {
         Console.WriteLine(elemento);
       }
    }
}
