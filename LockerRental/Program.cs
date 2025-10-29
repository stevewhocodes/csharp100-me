// Locker Rental


// Please write an application allowing users to manage airport locker rentals.
// The application should provide users with five menu options to
// view, rent, or end a locker rental, list all locker contents, or quit the application.


// Use a string array of length 100 to store your locker data.
// Locker numbers should be in the range of 1 to 100. Do not allow out-of-range exceptions to crash the application!
// Remember that array indexes start from zero, but humans are comfortable counting from 1. So, when prompting or displaying locker numbers, adjust the input and output accordingly.
// An application loop should keep users in the program until they choose to quit.
// Users should never be able to crash the program with bad input. Use TryParse() and loops to prevent this. 

// 

/*----------------------
 |  Menu Options
 -----------------------*/
int choice = 0;

while (choice != 5)
{
    Console.Clear();
    
    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("==========================");
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit");
    
    do
    {
        Console.Write("\nEnter your choice (1-5): ");
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            if (choice >= 1 && choice <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

    } while (true);
    
    /*----------------------
    |  Viewing a Locker
    -----------------------*/

    string[] locker = new string[100];
    locker[0] = "fish";

    do
    {
        Console.Write("Enter a locker number (1-100): ");
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            if (choice >= 1 && choice <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
        
    }while (true);
    
    switch (choice)
    {
        case 1:
            if (string.IsNullOrEmpty(locker[choice - 1]))
            {
                Console.WriteLine($"Locker {choice} is EMPTY!");
            }
            else
            {
                Console.WriteLine($"Locker {choice} contents: {locker[choice - 1]}");
            }
            break;
            
    }
    
    
    // Wait for keypress to list the menu again
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}