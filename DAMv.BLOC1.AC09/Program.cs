using System;

public class Program
{
    public static void Main()
    {
        string[] players = { "LunaBlade", "IronFist", "ShadowNova", "PixelMage" };

        int[][] scores = new int[4][];

        Random rnd = new Random();

        scores[0] = new int[3]; // LunaBlade juega 3 partidos
        scores[1] = new int[5]; // IronFist juega 5 partidos
        scores[2] = new int[2]; // ShadowNova juega 2 partidos
        scores[3] = new int[4]; // PixelMage juega 4 partidos

        for (int i = 0; i < scores.Length; i++)
        {
            for (int j = 0; j < scores[i].Length; j++)
            {
                scores[i][j] = rnd.Next(0, 101);
            }
        }

        int totalPoints = 0;

        for (int i = 0; i < players.Length; i++)
        {
            Console.Write($"{players[i]}: ");
            int playerTotal = 0;

            for (int j = 0; j < scores[i].Length; j++)
            {
                Console.Write($"{scores[i][j]} ");
                playerTotal += scores[i][j];
            }

            double average = (double)playerTotal / scores[i].Length;

            Console.WriteLine($"-> Average: {average:F2}");

            totalPoints += playerTotal;
        }

        Console.WriteLine($"Total global de punts del torneig: {totalPoints}");
    }
}
