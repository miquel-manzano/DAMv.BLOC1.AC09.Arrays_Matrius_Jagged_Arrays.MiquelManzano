public class Program
{
    public static void Main()
    {
        const string ArrayLengthMsg = "Your array with length {0}:";

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
        Console.WriteLine(ArrayLengthMsg, twientyNumbers.GetLength(0));
        foreach (int number in twientyNumbers)
        {
            Console.Write($"{number} ");
        }
    }
}