using System;
using System.Runtime.Serialization;

public class HelloWorld
{
    public static void Main(string[] args)
     {
                int soma = 0;
                int cont = 1;
                int varContadora = 2;
                while (cont < 50) {
        
                    if (varContadora % 2 == 0){
                                soma = soma + varContadora;
                                cont++;
                    }
                    varContadora++;
                }
            Console.WriteLine(soma);
        }
}
