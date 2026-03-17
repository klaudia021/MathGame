const int playGameMenu = 1;
const int viewScoresMenu = 2;
const int additionMenu = 1;
const int subtractionMenu = 2;
const int multiplicationMenu = 3;
const int divisionMenu = 4;
const int exitMenu = 5;

int selectedMenu;
List<int> mainMenuNumbers = new List<int>{playGameMenu, viewScoresMenu, exitMenu};


do
{
    ListMenu();

    selectedMenu = GetSelectedMenu(mainMenuNumbers);

    switch (selectedMenu)
    {
        case playGameMenu:
            PlayGame();
            break;
        case viewScoresMenu:
            ListScores();
            break;
        case exitMenu:
            break;
        default:
            break;
    }

} while (selectedMenu != exitMenu);

void ListMenu()
{
    System.Console.WriteLine($"{playGameMenu} - Play the game");
    System.Console.WriteLine($"{viewScoresMenu} - View score");
    System.Console.WriteLine();
    System.Console.WriteLine($"{exitMenu} - Exit");
    System.Console.WriteLine();
    System.Console.Write("Please select a menu number: ");
}

void PlayGame()
{
    ListOperations();

    List<int> operationMenuNumbers = new List<int> {additionMenu, subtractionMenu, multiplicationMenu, divisionMenu, exitMenu};
    int operationNumber = GetSelectedMenu(operationMenuNumbers);

    switch (operationNumber)
    {
        case additionMenu:
            break;
        case subtractionMenu:
            break;
        case multiplicationMenu:
            break;
        case divisionMenu:
            break;
        case exitMenu:
            break;
        default:
            break;
    }
}

void ListOperations()
{
    System.Console.WriteLine($"{additionMenu} - Addition");
    System.Console.WriteLine($"{subtractionMenu} - Subtraction");
    System.Console.WriteLine($"{multiplicationMenu} - Multiplication");
    System.Console.WriteLine($"{divisionMenu} - Division");
    System.Console.WriteLine();
    System.Console.WriteLine($"{exitMenu} - Exit");
    System.Console.WriteLine();
    System.Console.Write("Please select a menu number: ");
}

void ListScores()
{
    
}

int GetSelectedMenu(List<int> validMenuNumbers)
{
    string? input = Console.ReadLine();
    int number;
    
    while (String.IsNullOrEmpty(input) || !Int32.TryParse(input, out number) || !validMenuNumbers.Contains(number))
    {
        System.Console.Write("Please select a menu number: ");
        input = Console.ReadLine();
    }

    return number;
}