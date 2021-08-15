using System;

namespace TesteMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int x = 0; x < m; x++)
            {
                Console.WriteLine($"Digite a linha '{x}' da matriz com valores separados por espaço");
                string[] vet = Console.ReadLine().Split();

                for (int y = 0; y < n; y++)
                {
                    mat[x, y] = int.Parse(vet[y]);
                }
            }

            Console.WriteLine("Digite o numero a ser pesquisado");
            int num = int.Parse(Console.ReadLine());

            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (mat[x, y] == num)
                    {
                        Console.WriteLine($"Posição = '{x},{y}'");

                        if ((x-1) >= 0)
                            Console.WriteLine($"Topo = '{mat[x-1,y]}'");
                        if ((x + 1) < m)
                            Console.WriteLine($"Base = '{mat[x+1, y]}'");
                        if ((y - 1) >= 0)
                            Console.WriteLine($"Esquerda = '{mat[x, y-1]}'");
                        if ((y + 1) < n)
                            Console.WriteLine($"Direita = '{mat[x, y+1]}'");
                    }
                }
            }
        }
    }
}
