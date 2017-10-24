using System;
public class MathTest
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 11; i += 1)
        {
            Console.WriteLine("The X*X of {0,10:G} = {1,-10:G}" +
            spaces(Math.Abs(i * i)) + "*", i, Math.Abs(i * i));
        }
    }
    private static string spaces(double val)
    {
        string SpaceString = new String(' ', ((int)(val * 2)) + 2);
        return SpaceString;
    }
}
