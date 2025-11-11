public class Program
{
    public static void Main()
    {
        const string ArrayLengthMsg = "Your array with length {0}:";
        const string EvenNumbersMsg = "\nEven numbers in the array:";
        const string OddNumbersMsg = "\nOdd numbers in the array:";

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

        // Print even and odd numbers
        Console.WriteLine(EvenNumbersMsg);
        foreach (int number in twientyNumbers)
        {
            if (number % 2 == 0)
            {
                Console.Write($"{number} ");
            }
        }

        Console.WriteLine(OddNumbersMsg);
        foreach (int number in twientyNumbers)
        {
            if (number % 2 != 0)
            {
                Console.Write($"{number} ");
            }
        }
    }
}