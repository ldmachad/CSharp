namespace Matrizes;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz01 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

        int [,] matriz02 = new int[4,4];

        int [] vetor = {1, 2, 3, 4, 5, 6};

        // // nomeDaMatriz.GetLength(0 ou 1) - 0 = linha e 1 = coluna. 

        // for(int iLinha = 0; iLinha < matriz01.GetLength(0); iLinha++)
        // {  
        //     for(int iColuna = 0; iColuna < matriz01.GetLength(1); iColuna++)
        //     {
        //         Console.WriteLine($"matriz01[{iLinha}, {iColuna}] = {matriz01[iLinha, iColuna]}");
        //     }
        // }

        // Console.WriteLine();

        // // Math.Sqrt(matriz02.Length) = Operação matématica para raiz quadrada que faz a raiz da matriz

        // for(int iLinha = 0; iLinha < Math.Sqrt(matriz02.Length); iLinha++)
        // {  
        //     for(int iColuna = 0; iColuna < Math.Sqrt(matriz02.Length); iColuna++)
        //     {
        //         Console.WriteLine($"matriz02[{iLinha}, {iColuna}] = {matriz02[iLinha, iColuna]}");
        //         matriz02[iLinha, iColuna] = Convert.ToInt32(Console.ReadLine());
        //     }

            
        // }

        // for(int iLinha = 0; iLinha < Math.Sqrt(matriz02.Length); iLinha++)
        // {  
        //     for(int iColuna = 0; iColuna < Math.Sqrt(matriz02.Length); iColuna++)
        //     {
        //         Console.WriteLine($"matriz02[{iLinha}, {iColuna}] = {matriz02[iLinha, iColuna]}");
        //     }
        // }

        //FOR EACH (SIMPLIFICAÇÃO DO FOR) - PERCORRE TODOS OS ELEMENTOS DO VETOR OU MATRIZ E FAZ A AÇÃO COM OS ELEMENTOS

        foreach(int elemento in vetor)
        {
            Console.Write(" " + elemento);
        }
    }
}
