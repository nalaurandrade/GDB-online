using System;

public class Program
{
    
    public static void Main ()
    {
        Random rnd = new Random();
        int aleatorio = rnd.Next(1, 1000);
        Console.Write("Digide um número");
        int numero = int.Parse(Console.ReadLine());
        
        while (numero != aleatorio)
        {
            if (numero < aleatorio)
            {
                Console.WriteLine("seu chute é menor");
            } else if (numero > aleatorio)
            {
                Console.WriteLine("seu chute é maior");
            }
            Console.Write("Digide um número");
            numero = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("parabéns! Você acertou. O número era " + numero);

        
    }
}
