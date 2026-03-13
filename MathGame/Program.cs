const int exitNumber = 5;
int selectedMenu;

do
{
    ListMenu();

    selectedMenu = GetSelectedMenu();

    switch (selectedMenu)
    {
        case 1:
            PlayGame();
            break;
        case 2:
            ListScores();
            break;

        case exitNumber:
            break;
        default:
            break;
    }

} while (selectedMenu != exitNumber);

void ListMenu()
{
    System.Console.WriteLine("1 - Play the game");
    System.Console.WriteLine("2 - View score");
    System.Console.WriteLine();
    System.Console.WriteLine($"{exitNumber} - Exit");
    System.Console.WriteLine();
    System.Console.Write("Please select a menu number: ");
}

int GetSelectedMenu()
{
    var input = Console.ReadLine();
    int number;
    List<int> validMenuNumbers = new List<int>{1, 2, 5};

    while (String.IsNullOrEmpty(input) || !Int32.TryParse(input, out number) || !validMenuNumbers.Contains(number))
    {
        System.Console.Write("Please select a menu number: ");
        input = Console.ReadLine();
    }

    return number;
}

void PlayGame()
{
    
}

void ListScores()
{
    
}