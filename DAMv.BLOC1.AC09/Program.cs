public class Program
{
    public static void Main()
    {
        const string WelcomeMsg = "Welcome to the Treasure Hunt Game!";
        const string InstructionsMsg = "Explore the map and try to find as many treasures as you can within your dig attempts.\nHint: you have a map";
        const string MenuMsg = "Dig tries left: {0}\nChoose an option:\n1. Explore the map\n2. Try to dig\n0. Exit";
        const string ExploreMapMsg = "Exploring the map...";
        const string TryDigMsg = "Trying to dig...";
        const string EnterXCoordMsg = "Enter X coordinate (0-9):";
        const string EnterYCoordMsg = "Enter Y coordinate (0-9):";
        const string TresureFoundMsg = "Congrats!! You found a treasure.";
        const string NoTresureMsg = "Sorry, no treasure at this location.";
        const string InvalidInputMsg = "Invalid input. Please enter a number.";
        const string InvalidOptionMsg = "Invalid option. Please choose again.";
        const string ExitMsg = "You have no more dig tries left.\nTresures recolected: {0}";
        const string Spacer = "----------------------------------------";

        string[,] map = new string[10,10];
        string ground = "0";
        string tresure = "*";

        int option;
        int tresuresFound = 0;
        int digTries = 3;
        int userX, userY;// X are rows, Y are columns

        Random rnd = new Random();

        // Generate map with random ground and tresure
        for (int i = 0; i < map.GetLength(0); i++)// Columns
        {
            for (int j = 0; j < map.GetLength(1); j++)// Rows
            {
                map[i, j] = rnd.Next(0, 2) == 0 ? ground : tresure;
            }
        }

        Console.WriteLine(WelcomeMsg);
        Console.WriteLine(InstructionsMsg);

        do
        {
            Console.WriteLine(Spacer);
            Console.WriteLine(MenuMsg, digTries);

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine(ExploreMapMsg);
                        for (int i = 0; i < map.GetLength(0); i++)// Columns
                        {
                            for (int j = 0; j < map.GetLength(1); j++)// Rows
                            {
                                Console.Write(map[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine(TryDigMsg);
                        Console.WriteLine(EnterXCoordMsg);
                        if (int.TryParse(Console.ReadLine(), out userX))
                        {
                            Console.WriteLine(EnterYCoordMsg);
                            if (int.TryParse(Console.ReadLine(), out userY))
                            {
                                digTries--;
                                Console.WriteLine($"Digging at ({userX}, {userY})...");
                                if (map[userX, userY] == tresure)
                                {
                                    tresuresFound++;
                                    map[userX, userY] = ground; // Remove tresure after found
                                    Console.WriteLine(TresureFoundMsg);
                                }
                                else
                                {
                                    Console.WriteLine(NoTresureMsg);
                                }
                            }
                            else
                            {
                                Console.WriteLine(InvalidInputMsg);
                            }
                        }
                        else
                        {
                            Console.WriteLine(InvalidInputMsg);
                        }
                        break;
                    default:
                        Console.WriteLine(InvalidOptionMsg);
                        break;
                }
            }
            else
            {
                Console.WriteLine(InvalidInputMsg);
            }
            if (digTries == 0)
            {
                Console.WriteLine(ExitMsg, tresuresFound);
            }
        } while (option != 0 && digTries > 0);
    }
}