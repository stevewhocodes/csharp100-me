namespace ConsoleAreaCalculator;

// Responsible for the flow of calculating an area.
// It will work with ConsoleIO and the appropriate shape class for the type of calculation the user chooses.

public class App
{
    private ConsoleIO _io = new();

    public void Run()
    {
        int choice;
        do
        {
            choice = _io.GetMenuChoice();
            switch (choice)
            {
                case 1:
                    CalculateRectangle();
                    break;
                case 2:
                    CalculateCircle();
                    break;
                case 3:
                    CalculateTriangle();
                    break;
                case 4:
                    Console.WriteLine("\nHave a good day!  Goodbye...");
                    return;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }while (choice != 4);
    }

    private void CalculateRectangle()
    {
        Rectangle rectangle = new();
        
        double length = _io.GetPositiveValue("\nEnter length: ");
        double width = _io.GetPositiveValue("Enter width: ");
        double area = rectangle.GetArea(length, width);
        Console.WriteLine($"\nThe area of a rectangle is {length}x{width} is {area}.");
       
    }

    private void CalculateCircle()
    {
        Circle circle = new();
        
        double radius = _io.GetPositiveValue("\nEnter radius: ");
        double area = circle.GetArea(radius);
        Console.WriteLine($"\nThe area of a circle with radius {radius} is {area:0.00}.");
        
    }

    private void CalculateTriangle()
    {
        Triangle triangle = new();
        
        double @base = _io.GetPositiveValue("\nEnter base: ");
        double height = _io.GetPositiveValue("Enter height: ");
        double area = triangle.GetArea(@base, height);
        Console.WriteLine($"\nThe area of a triangle with base {@base} and height {height} is {area:0.00}.");
        
    }
    
}