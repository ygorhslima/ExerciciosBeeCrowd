/*
Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

Entrada
O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

Saída
Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.

Exemplo de Entrada	Exemplo de Saída
5 2
6 3
5 0

2 3 4 5 Sum=14
3 4 5 6 Sum=18
*/

using System;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            // lendo os valores M e N no teclado
            string[] linha = (Console.ReadLine() ?? "").Split(' ');
            int M = int.Parse(linha[0]);
            int N = int.Parse(linha[1]);

            // verificando se os valores são menores ou iguais a 0
            if (M <= 0 || N <= 0)
            {
                break;
            }
            else
            {
                // saber qual é o maior e o menor valor
                int min = Math.Min(M, N);
                int max = Math.Max(M, N);

                int soma = 0;
                for (int i = min; i <= max; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"Sum={soma}");
            }
        }
    }
}