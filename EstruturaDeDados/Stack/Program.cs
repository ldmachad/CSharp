namespace Exercicio_02;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> pilha = new Stack<string>();
        int entrada = 0;
        string? livroCliente;

        do
        {
        Console.Write(
        """
        ****************************************************
        |                                                  |
        |        1 - Adicionar Livro na pilha              |
        |        2 - Listar todos os Livros                |
        |        3 - Retirar Livro da pilha                | 
        |        0 - Sair                                  | 
        |                                                  | 
        ****************************************************
        
        Entre com a opção desejada: 
        """);
        
        entrada = Convert.ToInt32(Console.ReadLine());

            if(entrada == 0)
        {
                Console.WriteLine("Programa Finalizado!");
        }
            else if (entrada < 0 || entrada >= 4)
            {
                Console.WriteLine("Digite uma opção válida.");
            }

            switch (entrada)
            {
                case 1:
                Console.Write("Nome do Livro: ");
                livroCliente = Console.ReadLine();
                pilha.Push(livroCliente);
                Console.WriteLine("\nLivro Adicionado!\n");
                Console.WriteLine("Pilha:\n");

                foreach(var listaPilha in pilha)
                {
                    Console.WriteLine(listaPilha);
                }

                break;
            
                case 2:
                if(pilha.Count == 0)
                {
                    Console.WriteLine("A Pilha está vazia!\n");
                }

                Console.WriteLine("Lista de Livros na Pilha:\n");                
                foreach(var listaPilha in pilha)
                {
                    Console.WriteLine(listaPilha);
                }
                break;

                case 3:
                if(pilha.Count == 0)
                {
                    Console.WriteLine("A Pilha está vazia!\n");
                }

                pilha.Pop();
                Console.WriteLine("Pilha:\n");   

                foreach(var listaPilha in pilha)
                {
                    Console.WriteLine(listaPilha);
                }

                Console.WriteLine("O Livro foi retirado da pilha!");
                break;

            }

        } while(entrada > 0 && entrada <= 3);

    }
}
