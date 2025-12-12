
namespace AboutMe.Prompter;

public static class Prompter
{
    public static string GetRequiredString(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Please enter in a valid character.");
            }
        } while (true);
    }

    public static DateTime GetPastDate(string prompt)
    {
        DateTime input;
        do
        {
            Console.Write(prompt);
            if (DateTime.TryParse(Console.ReadLine().Trim(), out input))
            {
                if (input < DateTime.Today)
                {
                    return input;
                }
            }
        } while (true);

    }

    public static int GetIntInRange(string prompt, int min, int max)
    {
        int input;
        do
        {
            Console.Write(prompt);
            
            if (int.TryParse(Console.ReadLine().Trim(), out input))
            {
                if (input >= min && input <= max)
                {
                    return input;
                }
            }
            else
            {
                Console.WriteLine($"Enter a valid integer between {min} and {max}.");
            }
        } while (true);
    }

    public static string GetMaritalStatus(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine().Trim().ToUpper();
            if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                if (input == "S" || input == "M")
                {
                    switch (input)
                    {
                        case "S":
                            return "Single";
                            
                        case "M":
                            return "Married";
                        default:
                            return "Enter in an S or M";
                    }
                }
            }
        }while (true);
    }
    
    
}