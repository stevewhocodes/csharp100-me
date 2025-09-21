// Print title
Console.WriteLine("Welcome to Temperature Conversion!");
Console.WriteLine("==================================");
Console.WriteLine("Available units are (C)elsius, (F)ahrenheit, and (K)elvin\n");

// prompt for temperature
Console.Write("Enter a temperature: ");
double temperature = double.Parse(Console.ReadLine());

// prompt for unit
Console.Write("Enter Unit: ");
string unit = Console.ReadLine().ToUpper();

// prompt for conversion unit
Console.Write("Enter Conversion Unit: ");
string conversionUnit = Console.ReadLine().ToUpper();

// blank space
Console.WriteLine();



// convert if needed
double converted = 0;

if (unit != "C" && unit != "F" && unit != "K")
{
    Console.WriteLine($"Please enter a valid unit! {unit} is not a valid unit!");
}
else if (conversionUnit != "C" && conversionUnit != "F" && conversionUnit != "K")
{
    Console.WriteLine($"Please enter a valid unit! {conversionUnit} is not a valid conversion unit!");
}
else if (unit == conversionUnit)
{
    Console.WriteLine($"No conversion needed to convert {unit} to {conversionUnit}.");
}
else
{

    if (unit == "C")
    {
        if (conversionUnit == "F")
        {
            converted = temperature * (9.0 / 5.0) + 32.0;
            Console.WriteLine($"A temperature of {temperature}{unit} is {Math.Round(converted, 2)}{conversionUnit}");
        }
        else if (conversionUnit == "K")
        {
            converted = temperature + 273.15;
            Console.WriteLine($"A temperature of {temperature}{unit} is {Math.Round(converted, 2)}{conversionUnit}");
        }
    }

    else if (unit == "F")
    {
        if (conversionUnit == "C")
        {
            converted = (temperature - 32.0) * (9.0 / 5.0);
            Console.WriteLine($"A temperature of {temperature}{unit} is {Math.Round(converted, 2)}{conversionUnit}");
        }
        else if (conversionUnit == "K")
        {
            converted = (temperature - 32.0) * (5.0 / 9.0) + 273.15;
            Console.WriteLine($"A temperature of {temperature}{unit} is {Math.Round(converted, 2)}{conversionUnit}");
        }
    }

    else if (unit == "K")
    {
        if (conversionUnit == "C")
        {
            converted = temperature - 273.15;
            Console.WriteLine($"A temperature of {temperature}{unit} is {Math.Round(converted, 2)}{conversionUnit}");
        }
        else if (conversionUnit == "F")
        {
            converted = (temperature - 273.15) * (9.0 / 5.0) + 32.0;
        }

    }

    Console.WriteLine($"A temperature of {temperature}{unit} is {Math.Round(converted, 2)}{conversionUnit}");

}

