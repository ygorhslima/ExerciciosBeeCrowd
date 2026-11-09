/*
Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

Entrada
O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

Saída
Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.

Exemplo de Entrada	Exemplo de Saída
3 99

1 2 3
4 5 6
7 8 9
10 11 12
...
97 98 99

Agradecimentos a Cássio F.


*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        // primeiro, ler os valores X e Y
        string[] linha = (Console.ReadLine() ?? "").Split(' ');
        int X = int.Parse(linha[0]);
        int Y = int.Parse(linha[1]);

        for(int i = 1; i <= Y; i++)
        {
            if(i % X == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}