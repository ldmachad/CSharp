namespace For_While_DoWhile;

class Program
{
    static void Main(string[] args)
    {
        //DO WHILE EXECUTA PRIMEIRO DEPOIS TESTA A CONDIÇÃO
        int numero, resultado, contador = 3;

        do {
            Console.WriteLine("\nDigite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = numero * 5;

            Console.WriteLine("\nO resultado da multiplicação é: " + resultado);
        } while (contador <=2);

        //TABUADA USANDO O WHILE
        // Console.Write("Digite o a tabuada desejada: ");
        // int numero = Convert.ToInt32(Console.ReadLine());
        
        // int contador = 1;
        // while(contador <= 10){
        //     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        //     contador ++;
        // }
        
        // // TABUADA USANDO O FOR
        // int numero;

        // Console.Write("Digite a tabuada desejada: ");
        // numero = Convert.ToInt32(Console.ReadLine());

        // for(int contador = 1; contador <= 10; contador ++) {

        //     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        // }
    }
}
