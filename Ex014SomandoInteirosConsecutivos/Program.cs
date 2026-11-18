/*
Somando Inteiros Consecutivos
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Faça um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1). Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.

Entrada
A entrada contém somente valores inteiros, podendo ser positivos ou negativos. Todos os valores estão na mesma linha.

Saída
A saída contém apenas um valor inteiro.

Exemplo de Entrada	Exemplo de Saída
3 2

7

3 -1 0 -2 2

7

Agradecimentos a Cássio F.
*/
public class Program
{
    public static void Main(string[] args)
    {
        string[] linha = (Console.ReadLine() ?? "").Split(' ');
        int index = 0;
        int A = int.Parse(linha[index++]);
        int N = int.Parse(linha[index++]);

        int soma = 0;
        while (N <= 0)
        {
            N = int.Parse(linha[index++]);
        }
        for (int i = 0; i < N; i++)
        {
            soma += A + i;
        }
        Console.WriteLine(soma);
    }
}
