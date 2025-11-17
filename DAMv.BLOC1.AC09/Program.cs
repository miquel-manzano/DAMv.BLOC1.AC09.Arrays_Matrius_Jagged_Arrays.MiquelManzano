public class Program
{
    public static void Main()
    {
        const int tamTroops = 10;

        string[] troops = new string[tamTroops];
        string[,] map = new string[5, 5];
        string[][] Regions = new string[3][];
        Regions[0] = new string[4];
        Regions[1] = new string[2];
        Regions[2] = new string[3];

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 0; i < troops.GetLength(0); i++)
        {
            troops [i] = i % 2 == 0 ? "🛡️" : "⚔️"; //ternaria
        }

        foreach(var troop in troops)
        {
            Console.Write($"{troop} ");
        }
        Console.WriteLine("\n");

        for (int i = 0; i < map.GetLength(0); i++)
        {
            for(int j = 0; j < map.GetLength(1); j++)
            {
                if(i % 2 == 0 && j % 2 == 0)
                {
                    map[i, j] = "🗼";
                }
                else if(i % 2 != 0 && j % 2 != 0)
                {
                    map[i, j] = "🕳️";
                }
                else
                {
                    map[i, j] = "🌿";
                }
            }
        }

        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write($"{map[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        for (int i = 0; i < Regions.Length; i++)
        {
            for (int j = 0; j < Regions[i].Length; j++)
            {

                //ternaria
                if ((i + j) % 2 == 0)
                {
                    Regions[i][j] = "➖";
                }
                else
                {
                    Regions[i][j] = "💎";
                }
            }
        }

        for (int i = 0; i < Regions.Length; i++)
        {
            for (int j = 0; j < Regions[i].Length; j++)
            {
                Console.Write($"{Regions[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}