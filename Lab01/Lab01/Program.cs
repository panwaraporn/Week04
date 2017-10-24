using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        int a = 10, b = 20, x = 5, y = 2;
        Console.WriteLine("a = 10, b = 20, x = 5, y = 2 ");
        int answer1 = a + b;
        Console.WriteLine("a + b={0} ", answer1);
        int answer2 = x - b;
        Console.WriteLine("x - b={0} ", answer2);
        int answer3 = x * b;
        Console.WriteLine("x * b={0} ", answer3);
        int answer4 = y / a;
        Console.WriteLine("y / a={0} ", answer4);
        int answer5 = b % y;
        Console.WriteLine("b % y={0} ", answer5);
        int answer6 = y + 10 % x;
        Console.WriteLine("y + 10 % x={0} ", answer6);
        int answer7 = a / 3 * 5;
        Console.WriteLine("a / 3 * 5={0} ", answer7);
        int answer8 = 9 / 2 * a;
        Console.WriteLine("9 / 2 * a={0} ", answer8);
        int answer9 = y % 8;
        Console.WriteLine("y % 8={0} ", answer9);
        int answer10 = 100 * x + y % 2 - a;
        Console.WriteLine("100 * x + y % 2 - a={0} ", answer10);
    }
}
