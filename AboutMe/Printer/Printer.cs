namespace AboutMe.Printer;

public static class Printer
{
    public static void PrintHeader()
    {
        Console.Clear();
        Console.WriteLine("About You");
        Console.WriteLine("===========================");
    }

    public static void PrintAboutMe(string fName, string lName, DateTime dob, int age, string status)
    {
        Console.WriteLine($"Name: {lName}, {fName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"DOB: {dob:d}");
        Console.WriteLine($"Marital Status: {status}");
    }
    
}