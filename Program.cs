void DrawACat()
{
    Console.WriteLine(" /\\____/\\  MEOW");
    Console.WriteLine("|  .  . | /");
    Console.WriteLine("|    x  |");
    Console.WriteLine("|____U__|");
}

void UserReturn()
{
    Console.Write("Type anything and then press enter: ");
    string userInput = Console.ReadLine();
    Console.WriteLine(userInput);
}

void Add(int x, int y)
{
    Console.WriteLine(x + y);
}

void Subtract(int x, int y)
{
    Console.WriteLine(x - y);
}

void Multiply(int x, int y)
{
    Console.WriteLine(x * y);
}

void Divide(double x, double y)
{
    Console.WriteLine(x / y);
}

DrawACat();
UserReturn();

while(true)
{
    Console.WriteLine("Which Calculation would you like to do? (+ - x or /) and press Enter");
    string operationChoice = Console.ReadLine();

    if (operationChoice == "+")
    {
        Add(5, 6);
    }

    else if (operationChoice == "-")
    {
        Subtract(40, 12);
    }
        
    else if (operationChoice == "x")
    {
        Multiply(8, 8);
    }

    else if (operationChoice == "/")
    {
        Divide(12, 7);
    }

    else
    {
        Console.WriteLine("Invalid Response. Please Try again. (+ - x or / and Press Enter) ");
    }

    Console.WriteLine("Would you like to do another calculation? (Y or N and Press Enter)");
    string anotherCalculation = Console.ReadLine();

    if (anotherCalculation != "Y" && anotherCalculation != "y")
    {
        Console.WriteLine("Have a great Day!");
        break;
    }
}