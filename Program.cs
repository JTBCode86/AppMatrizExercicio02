using System;

namespace AppMatrizExercicio02
{
    /// <summary>
    /// Exercicio 2 - Matriz
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a dimenssão da sua matriz M e N: ");
            string[] line = Console.ReadLine().Split(" ");
            
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            
            int[,] mat = new int[m, n];

            Console.WriteLine("Por favor, preencha sua matriz!");
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Qual valor gostaria de encontrar dentro da matriz? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j  = 0; j < n; j++)
                {
                    if (mat[i,j]==x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
