namespace Exercicio_03;

class Program
{
    static void Main(string[] args)
    {
        float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;

       Console.WriteLine("Digite seu salário bruto: ");
       salarioBruto = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite seu adicional noturno: ");
       adicionalNoturno = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite as horas extras: ");
       horasExtras = Convert.ToSingle(Console.ReadLine());

       Console.WriteLine("Digite os descontos: ");
       descontos = Convert.ToSingle(Console.ReadLine());

       salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;

       Console.WriteLine($"Seu salário liquido é de R$: {salarioLiquido:F2}");
    }
}
