/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  public static void Main(string[] args) {
    int[] vetor = new int [6];
    int cont = 0;
    
    do{
        int v = Convert.ToInt32(Console.ReadLine());
        
        if (v % 2 == 0){
            vetor[cont] = v;
            cont++;
        }
    }
    while (cont <6);
    
    for (int i = 5; i >=0; i--){
        Console.WriteLine(vetor[i]);
    }
  }
}