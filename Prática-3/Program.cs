using System;
// Descobrir se o número e feliz ou não
class Program
{
    static void Main(string[] args)
    {
        NúmeroFeliz();
    }

    public static void NúmeroFeliz()
    {
        int Number;

        Console.WriteLine("Escreva seu número : ");
        Number = int.Parse(Console.ReadLine());

        int X = Number;

        while (X >= 10)
        {
            int soma = 0;

            while (X > 0)
            {
                int r = X % 10;
                soma = soma + (int)Math.Pow(r, 2);
                X = X / 10;
            }

            X = soma;

        }

        if (X == 1)
        {
            Console.WriteLine($"O número {Number} é um Número Feliz :) ");
        }
        else
        { 
            Console.WriteLine($"O número {Number} não é um Número Feliz :( ");
        }

    }


}