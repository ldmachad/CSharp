namespace PlanoDeSaude;

class Program
{
    static void Main(string[] args)
    {
        string? nome;
        int idade;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine($"Olá {nome}, seja bem vindo!\n" + "Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if(idade > 0 && idade <=10)
        {
            Console.WriteLine("A mensalidade do Plano é de R$100,00");
        }

        else if(idade > 10 && idade <= 29)
        {
            Console.WriteLine("A mensalidade do Plano é de R$200,00");
        }

        else if(idade > 29 && idade <= 45)
        {
            Console.WriteLine("A mensalidade do Plano é de R$300,00");
        }

        else if(idade > 45 && idade <= 59)
        {
            Console.WriteLine("A mensalidade do Plano é de R$500,00");
        }

        else if(idade > 59 && idade <= 65)
        {
            Console.WriteLine("A mensalidade do Plano é de R$600,00");
        }

        else if(idade > 65)
        {
            Console.WriteLine("A mensalidade do Plano é de R$1000,00");
        }

        else
        {
            Console.WriteLine("Erro! Digite uma idade válida.");
        }
        
    }
}
