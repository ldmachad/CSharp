using Metodos2.NameSpace01;

namespace Metodos;

class Program
{
    static void Main(string[] args)
    {
        float numero1, numero2, divisao;

        Console.WriteLine("Digite o primeiro número:");
        numero1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine($"{numero1} + {numero2} = " + Somar(numero1, numero2));
        Console.WriteLine($"{numero1} - {numero2} = " + Subtrair(numero1, numero2));
        Console.WriteLine($"{numero1} * {numero2} = " + Multiplicar(numero1, numero2));

        divisao = Dividir(numero1, numero2);
        Console.WriteLine(divisao == 0 ? "Não existe divisão por zero" : $"{numero1} / {numero2} = {divisao}");

        Console.WriteLine($"{numero1} ^ {numero2} = " + Potencia(numero1, numero2));
        Console.WriteLine($"Raiz quadrada de {numero1} = " + Raiz(numero1));

        Dev();

        // Classe02.MetodoPublico();

    }

    static float Somar(float num1, float num2)
    {
        return num1 + num2;
    }

    static float Subtrair(float num1, float num2)
    {
        return num1 - num2;
    }

    static float Multiplicar(float num1, float num2)
    {
        return num1 * num2;
    }

    static float Dividir(float num1, float num2)
    {
        if (num2 > 0 && num1 > 0)
        {
            return num1 / num2;
        }

        else
        {
            return 0;
        }
    }

    static double Potencia(float num1, float num2)
    {
        return Math.Pow(num1, num2);
    }

    static double Raiz(float num1)
    {
        return Math.Sqrt(num1);
    }

    static void Dev()
    {
        Console.WriteLine("Criado por: Leonardo Machado!");
    }
}
