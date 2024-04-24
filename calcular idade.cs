using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu dia de nascimento:");
        int dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o seu mês de nascimento:");
        int mês = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o seu ano de nascimento:");
        int ano = int.Parse(Console.ReadLine());

        // Criando objetos DateTime para a data de nascimento e a data atual
        DateTime dataNascimento = new DateTime(ano, mês, dia);
        DateTime dataAtual = new DateTime(2024, 2, 7); // Altere para a data atual se necessário

        // Calculando a idade
        int idade = CalcularIdade(dataNascimento, dataAtual);

        Console.WriteLine($"Você tem {idade} anos de idade.");
    }

    static int CalcularIdade(DateTime dataNascimento, DateTime dataAtual)
    {
        int idade = dataAtual.Year - dataNascimento.Year;

        // Verificando se ainda não fez aniversário neste ano
        if (dataNascimento.Date > dataAtual.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }
}
