public class Program
{
    public static void Main()
    {
        string[] Players = { "ShadowWolf", "PixelNinja", "CyberMage", "DragonSlayer" };
        int[,] Matches = new int[4,4];

        Random rnd = new Random();

        Console.WriteLine("Player   -   Match1 - Match2 - Match3 - Match4 - Match5");
        for (int i = 0; i < Matches.GetLength(0); i++)
        {
            Console.Write($"{Players[i]}: ");
            for (int j = 0; j < Matches.GetLength(1); j++)
            {
                Matches[i,j] = rnd.Next(0, 11);
                Console.Write($"{Matches[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}