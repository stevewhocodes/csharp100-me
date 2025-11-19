namespace test.Custom;

public class Console
{
    // Field values.  They are like variables
    public const double PI = 3.14;
    public double _radius;

    public Console(double radius)
    {
        _radius = radius;
    }

    public string Fish()
    {
        return "Fishy fish!";
    }

    public int Sum(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    public int Sum1(int num, int num1, int num2)
    {
        int sum = num + num1 + num2;
        return sum;
    }

}