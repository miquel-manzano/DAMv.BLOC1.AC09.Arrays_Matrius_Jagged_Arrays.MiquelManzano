public class Program
{
    public static void Main()
    {
        const string UnsortedArrayMsg = "Unsorted array:";
        const string SortedArrayMsg = "\nSorted array:";

        int[] tenNumbers = new int[10];
        Random rnd = new Random();

        // Filling the array with random numbers between 1 and 10
        for (int i = 0; i < tenNumbers.GetLength(0); i++)
        {
            tenNumbers[i] = rnd.Next(1, 10);
        }

        Console.WriteLine(UnsortedArrayMsg);
        //Print the unsorted array
        foreach (int number in tenNumbers)
        {
            Console.Write($"{number} ");
        }

        //First loop to compare until the penultimate number (length -2)
        for (int s = 0; s <= tenNumbers.GetLength(0) - 2; s++)
        {
            //Second loop to compare each element with the next one
            for (int r = 0; r <= tenNumbers.GetLength(0) - 2; r++)
            {
                //If the current element is greater than the next one, swap them
                if (tenNumbers[r] > tenNumbers[r + 1])
                {
                    //Auxiliary variable to perform the swap
                    int aux = tenNumbers[r + 1];
                    //Assin the value of the current element to the next position
                    tenNumbers[r + 1] = tenNumbers[r];
                    //Assign the value of the auxiliary variable to the current position
                    tenNumbers[r] = aux;
                }
            }
        }

        Console.WriteLine(SortedArrayMsg);
        //Print the sorted array
        foreach (int number in tenNumbers)
        {
            Console.Write($"{number} ");
        }
    }
}