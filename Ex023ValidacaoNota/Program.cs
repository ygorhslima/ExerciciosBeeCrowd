/*
Validação de Nota
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.

Exemplo de Entrada	Exemplo de Saída
-3.5
3.5
11.0
10.0

nota invalida
nota invalida
media = 6.75
*/

using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
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
    }
}