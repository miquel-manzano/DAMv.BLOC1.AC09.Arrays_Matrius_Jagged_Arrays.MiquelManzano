public class Program
{
    public static void Main()
    {
        string[] Troops = new string[10];
        string[,] Map = new string[5, 5];
        string[][] Regions = new string[3][];
        Regions[0] = new string[4];
        Regions[1] = new string[2];
        Regions[2] = new string[3];

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 0; i < Troops.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                Troops[i] = "🛡️";
            }
            else
            {
                Troops[i] = "⚔️";
            }
        }

        foreach(var troop in Troops)
        {
            Console.Write($"{troop} ");
        }

        for(int i = 0; i < Map.GetLength(0); i++)
        {
            for(int j = 0; j < Map.GetLength(1); j++)
            {
                if(i % 2 == 2 && j % 2 == 0)
                {
                    
                }
                else if(i % 2 != 2 && j % 2 != 0)
                {
                    
                }
                else
                {

                }
            }
        }
    }
}