namespace LockerRental.Actions;

public class ConsoleIO
{
    
    public static void GetMenu()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("Airport Locker Rental Menu");
        Console.WriteLine("==========================");
        Console.WriteLine("1. View a locker");
        Console.WriteLine("2. Rent a locker");
        Console.WriteLine("3. End a locker rental");
        Console.WriteLine("4. List all locker contents");
        Console.WriteLine("5. Quit");
    }

    public static int GetChoice()
    {
        int choice = 0; // Menu Choice
        do
        {
            Console.Write("\nEnter your choice (1-5): ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= 1 && choice <= 5)
                {
                    return choice;
                }
            }
        } while (true);
    }

    public static int GetLockerNumber()
    {
        int lockerNum = 0; // locker number
        do
        {
            Console.Write("Enter a locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNum))
            {
                if (lockerNum >= 1 && lockerNum <= 100)
                {
                    return lockerNum;
                }
            }
        } while (true);
    }

    public static string GetInput(string prompt)
    {
        
        Console.Write(prompt);
        string input = Console.ReadLine();
        do
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
        } while (true);
    }

    public static void GetKeyPress()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}