/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] m1 = new int[4, 4];
        int[,] m2 = new int[4, 4];
        int[,] mR = new int[4, 4];

        Random random = new Random();

        // Populate the first matrix
        Console.WriteLine("Primeira matriz");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                m1[i, j] = random.Next(1, 100);
                Console.Write(m1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Populate the second matrix
        Console.WriteLine("\nSegunda matriz");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                m2[i, j] = random.Next(1, 100);
                Console.Write(m2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Find the maximum values for each position in the matrices
        Console.WriteLine("\nMatriz resultante com os maiores valores");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                mR[i, j] = Math.Max(m1[i, j], m2[i, j]);
                Console.Write(mR[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
