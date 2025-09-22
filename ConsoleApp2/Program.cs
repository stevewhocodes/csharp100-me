int init, condition, increment;

do
{
    Console.Write("Enter loop init: ");
    if (int.TryParse(Console.ReadLine(), out init))
    {
        break;
    }
    Console.WriteLine("That is not a valid int.");
} while (true);
do
{
    Console.Write("Enter loop increment: ");
    if (int.TryParse(Console.ReadLine(), out increment))
    {
       break;
    }
    Console.WriteLine("That is not a valid int.");
} while (true);
do
{
    Console.Write("Enter loop condition: ");
    if (int.TryParse(Console.ReadLine(), out condition))
    {
        if (increment < 0 && condition < init)
        {
            for (int i = init; i > condition; i += increment)
            {
                Console.WriteLine(i);
            }
            break;
        } 
        else if (increment > 0 && condition > init)
        {
            for (int i = init; i < condition; i += increment)
            {
                Console.WriteLine(i);
            }
            break;
        }
        else
        {
            Console.WriteLine("If Condition is negative, must be less than the init value");
            Console.WriteLine("If Condition is positive, must be greater than the init value");
        }
    }
    Console.WriteLine("That is not a valid int.");
} while (true);

