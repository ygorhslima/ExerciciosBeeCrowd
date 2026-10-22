/*
beecrowd | 1118
Várias Notas Com Validação
Por Neilor Tonin, URI  Brasil

Timelimit: 1
Escreva um programa para ler as notas da primeira e a segunda avaliação de um aluno. Calcule e imprima a média semestral. O programa só deverá aceitar notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando ao usuário que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.

Entrada
O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, deve ser lido um valor inteiro X . O programa deve parar quando o valor lido para este X for igual a 2.

Saída
Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. Quando duas notas válidas forem lidas, deve ser impressa a mensagem “media = ” seguido do valor do cálculo.

Antes da leitura de X deve ser impressa a mensagem "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada novamente se o valor da entrada padrão para X for menor do que 1 ou maior do que 2, conforme o exemplo abaixo.

A média deve ser impressa com dois dígitos após o ponto decimal.

Exemplo de Entrada	Exemplo de Saída
-3.5
3.5
11.0
10.0
4
1
8.0
9.0
2

nota invalida
nota invalida
media = 6.75
novo calculo (1-sim 2-nao)
novo calculo (1-sim 2-nao)
media = 8.50
novo calculo (1-sim 2-nao)
*/

using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        int resposta = 1;
        while(resposta == 1)
        {
            int notas_validas = 0;
            double soma_notas = 0.0;
            
            while (notas_validas < 2)
            {
                double nota = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                
                if (nota >= 0.0 && nota <= 10.0)
                {
                    soma_notas += nota;
                    notas_validas++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            double media = soma_notas / 2.0;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            resposta = int.Parse(Console.ReadLine() ?? "0");

            while (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                resposta = int.Parse(Console.ReadLine() ?? "0");
            }
        }
    }
}