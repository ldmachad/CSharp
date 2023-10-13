namespace Lista;

class Program
{
    static void Main(string[] args)
    {
        // Collection
        List<double> notas = new List<double>();

        notas.Add(7.0);
        notas.Add(5.0);
        notas.Add(4.0);
        notas.Add(7.0);
        notas.Add(10.0);

        foreach (double nota in notas){
            Console.WriteLine(nota);
        }
        // RETORNA O ÍNDICE
        Console.WriteLine("Posição da nota 4.0: " + notas.IndexOf(4.0));
        // RETORNA SE O ELEMTENTO EXISTE - TRUE OR FALSE
        Console.WriteLine("A nota 4.0 existe ?" + notas.Contains(4.0));
        // REMOVE O ELEMENTO ESPECÍFICO
        notas.Remove(4.0);
        // MOSTRAR A LISTA COM O ELEMENTO REMOVIDO
        foreach (double nota in notas){
            Console.WriteLine(nota);
        }


    }
}
