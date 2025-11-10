public class Program
{
    public static void Main()
    {
        //Exercise One
        int[] twientyNumbers = new int[20];
        Random rnd = new Random();

        // Fill the array with random numbers
        int index = 0;
        foreach (int number in twientyNumbers)
        {
            twientyNumbers[index] = rnd.Next(1, 101);
            index++;
        }

        // Print the array
        Console.WriteLine($"Your array with length {twientyNumbers.GetLength(0)}:");
        foreach (int number in twientyNumbers)
        {
            Console.Write($"{number} ");
        }
    }
}