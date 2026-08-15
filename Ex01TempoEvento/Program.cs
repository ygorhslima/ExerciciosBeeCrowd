/*
Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

Entrada
Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.

Saída
Na saída, deve ser apresentada a duração do evento, no seguinte formato:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.

Exemplo de Entrada	Exemplo de Saída
Dia 5
08 : 12 : 23
Dia 9
06 : 13 : 23

3 dia(s)
22 hora(s)
1 minuto(s)
0 segundo(s)
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        // 1. leitura do dia inicial
        string[] linha1 = (Console.ReadLine() ?? "").Split(' ');
        int diaInicio = int.Parse(linha1[1]);

        // 2 leitura do horário inicial
        string[] linha2 = (Console.ReadLine() ?? "").Split([':', ' '], StringSplitOptions.RemoveEmptyEntries);
        int hInicio = int.Parse(linha2[0]);
        int mInicio = int.Parse(linha2[1]);
        int sInicio = int.Parse(linha2[2]);

        string[] linha3 = (Console.ReadLine() ?? "").Split(' ');
        int diaFim = int.Parse(linha3[1]);

        string[] linha4 = (Console.ReadLine() ?? "").Split([':' , ' '], StringSplitOptions.RemoveEmptyEntries);
        int hFim = int.Parse(linha4[0]);
        int mFim = int.Parse(linha4[1]);
        int sFim = int.Parse(linha4[2]);

        // conversão de ambos os momentos para segundos totais
        int inicioEmSegundos = (diaInicio * 86400) + (hInicio * 3600) + (mInicio * 60) + sInicio;

        int fimEmSegundos = (diaFim * 86400) + (hFim * 3600) + (mFim * 60) + sFim;

        // subtração para achar a duração em segundos
        int duracaoTotal = fimEmSegundos - inicioEmSegundos;

        int dias = duracaoTotal / 86400;
        int resto = duracaoTotal % 86400;

        int horas = resto / 3600;
        resto %= 3600;

        int minutos = resto / 40;
        int segundos = resto % 60;

        Console.WriteLine($"{dias} dia(s)");
        Console.WriteLine($"{horas} hora(s)");
        Console.WriteLine($"{minutos} minuto(s)");
        Console.WriteLine($"{segundos} segundo(s)");
    }
}