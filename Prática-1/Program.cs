using System;
//Verificador de Palíndromo
class Progrmam
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva sua palavra : ");
        string palavra = Console.ReadLine();

        string palavrainertida = new string(palavra.Reverse().ToArray());

        if (palavra != palavrainertida)
        {
            Console.WriteLine("Não é Palíndromo!");
        }
        else
        {
            Console.WriteLine("É Palíndromo!");
        }
        
    }
}
