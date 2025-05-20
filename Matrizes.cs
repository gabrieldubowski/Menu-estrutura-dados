using System;

namespace MenuEstruturasDados
{
    public class Matrizes
    {
        private int[,] matriz = new int[3, 3];

        public void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu - Matrizes ===");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Exibir todos os elementos");
                Console.WriteLine("3. Buscar elemento");
                Console.WriteLine("4. Voltar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Inserir();
                        break;
                    case 2:
                        Exibir();
                        break;
                    case 3:
                        Buscar();
                        break;
                    case 4:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 4);
        }

        private void Inserir()
        {
            Console.Write("Digite a linha (0-2): ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite a coluna (0-2): ");
            int coluna = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor: ");
            matriz[linha, coluna] = int.Parse(Console.ReadLine());
            Console.WriteLine("Elemento inserido!");
            Console.ReadKey();
        }

        private void Exibir()
        {
            Console.WriteLine("Elementos da matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private void Buscar()
        {
            Console.Write("Digite o valor a ser buscado: ");
            int valor = int.Parse(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }
            Console.WriteLine(encontrado ? "Elemento encontrado!" : "Elemento não encontrado.");
            Console.ReadKey();
        }
    }
}
