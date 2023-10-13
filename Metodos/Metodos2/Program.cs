namespace Metodos2.NameSpace01;

class Program
{
    static void Main(string[] args)
    {
        MetodoPublico();
        MetodoInternal();
        MetodoProtegido();
        MetodoPrivado();

        Console.WriteLine();

        Classe01.MetodoPublico();
        Classe01.MetodoInternal();

        //Esses métodos não podem ser chamados por serem protegidas por outras classes
        //Classe01.MetodoPrivado();
        //Classe01.MetodoProtegido();

        Console.WriteLine();

        Classe02.MetodoPublico();
        Classe02.MetodoInternal();
    }

    public static void MetodoPublico()
    {
        Console.WriteLine("Método publico - Classe Program");
    }

    internal static void MetodoInternal()
    {
        Console.WriteLine("Método Internal - Classe Program");
    }

    protected static void MetodoProtegido()
    {
        Console.WriteLine("Método protegido - Classe Program");
    }

    private static void MetodoPrivado()
    {
        Console.WriteLine("Método privado - Classe Program");
    }
}

