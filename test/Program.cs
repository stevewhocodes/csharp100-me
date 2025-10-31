string str = "xaxxaxaxx";

int count = 0;
string lastTwo = str[^2..];


Console.WriteLine("This is the last two.");
Console.WriteLine(lastTwo);

for (int i = 0; i < str.Length - 2; i++)
{
    if (str[i..(i + 2)] == lastTwo)
    {
        count++;
    }
}

Console.WriteLine(count);