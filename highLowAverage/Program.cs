int number;
Random random = new Random();

// prompt user for how many numbers to store in array
do
{
    Console.Write("How many numbers: ");
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (number > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Numbers must be positive.");
        }
    }
    else
    {
        Console.WriteLine("You entered an invalid number.");
    }
} while (true);

// Create array
int[] array = new int[number];

// iterate array and fill with random number between -1000 and 1000
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-1000, 1000);
}

// print summary of array's contents, including length, minimum value
// maximum value, and average of all values, rounded to 2 decimal places

Console.WriteLine($"Total Numbers: {array.Length}");
Console.WriteLine($"Low: {array.Min()}");
Console.WriteLine($"High: {array.Max()}");
Console.WriteLine($"Average: {array.Average()}");
