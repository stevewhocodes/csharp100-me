namespace LockerRental.Workflow;
using LockerRental.Actions;

public class App
{

    public static void Run()
    {
        LockerManager locker = new();
        
        while (true)
        {
            int lockerNum = 0;
            ConsoleIO.GetMenu();
            int choice = ConsoleIO.GetChoice();
            

            if (choice != 4 && choice != 5)
            {
                lockerNum = ConsoleIO.GetLockerNumber();
            }
            
            switch (choice)
            {
                case 1: // View a locker
                    locker.GetLocker(lockerNum);
                break;
                case 2: // Rent a locker
                    locker.RentLocker(lockerNum);
                break;
                case 3: // End a locker rental
                    locker.CancelLocker(lockerNum);
                break;
                case 4: // list all lockers and contents
                    locker.GetAllLockers();
                break;
                case 5: // End program
                    return;
            }
            ConsoleIO.GetKeyPress();
        }
    }
}