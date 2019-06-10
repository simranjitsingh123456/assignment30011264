/*
 Name = Simranjit Singh
 Student ID = 30011264
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Random Numbers 
             */
            Random random = new Random();

            /*
             * Set size for the matrix
             */
            int rows = 3;
            int columns = 3;

            int[,] A = new int[rows, columns];
            int[,] B = new int[rows, columns];

            int[,] C = new int[rows, columns];


            Console.WriteLine("Random Values of martix A");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    A[i, j] = random.Next(-10, 10);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("Random Values of martix B");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    B[i, j] = random.Next(-10, 10);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSum of both the matrices is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();            
        }
    }
}
