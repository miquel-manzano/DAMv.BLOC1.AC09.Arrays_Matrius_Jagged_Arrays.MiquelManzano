public class Program
{
    public static void Main()
    {
        const string MenuMsg = "Choose an option:\r\n1- List Pokémon\r\n0- Exit\r\n";
        const string ReleaseMsg = "Which Pokémon do you want to release? Enter the index:";
        const string EmptySlotMsg = "The index {0} is empty. There's no Pokémon in that slot to release.";
        const string ReleaseSuccessMsg = "You released {0}!";
        const string InvalidIndexMsg = "Invalid index. Please enter a valid number.";
        const string InvalidOptionMsg = "Invalid option. Please enter 0 or 1.";
        const string ExitMsg = "Exit...";

        int option;
        string[] pokemonList = { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Meowth", "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra" };

        do
        {
            Console.WriteLine(MenuMsg);


            if (int.TryParse(Console.ReadLine(), out option) && option == 1)
            {
                int poknum = 1;
                foreach (var pokemon in pokemonList)
                {
                    Console.WriteLine($"{poknum}. {pokemon}");
                    poknum++;
                }
                Console.WriteLine(ReleaseMsg);
                if (int.TryParse(Console.ReadLine(), out option) && option > 0 && option <= pokemonList.GetLength(0))
                {
                    option -= 1; // Adjust for zero-based index
                    if (pokemonList[option] == "Empty")
                    {
                        Console.WriteLine(EmptySlotMsg, option);
                    }
                    else
                    {
                        Console.WriteLine(ReleaseSuccessMsg, pokemonList[option]);
                        pokemonList[option] = "Empty";
                    }
                    option = 2; // Continue the loop
                }
                else
                {
                    option = 2; // Continue the loop
                    Console.WriteLine(InvalidIndexMsg);
                }
            }
            else if (option == 0)
            {
                Console.WriteLine(ExitMsg);
            }
            else
            {
                Console.WriteLine(InvalidOptionMsg);
            }
        } while (option != 0);
    }
}