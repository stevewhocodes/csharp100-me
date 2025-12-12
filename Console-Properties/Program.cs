using Console_Properties;

AreaRectangle rec = new();

rec.Length = -5;
rec.Width = 5;

Console.WriteLine($"The area of a rectangle with the width of {rec.Width} and length of {rec.Length} is {rec.GetArea()}");


AutoRectangle arec = new();

arec.Width = 5;
arec.Length = 5;

Console.WriteLine($"The area of a rectangle with the width of {arec.Width} and length of {arec.Length} is {arec.GetArea}");

WithoutProperty wrec = new();

wrec._length = 5;
wrec._width = 5;

Console.WriteLine($"The area of a rectangle with the width of {wrec._width} and length of {wrec._length} is {wrec.GetArea()}");
