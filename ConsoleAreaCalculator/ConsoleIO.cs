namespace ConsoleAreaCalculator;

// Responsible for the menu and retrieving values from the user.

public class ConsoleIO
{
    private int _choice;
    private double _answer;

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Area Calculator");
        Console.WriteLine("===============");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Quit");
        Console.Write("\nEnter choice: ");

    }

    public int GetMenuChoice()
    {
        do
        {
            DisplayMenu();
            if (int.TryParse(Console.ReadLine(), out _choice))
            {
                if (_choice >= 1 && _choice <= 4)
                {
                    return _choice;
                }
            }
        } while (true);
    }

    public double GetPositiveValue(string prompt)
    {
        do
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out _answer))
            {
                if (_answer >= 0)
                {
                    return _answer;
                }
            }

            Console.WriteLine("Not a positive number.");
        } while (true);
    }
}   