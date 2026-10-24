/*
A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. Escreva um programa para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:

- Quantos GRENAIS fizeram parte da estatística.
- O número de vitórias do Inter.
- O número de vitórias do Grêmio.
- O número de Empates.
- Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).

Entrada
O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. Em seguida háverá um inteiro (1 ou 2), correspondO arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. Em seguida háverá um inteiro (1 ou 2), correspondente à repetição do programa.
ente à repetição do programa.

Saída
Após cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)". Quando o algoritmo for encerrado devem ser mostradas as estatísticas conforme a descrição apresentada acima. Obs: a palavra "Gremio" deve ser impressa sem acento, conforme o exemplo abaixo.

Exemplo de Entrada	Exemplo de Saída
3 2
1
2 3
1
3 1
2

Novo grenal (1-sim 2-nao)
Novo grenal (1-sim 2-nao)
Novo grenal (1-sim 2-nao)
3 grenais
Inter:2
Gremio:1
Empates:0
Inter venceu mais

*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        int resposta = 1;
        int quantGrenais = 0;
        int nVitoriasInter = 0;
        int nVitoriasGremio = 0;
        int empate = 0;
        while(resposta == 1)
        {
            quantGrenais++;
            string[] linha = (Console.ReadLine() ?? "").Split(' ');
            int golsInter = int.Parse(linha[0]);
            int golsGremio = int.Parse(linha[1]);

            if(golsInter > golsGremio)
            {
                nVitoriasInter++;
            }
            else if (golsGremio > golsInter)
            {
                nVitoriasGremio++;
            }
            else
            {
                empate++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            resposta = int.Parse(Console.ReadLine() ?? "");
            while (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                resposta = int.Parse(Console.ReadLine() ?? "");
            }
        }
        Console.WriteLine($"{quantGrenais} grenais");
        Console.WriteLine($"Inter:{nVitoriasInter}");
        Console.WriteLine($"Gremio:{nVitoriasGremio}");
        Console.WriteLine($"Empates:{empate}");
        if (nVitoriasInter > nVitoriasGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else
        {
            Console.WriteLine("Gremio venceu mais");
        }
    }
}