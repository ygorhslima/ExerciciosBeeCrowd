/*
Maior e Posição
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

Exemplo de Entrada	Exemplo de Saída
2
113
45
34565
6
...
8
 

34565
4

-
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int maiorValor = int.MinValue;
        int posValor = 0;
        for (int posicao = 1; posicao <= 100; posicao++)
        {
            int n = int.Parse(Console.ReadLine() ?? "");
            if(n > maiorValor)
            {
                maiorValor = n;
                posValor = posicao;
            } 
        }
        Console.WriteLine(maiorValor);
        Console.WriteLine(posValor);
    }
}