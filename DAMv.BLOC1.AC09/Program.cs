public class Program
{
    public static void Main()
    {
        int[] tenNumbers = new int[10];
        int[] orderedTenNumbers = new int[tenNumbers.GetLength(0)];
        Random rnd = new Random();

        
        for (int i = 0; i < tenNumbers.GetLength(0); i++)
        {
            tenNumbers[i] = rnd.Next(1, 10);
        }

        
    }
}