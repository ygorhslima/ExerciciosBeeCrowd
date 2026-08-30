/*
Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.

Exemplo de Entrada	Exemplo de Saída
-5
0
-3
-4
12

3 valor(es) par(es)
2 valor(es) impar(es)
1 valor(es) positivo(s)
3 valor(es) negativo(s)
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int quantPares = 0;
        int quantImpares = 0;
        int quantPositivos = 0;
        int quantNegativos = 0;

        for (int i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine() ?? "");
            if (valor % 2 == 0) quantPares++; else quantImpares++;
            if (valor > 0) quantPositivos++; else quantNegativos++;
        }
        Console.WriteLine($"{quantPares} valor(es) par(es)\n{quantImpares} valor(es) impar(es)\n{quantPositivos} valor(es) positivo(s)\n{quantNegativos} valor(es) negativo(s)");
    }
}