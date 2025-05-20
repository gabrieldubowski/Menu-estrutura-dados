using System;

namespace MenuEstruturasDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("7. Encerrar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        new Vetores().Menu();
                        break;
                    case 2:
                        new Matrizes().Menu();
                        break;
                    case 3:
                        new Lista().Menu();
                        break;
                    case 4:
                        new Fila().Menu();
                        break;
                    case 5:
                        new Pilha().Menu();
                        break;
                    case 6:
                        new Pesquisa().Menu();
                        break;
                    case 7:
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 7);
        }
    }
}
