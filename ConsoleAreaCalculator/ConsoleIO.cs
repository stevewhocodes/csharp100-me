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
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            
        }while (true);

        return _choice;
        
    }

    public double GetPositiveValue(string prompt)
    {
        do
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out _answer))
            {
                if (_answer > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        } while (true);

        return _answer;
    }
}