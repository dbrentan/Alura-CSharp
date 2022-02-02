using System;

namespace CriandoVariaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;
            Console.WriteLine("Lucas tem " + idade + " anos");

            idade = 10 + 5;
            Console.WriteLine($"Julia tem {idade} anos");

            idade = 10 + 5 * 2;
            Console.WriteLine($"Daniel tem {idade} anos");

            idade = (10 - 5) * 2;
            Console.WriteLine("Amanda tem " + idade + " anos");

        }
    }
}