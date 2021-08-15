using System;

namespace TesteMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de linhas e colunas da matriz");
            int n = int.Parse(Console.ReadLine());

            int qtdeNegativos = 0;

            int[,] mat = new int[n, n];
            string diagonal = "";

            for (int x = 0; x <= mat.Rank; x++)
            {
                Console.WriteLine($"Digite os valores da linha '{x}' separados por espaço");
                string[] values = Console.ReadLine().Split();


                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    mat[x, y] = int.Parse(values[y]);

                    if (mat[x, y] < 0)
                    {
                        qtdeNegativos++;
                    }
                }
                
                diagonal += " " + mat[x,x].ToString();
            }

            Console.WriteLine($"Diagonal principal '{diagonal}'");
            Console.WriteLine($"Quantidade de negativos '{qtdeNegativos}'");
        }
    }
}
