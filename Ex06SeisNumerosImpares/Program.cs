/*
Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

Entrada
A entrada será um valor inteiro positivo.

Saída
A saída será uma sequência de seis números ímpares.

Exemplo de Entrada	Exemplo de Saída
8

9
11
13
15
17
19
*/

using System;

class URI {
    static void Main(string[] args)
    {
        int value = int.Parse(Console.ReadLine() ?? "");
        if(value % 2 == 0)
        {
            value++;
        }

        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine(value);
            value += 2;
        }
    }
}