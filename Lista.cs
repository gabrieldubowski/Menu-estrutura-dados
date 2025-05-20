using System;
using System.Collections.Generic;

namespace MenuEstruturasDados
{
    public class Lista
    {
        private List<int> lista = new List<int>();

        public void Menu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu - Lista ===");
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
            Console.Write("Digite o valor: ");
            int valor = int.Parse(Console.ReadLine());
            lista.Add(valor);
            Console.WriteLine("Elemento inserido!");
            Console.ReadKey();
        }

        private void Remover()
        {
            if (lista.Count > 0)
            {
                lista.RemoveAt(lista.Count - 1);
                Console.WriteLine("Último elemento removido.");
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
            Console.ReadKey();
        }

        private void Exibir()
        {
            Console.WriteLine("Elementos na lista:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private void Buscar()
        {
            Console.Write("Digite o valor a ser buscado: ");
            int valor = int.Parse(Console.ReadLine());
            bool encontrado = lista.Contains(valor);
            Console.WriteLine(encontrado ? "Elemento encontrado!" : "Elemento não encontrado.");
            Console.ReadKey();
        }
    }
}
