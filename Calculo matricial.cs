/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {

Console.WriteLine("Hello, World!");



int[,] matriz = new int[5, 5];



Random random = new Random();



for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {

        //matriz[i, j] = Convert.ToInt32(Console.ReadLine());

        matriz[i, j] = random.Next(1, 100);

    }

}



Console.WriteLine("Digite o valor de X");

int x = Convert.ToInt32(Console.ReadLine());



int linha = 0, coluna = 0;

bool encontrado = false;



for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {

        if (matriz[i, j] == x)

        {

            linha = i;

            coluna = j;

            encontrado = true;

            break;

        }

    }

}



if (encontrado == true)
{

    Console.WriteLine("Posição X: {0} e Y: {1}", linha, coluna);

}

else
{

    Console.WriteLine("Valor não encontrado");

}



Console.WriteLine("Matriz impressa");



for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {

        Console.Write(matriz[i, j] + " ");

    }

    Console.WriteLine();

}
  }
}