// Locker Rental


// Please write an application allowing users to manage airport locker rentals.
// The application should provide users with five menu options to
// view, rent, or end a locker rental, list all locker contents, or quit the application.


// Use a string array of length 100 to store your locker data.
// Locker numbers should be in the range of 1 to 100. Do not allow out-of-range exceptions to crash the application!
// Remember that array indexes start from zero, but humans are comfortable counting from 1. So, when prompting or displaying locker numbers, adjust the input and output accordingly.
// An application loop should keep users in the program until they choose to quit.
// Users should never be able to crash the program with bad input. Use TryParse() and loops to prevent this. 



/*----------------------
 |  variables
 -----------------------*/
int choice = 0; // Menu Choice
int lockerNum = 0; // locker number choice

/*--------------------------------
 |  Array to store locker contents
 --------------------------------*/
string[] locker = new string[100];

/*----------------------
 |  Menu Options
 -----------------------*/
while (true)
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

    /*---------------------------------------
    |  Exit application if 5. Quit is chosen. 
    ----------------------------------------*/
    if (choice == 5)
    {
        Console.WriteLine("Thanks, and have a great day!");
        break;
    }
    
    /*----------------------
    |  Choose a locker number
    -----------------------*/
    
    do
    {
        if (choice == 4)
        {
            break;
        }
        else
        {
            Console.Write("Enter a locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNum))
            {
                if (lockerNum >= 1 && lockerNum <= 100)
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
        }
        
    }while (true);
    
    /*-------------------------
    |  Execute Menu choices
    --------------------------*/
    
    switch (choice)
    {
        case 1: // View a locker
            if (string.IsNullOrEmpty(locker[lockerNum - 1]))
            {
                Console.WriteLine($"Locker {lockerNum} is EMPTY!");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNum} contents: {locker[lockerNum - 1]}");
            }
            break;
        case 2: // Rent a locker
            if (locker[lockerNum - 1] != null)
            {
                Console.WriteLine($"Sorry, but Locker {lockerNum} has already been rented!");
            }
            else
            {
                Console.Write("Enter the item you want to store in the locker: ");
                locker[lockerNum -1] = Console.ReadLine();
                Console.WriteLine($"Locker {lockerNum} has been rented for {locker[lockerNum -1]} storage.");
            }
            break;
        case 3: // End a locker rental
            if (locker[lockerNum - 1] == null)
            {
                Console.WriteLine($"Locker {lockerNum} is not currently rented.");
            }
            else
            {
                string item = locker[lockerNum - 1];
                locker[lockerNum - 1] = null;
                Console.WriteLine($"Locker {lockerNum} has ended, please take your {item}");
            }
            break;
        case 4: // list all lockers and contents
            Console.WriteLine();
            for (int i = 0; i < locker.Length; i++)
            {
                if (!string.IsNullOrEmpty(locker[i]))
                {
                    Console.WriteLine($"Locker {i + 1}: {locker[i]}");
                    
                }
               
            }
            break;
    }
    
    /*----------------------------------------
   |  Wait for keypress to list the menu again
   ------------------------------------------*/
  
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}