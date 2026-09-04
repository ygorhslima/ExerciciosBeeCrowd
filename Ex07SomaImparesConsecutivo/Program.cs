/*
Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

Entrada
O arquivo de entrada contém dois valores inteiros.

Saída
O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre os valores fornecidos na entrada que deverá caber em um inteiro.
*/

using System; 

public class URI 
{
    public static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine() ?? "");
        int Y = int.Parse(Console.ReadLine() ?? "");
       
        int min = Math.Min(X, Y);
        int max = Math.Max(X, Y);
        
        int soma = 0;

        for(int i = min+1; i < max; i++)
        {
            if(i % 2 != 0)
            {
                soma += i;                
            }
        }
        Console.WriteLine(soma);
    }  
}