using System;
using System.Formats.Asn1;
using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;
//Contador de Vogais e Consoantes

class Program
{
    static void Main(string[] args)
    {
        ContaVogais();
    }

    public static void ContaVogais()
    {
        string Texto;
        Console.WriteLine("Informe seu texto : ");
        Texto = Console.ReadLine();

        char[] Textos = Texto.ToCharArray();

        Texto.ToLower();

        int contVogais = 0;

        int contConsoantes = 0;

        for (int i = 0; i < Textos.Length; i++)
        {
            if (Textos[i] == 'a' || Textos[i] == 'e' || Textos[i] == 'i' || Textos[i] == 'o' || Textos[i] == 'u')
            {
                contVogais++;
            }
            else
            {
                contConsoantes++;
            }
        }

        Console.WriteLine($"Este texto possue {contVogais} vogais e {contConsoantes} consoantes.");
    }
}
