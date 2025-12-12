namespace TemperatureConverter;

public class Temperature
{
    private double _kelvin;
    
    public double Kelvin
    {
        get => _kelvin;
        set
        {
            if (value < 0)
            {
                _kelvin = 0;
            }
            else
            {
                _kelvin = value;
            }
        }
    }

    public double Celsius => Kelvin - 273.15;

    public double Fahrenheit => Celsius * 9 / 5 + 32;
}
