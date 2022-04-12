using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int sum = 0;

            int[,] rmatrix = new int[cols,rows];

            for (int i = 0; i < cols; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    rmatrix[i,j] = random.Next(1,20);
                    Console.Write($"{rmatrix[i,j],3}");
                    sum = sum + rmatrix[i,j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of the matrix is: {sum}");
        }
    }
}
