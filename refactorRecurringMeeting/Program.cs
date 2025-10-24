// variables for start, end, frequency, and skipping weekends
DateTime start, end;
string frequency;
string skipweekends = "N";

// prompt for start date

do
{
    Console.Write("Enter start date: ");
    if (DateTime.TryParse(Console.ReadLine(), out start))
    {
        break;
    }
    else
    {
        Console.WriteLine("That is not a valid date!");
    }
}while(true);

// prompt for end date, check if > start date

do
{
    Console.Write("Enter end date: ");
    if (DateTime.TryParse(Console.ReadLine(), out end))
    {
        if (end > start)
        {
            break;
        }
        else
        {
            Console.WriteLine("End date must be after start date!");
        }
    }
    else
    {
        Console.WriteLine("That is not a valid date!");
    }
}while(true);

// prompt for frequency

do
{
    Console.Write("Enter frequency [(D)aily, (W)eekly, (M)onthly, (Y)early]: ");
    frequency = Console.ReadLine().ToUpper();

    if (frequency == "D" || frequency == "W" || frequency == "M" || frequency == "Y")
    {
        break;
    }
    else
    {
        Console.WriteLine("That is not a valid frequency!");
    }
}while(true);

// prompt for weekends if frequency is daily
if (frequency == "D")
{
    do
    {
        Console.Write("Skip weekends (Y/N): ");
        skipweekends = Console.ReadLine().ToUpper();
        
        if (skipweekends == "Y" || skipweekends == "N")
        {
            break;
        }else
        {
            Console.WriteLine("That is not a valid entry!");
        }
    }while(true);
}

// print header
Console.WriteLine("\nMeetingDates");
Console.WriteLine("=============");

// set first date
DateTime current = start;

// loop until end date is reached
while (current <= end)
{
    // print first date, format from string formatting lesson
    Console.WriteLine($"{current:dddd MMM d, yyyy}");

    switch (frequency)
    {
        // handle weekends if necessary by adding additional days (Daily)
        case "D":
            current = current.AddDays(1);
            if (skipweekends == "Y" && current.DayOfWeek == DayOfWeek.Saturday)
            {
                current = current.AddDays(2);
            }
            else if (skipweekends == "Y" && current.DayOfWeek == DayOfWeek.Sunday)
            {
                current = current.AddDays(1);
            }

            break;
        // add 7 days
        case "W":
            current = current.AddDays(7);
            break;
        // add 1 month
        case "M":
            current = current.AddMonths(1);
            break;
        // add 1 year
        case "Y":
            current = current.AddMonths(1);
            break;
    }
}
