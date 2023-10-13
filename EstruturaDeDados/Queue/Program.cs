namespace Exercicio_01;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();
        int entrada = 0;
        string? nomeCliente;

        do
        {
        Console.Write(
        """
        ****************************************************
        |                                                  |
        |        1 - Adicionar Cliente na Fila             |
        |        2 - Listar todos os Clientes              |
        |        3 - Retirar Cliente da Fila               | 
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
                Console.Write("Nome do Cliente: ");
                nomeCliente = Console.ReadLine();
                fila.Enqueue(nomeCliente);
                Console.WriteLine("\nCliente Adicionado!\n");
                Console.WriteLine("Fila:\n");

                foreach(var listaFila in fila)
                {
                    Console.WriteLine(listaFila);
                }

                break;
            
                case 2:
                if(fila.Count == 0)
                {
                    Console.WriteLine("A Fila está vazia!\n");
                }

                Console.WriteLine("Lista de Clientes na Fila:\n");                
                foreach(var listaFila in fila)
                {
                    Console.WriteLine(listaFila);
                }
                break;

                case 3:
                if(fila.Count == 0)
                {
                    Console.WriteLine("A Fila está vazia!\n");
                }

                fila.Dequeue();
                Console.WriteLine("Fila:\n");   

                foreach(var listaFila in fila)
                {
                    Console.WriteLine(listaFila);
                }

                Console.WriteLine("O Cliente foi Chamado!");
                break;

            }

        } while(entrada > 0 && entrada <= 3);


    }
}
