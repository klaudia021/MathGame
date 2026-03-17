const int playGameMenu = 1;
const int viewScoresMenu = 2;
const int additionMenu = 1;
const int subtractionMenu = 2;
const int multiplicationMenu = 3;
const int divisionMenu = 4;
const int exitMenu = 9;

int selectedMenu;
List<int> mainMenuNumbers = new List<int>{playGameMenu, viewScoresMenu, exitMenu};
List<string> mainMenuText = new List<string> {$"{playGameMenu} - Play the game", $"{viewScoresMenu} - View score"};


do
{
    ListMenu(mainMenuText);

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

void ListMenu(List<string> menuText)
{
    foreach (var menuElement in menuText)
    {
        System.Console.WriteLine(menuElement);
    }

    System.Console.WriteLine();
    System.Console.WriteLine($"{exitMenu} - Exit");
    System.Console.WriteLine();
    System.Console.Write("Please select a menu number: ");
}

void PlayGame()
{
    List <string> operationMenuText = new List<string>
    {
        $"{additionMenu} - Addition",
        $"{subtractionMenu} - Subtraction",
        $"{multiplicationMenu} - Multiplication",
        $"{divisionMenu} - Division"
    };
    List<int> operationMenuNumbers = new List<int> {additionMenu, subtractionMenu, multiplicationMenu, divisionMenu, exitMenu};
    
    ListMenu(operationMenuText);

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