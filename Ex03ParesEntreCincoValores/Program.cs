/*
Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.

Exemplo de Entrada	Exemplo de Saída
7
-5
6
-4
12

3 valores pares
*/

public class URI {
    public static void Main(string[] args)
    {   
        /*
            FORMA ANTIGA
            int contPar = 0;
            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine() ?? "");
                if(valor % 2 == 0) contPar++;
            }
            Console.WriteLine($"{contPar} valores pares");
        */

        int contPar = Enumerable.Range(0, 5)
        .Select(_ => int.Parse(Console.ReadLine()!))
        .Count(valor => valor % 2 == 0);

        Console.WriteLine($"{contPar} valores pares");
    }
}