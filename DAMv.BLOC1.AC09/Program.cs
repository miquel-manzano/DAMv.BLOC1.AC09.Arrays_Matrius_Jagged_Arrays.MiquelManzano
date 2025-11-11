public class Program
{
    public static void Main()
    {
        const string OrderNumMsg = "Ten numbers on order";
        const string InverseOrderNumMsg = "Ten numbers on inverse order";

        int[] tenNumbers = new int[10];
        Random rnd = new Random();

        // Fill the array with random numbers between 1 and 10
        int index = 0;
        foreach (int number in tenNumbers)
        {
            tenNumbers[index] = rnd.Next(1, 10);
            index++;
        }

        Console.WriteLine(OrderNumMsg);
        // Print the numbers
        for (int i = 0; i < tenNumbers.GetLength(0); i++)
        {
            Console.Write($"{tenNumbers[i]} ");
        }

        Console.WriteLine(InverseOrderNumMsg);
        // Print the numbers in reverse order
        for (int i = tenNumbers.GetLength(0)-1; i >= 0; i--)
        {
            Console.Write($"{tenNumbers[i]} ");
        }
    }
}