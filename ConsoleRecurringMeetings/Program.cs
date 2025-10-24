DateTime startDate, endDate;
String frequency;
String weekends = "N";
// Prompt for start date
do
{
    Console.Write("Enter start date: ");

    if (DateTime.TryParse(Console.ReadLine(), out startDate))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Date.");
    }
} while (true);

// Prompt for end date

do
{
    Console.Write("Enter end date: ");
    if (DateTime.TryParse(Console.ReadLine(), out endDate))
    {
        if (endDate > startDate)
        {
            break;
        }
        else
        {
            Console.WriteLine("End date needs to be greater than start date.");
        }

    }
    else
    {
        Console.WriteLine("Invalid Date.");
    }
} while (true);

// Prompt for Frequency (D,W,M,Y)


do
{
    Console.Write("Enter Frequency [(D)aily, (W)eekly, (M)onthly, (Y)early]: ");
    frequency = Console.ReadLine().ToUpper();
    if (frequency == "D" || frequency == "W" || frequency == "M" || frequency == "Y")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Frequency.");
    }
} while(true);


// prompt to skip weekends
if (frequency == "D")
{
    do
    {
        Console.Write("Skip Weekends (Y/N): ");
        weekends = Console.ReadLine().ToUpper();
        if (weekends == "Y" || weekends == "N")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid Weekends.");
        }
    }while (true);
}



// Keep track of current date while looping
DateTime current = startDate;

// print out header and first date
Console.WriteLine("\nMeeting Dates");
Console.WriteLine("=============");


while (current <= endDate)
{
    // print out date
    Console.WriteLine($"{current:dddd MMM d, yyyy}");
   
    switch (frequency)
    {
        case "D":
            current = current.AddDays(1);
            if (weekends == "Y" && current.DayOfWeek == DayOfWeek.Saturday)
            {
                current = current.AddDays(2);
            }
            else if (weekends == "Y" && current.DayOfWeek == DayOfWeek.Sunday)
            {
                current = current.AddDays(1);
            }
            break;
        case "W":
            current = current.AddDays(7);
            break;
        case "M": 
            current = current.AddMonths(1);
            break;
        case "Y":
            current = current.AddYears(1);
            break;
    }
    

}