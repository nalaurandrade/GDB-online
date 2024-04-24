using System;

public class HelloWorld 
{
    public static void Main(string[] args)
    {
        var vetor = new int[8];
        for (int i = 0; i < 8; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine()); 
    
        int total = vetor[x] + vetor[y];
        Console.WriteLine("A soma é " + total);
    } 
}
