using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int quantidadePositivos = 0;
        double somaPositivos = 0.0;

        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine() ?? "");

            if (valor > 0)
            {
                quantidadePositivos++;
                somaPositivos += valor;
            }
        }

        double media = somaPositivos / quantidadePositivos;
        Console.WriteLine($"{quantidadePositivos} valores positivos");
        Console.WriteLine($"Média: {media}");
    }
}