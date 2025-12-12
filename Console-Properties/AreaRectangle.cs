namespace Console_Properties;

public class AreaRectangle
{
    public double _length;
    public double _width;
    
    public double Length
    {
        get {return _length;}
        set
        {
            do
            {
                if (value > 0)
                {
                    _length = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Value must be positive: .");
                    value = double.Parse(Console.ReadLine());
                }

            } while (true);
        }
    }

    public double Width
    {
        get {return _width;}
        set { _width = value; }
    }

    public double GetArea()
    {
        return Length * Width;
    }



}