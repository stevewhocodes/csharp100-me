namespace Console_Properties;

public class AutoRectangle
{
    public double Length { get; private set; }
    public double Width { get; set; }
    
    public double GetArea => Width * Length;
}