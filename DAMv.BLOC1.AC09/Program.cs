public class Program
{
    public static void Main()
    {
        int[] tenNumbers = new int[10];
        Random rnd = new Random();

        // Fill the array with random numbers between 1 and 10
        foreach (int number in tenNumbers)
        {
            tenNumbers[number] = rnd.Next(1, 10);
        }

        // Print the numbers
        foreach (int number in tenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}