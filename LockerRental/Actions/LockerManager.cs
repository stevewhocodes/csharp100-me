using LockerRental.DTOs;

namespace LockerRental.Actions;

public class LockerManager
{
    private LockerContents dto = new();
    // Array to store locker contents

    LockerContents[] _locker = new LockerContents[100];

    public void GetLocker(int lockerNum)
    {
        if (_locker[lockerNum - 1] == null)
        {
            Console.WriteLine($"Locker {lockerNum} is EMPTY!");
        }
        else
        {
            LockerManager contents = new();
            GetContents(lockerNum, _locker[lockerNum - 1]);
        }
    }

    private static void GetContents(int lockerNum, LockerContents dto)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine($"Locker #: {lockerNum}");
        Console.WriteLine($"Renter Name: {dto.RenterName}");
        Console.WriteLine($"Contents: {dto.Description}");
        Console.WriteLine("===========================================");
    }

    public void RentLocker(int lockerNum)
    {
        if (_locker[lockerNum - 1] != null)
        {
            Console.WriteLine($"Sorry, but Locker {lockerNum} has already been rented!");
        }
        else
        {
            LockerContents locker = new();
            
            locker.RenterName = ConsoleIO.GetInput("Enter your name: ");
            locker.Description = ConsoleIO.GetInput("Enter the item you want to store in the locker: ");

            _locker[lockerNum - 1] = locker;
            
            Console.WriteLine();
            GetContents(lockerNum, _locker[lockerNum - 1]);
        }
    }

    public void CancelLocker(int lockerNum)
    {
        if (_locker[lockerNum - 1] == null)
        {
            Console.WriteLine($"Locker {lockerNum} is not currently rented.");
        }
        else
        {
            LockerContents item = _locker[lockerNum - 1];
            _locker[lockerNum - 1] = null;
            Console.WriteLine();
            Console.WriteLine("Locker rental has ended for the following:");
            GetContents(lockerNum, item);
        }
    }

    public void GetAllLockers()
    {
        Console.WriteLine();
        for (int i = 0; i < _locker.Length; i++)
        {
            if (_locker[i] != null)
            {
                GetContents(i + 1, _locker[i]);
                        
            }
                   
        }
    }
    
    
}