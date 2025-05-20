using System;

namespace MenuEstruturasDados
{
    public class Vetores
    {
        private int[] vetor = new int[10];
        private int tamanho = 0;

        public void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu - Vetores ===");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos os elementos");
                Console.WriteLine("4. Buscar elemento");
                Console.WriteLine("5. Voltar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Inserir();
                        break;
                    case 2:
                        Remover();
                        break;
                    case 3:
                        Exibir();
                        break;
                    case 4:
                        Buscar();
                        break;
                    case 5:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 5);
        }

        private void Inserir()
        {
            if (tamanho < vetor.Length)
            {
                Console.Write("Digite o valor: ");
                vetor[tamanho] = int.Parse(Console.ReadLine());
                tamanho++;
                Console.WriteLine("Elemento inserido!");
            }
            else
            {
                Console.WriteLine("Vetor cheio!");
            }
            Console.ReadKey();
        }

        private void Remover()
        {
            if (tamanho > 0)
            {
                tamanho--;
                Console.WriteLine("Último elemento removido.");
            }
            else
            {
                Console.WriteLine("Vetor vazio!");
            }
            Console.ReadKey();
        }

        private void Exibir()
        {
            Console.WriteLine("Elementos no vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }

        private void Buscar()
        {
            Console.Write("Digite o valor a ser buscado: ");
            int valor = int.Parse(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == valor)
                {
                    encontrado = true;
                    break;
                }
            }
            Console.WriteLine(encontrado ? "Elemento encontrado!" : "Elemento não encontrado.");
            Console.ReadKey();
        }
    }
}
