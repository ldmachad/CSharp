namespace Pesquisa;

class Program
{
    static void Main(string[] args)
    {
        string? nome, continua;
        int idade, esporte, futebol = 0, voleiMaiores18 = 0, basqueteMenores18 = 0;

        do{
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            do{
            Console.Write("Digite o seu esporte favorito: 1-Fut/2-Vol/3Basq/4-Outros)");
            esporte = Convert.ToInt32(Console.ReadLine());
            } while(esporte < 1 || esporte >4);

            if (esporte == 1){
                futebol++;
                }

            if (esporte == 2 && idade > 18){
                voleiMaiores18++;
            }

            if (esporte == 3 && idade < 18){
                basqueteMenores18++;
            }

            Console.Write("Deseja continuar? (S/N)");
            continua = Console.ReadLine() .ToUpper();

        } while (continua.Equals("S"));

        Console.WriteLine($"Total de pessoas que gostam de futebol : {futebol}");
        Console.WriteLine($"Total de pessoas que gostam de volei maiores de 18 anos : {voleiMaiores18}");
        Console.WriteLine($"Total de pessoas que gostam de basque menores de 18 anos : {basqueteMenores18}");
    }
}
