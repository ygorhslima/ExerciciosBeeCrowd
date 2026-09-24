using System; 

public class Program {

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine() ?? "");
        for(int i = 0; i < N; i++)
        {
            string[] linha = (Console.ReadLine() ?? "").Split(' ');
            int X = int.Parse(linha[0]);
            int Y = int.Parse(linha[1]);

            int min = Math.Min(X, Y);
            int max = Math.Max(X, Y);

            int somaImpares = 0;
            for(int j = min + 1; j < max; j++)
            {
                if(j % 2 == 1)
                {
                    somaImpares+=j;
                }
            }
            Console.WriteLine(somaImpares);
        }
    }
}