const int playGameMenu = 1;
const int viewScoresMenu = 2;
const int additionMenu = 1;
const int subtractionMenu = 2;
const int multiplicationMenu = 3;
const int divisionMenu = 4;
const int randomGameMenu = 5;
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
    const int numberOfQuestions = 5;
    List <string> operationMenuText = new List<string>
    {
        $"{additionMenu} - Addition",
        $"{subtractionMenu} - Subtraction",
        $"{multiplicationMenu} - Multiplication",
        $"{divisionMenu} - Division",
        $"{randomGameMenu} - Random(All of the above)"
    };
    List<int> operationMenuNumbers = new List<int> 
    {
        additionMenu, subtractionMenu, multiplicationMenu, divisionMenu, randomGameMenu, exitMenu
    };
    
    ListMenu(operationMenuText);

    int operationNumber = GetSelectedMenu(operationMenuNumbers);

    if (operationNumber == randomGameMenu)
    {
        Random random = new Random();
        for (int i = 0; i < numberOfQuestions; i++)
        {
            operationNumber = random.Next(1, 5);    
            OperationQuestion(operationNumber);
        }

        return;
    }

    for (int i = 0; i < numberOfQuestions; i++)
        OperationQuestion(operationNumber);
}

void OperationQuestion(int operationNumber)
{
    Random random = new Random();
    const int easyAdditionSubtractionDivisionMax = 101;
    const int easyMultiplicationMaxNumber1 = 21;
    const int easyMultiplicationMaxNumber2 = 11;
    int numberFirst;
    int numberSecond;
    int correctAnswer;

    switch (operationNumber)
    {
        case additionMenu:
            numberFirst = random.Next(0, easyAdditionSubtractionDivisionMax);
            numberSecond = random.Next(0, easyAdditionSubtractionDivisionMax);

            System.Console.Write($"{numberFirst} + {numberSecond}?: ");
            correctAnswer = numberFirst + numberSecond;

            CheckAnswer(correctAnswer);            
            break;
        case subtractionMenu:
            numberFirst = random.Next(0, easyAdditionSubtractionDivisionMax);
            numberSecond = random.Next(0, easyAdditionSubtractionDivisionMax);

            System.Console.Write($"{numberFirst} - {numberSecond}?: ");
            correctAnswer = numberFirst - numberSecond;

            CheckAnswer(correctAnswer);  
            break;
        case multiplicationMenu:
            numberFirst = random.Next(0, easyMultiplicationMaxNumber1);
            numberSecond = random.Next(0, easyMultiplicationMaxNumber2);

            System.Console.Write($"{numberFirst} * {numberSecond}?: ");
            correctAnswer = numberFirst * numberSecond;

            CheckAnswer(correctAnswer);  
            break;
        case divisionMenu:
            numberFirst = random.Next(0, easyAdditionSubtractionDivisionMax);
            numberSecond = random.Next(1, numberFirst + 1);

            while (numberFirst % numberSecond != 0)
            {
                numberSecond = random.Next(1, numberFirst + 1);
            }

            System.Console.Write($"{numberFirst} / {numberSecond}?: ");
            correctAnswer = numberFirst / numberSecond;

            CheckAnswer(correctAnswer);
            break;
        case exitMenu:
            break;
        default:
            break;
    }
}

void CheckAnswer(int correctAnswer)
{
    string? input = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(input) && Int32.TryParse(input, out int number) && number == correctAnswer)
        System.Console.WriteLine($"Correct! The answer is {correctAnswer}.\n");
    else
        System.Console.WriteLine($"Incorrect! The answer is {correctAnswer}.\n");
}

void ListScores()
{
    
}

int GetSelectedMenu(List<int> validMenuNumbers)
{
    string? input = Console.ReadLine();
    int number;
    
    while (String.IsNullOrWhiteSpace(input) || !Int32.TryParse(input, out number) || !validMenuNumbers.Contains(number))
    {
        System.Console.Write("Please select a menu number: ");
        input = Console.ReadLine();
    }

    return number;
}