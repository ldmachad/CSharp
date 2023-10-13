namespace LinQ;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        List<string> nomes = new List<string>() 
        {
            "João",
            "Breno",
            "Julia",
            "Samantha",
            "Vitor 1",
            "Vitor 2",
            "Victor",
            "Matheus",
            "Matheus",
            "Karina",
            "Carol"
        };

        var numerosAoCubo = numeros.Select(n => Math.Pow(n, 3));

        Console.WriteLine("Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));

        var numerosImpares = from numero in numeros
                             where numero % 2 != 0
                             select(numero);

        Console.WriteLine("Números ímpares: " + string.Join(", ", numerosImpares));

        var nomesStartMV = (from nome in nomes
                           where nome.StartsWith('M') || nome.StartsWith('V')
                           select nome).ToList();

        // nomesStartMV.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("Nome que começam com letra M e V: " + string.Join(", ", nomesStartMV));

        var nomesContemC = from nome in nomes
                           where nome.ToUpper().Contains('C')
                           select (nome);

        Console.WriteLine("Nomes que contenham a letra C: " + string.Join(", ", nomesContemC));

        var numerosOrdemAscendente = from numero in numeros
                             orderby numero
                             select(numero);

        Console.WriteLine("Números em ordem crescente: " + string.Join(", ", numerosOrdemAscendente));

        var numerosOrdemDescendente = from numero in numeros
                             orderby numero descending
                             select(numero);

        Console.WriteLine("Números em ordem decrescente: " + string.Join(", ", numerosOrdemDescendente));

        var nomesSemDuplicidade = from nome in nomes
                                  .Distinct()
                                  select (nome);

        Console.WriteLine("Nomes sem duplicidade: " + string.Join(", ", nomesSemDuplicidade));

        var contarVitors = nomes.Count(n => n.Contains("Vitor"));

        Console.WriteLine("Total de pessoas chamadas Vitor: " + contarVitors);

        var primeiroVitor = nomes.First(n => n.Contains("Vitor"));

        Console.WriteLine("Primeiro Vitor da lista: " + primeiroVitor);

    }
}
