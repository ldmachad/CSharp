namespace Transportes;

class Program
{
    static void Main(string[] args)
    {
        Transporte t1 = new Transporte(5);
        t1.Visualizar();

        Console.WriteLine();

        Terrestre terrestre1 = new Terrestre(6, 4, 200);
        terrestre1.Visualizar();

        Console.WriteLine();

        Automovel a1 = new Automovel(5, 4, 180, "Preto", 5, "LQJ-7241", 6);
        a1.Visualizar();
    }
}
