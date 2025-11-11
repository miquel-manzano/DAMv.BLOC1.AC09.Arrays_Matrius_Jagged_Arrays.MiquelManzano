using System.Runtime.Serialization.Formatters;

public class Program
{
    public static void Main()
    {
        string[] AvailableObjects = { "Espasa", "Escut", "Poció", "Arc" };
        string[] rareTypes = { "Comú", "Rar", "Legendari", "Ordinari" };
        string name;
        int minLevel;
        int power;
        double weight;
        decimal price;
        bool isRareItem;
        string rareType;

        Random rnd = new Random();

        Console.WriteLine("=== The magic ITB store ===");
        Console.WriteLine("Name - Max level - Power - Weight (kg) - Cost (€) - isRareItem - RareType\n");
        for (int i = 0; i < 4; i++)
        {
            name = AvailableObjects[rnd.Next(AvailableObjects.Length)];
            minLevel = rnd.Next(1, 10);
            power = rnd.Next(100, 500);
            weight = rnd.NextDouble() * 100;
            price = (decimal)rnd.NextDouble() * 5000;
            isRareItem = rnd.Next(0, 2) == 1 ? true : false;
            if (isRareItem)
            {
                rareType = rareTypes[rnd.Next(rareTypes.Length)];
            }
            else
            {
                rareType = rareTypes[3];
            }
                Console.Write($"{name} - {minLevel} - {power} - {weight} - {price} - {isRareItem} - {rareType}\n");
        }
    }
}