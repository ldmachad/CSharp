namespace Vetores;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor01 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        int[] vetor02 = new int[5];

        for (int indice = 0; indice < 10; indice++){
            Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
        }

        // Console.WriteLine();

        // for (int indice = 0; indice < 5; indice++){
        //     Console.Write($"vetor02[{indice}] = ");
        //     vetor02[indice] = Convert.ToInt32 (Console.ReadLine());
        // }

        // Console.WriteLine();
        // //ORDENAR VETOR EM ORDEM CRESCENTE
        // Array.Sort(vetor02);

        // /* ORDENAR EM ORDEM DECRESCENTE
        // Array.Reverse(vetor02);
        
        // SABER A POSIÇÃO DO ELEMENTO DO VETOR - RETORNA O INDICE
        // Array.IndexOf(nomeDoVetor, elemento);*/


        // for (int indice = 0; indice < vetor02.Length; indice++){
        //     Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            
        // }
    }
}
