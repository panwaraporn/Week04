using System;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine(randomNumber);
            Console.Write("Your number key:");
            int Num = Convert.ToInt32(Console.ReadLine());
            bool a = Num > randomNumber;
            Console.WriteLine("Truth is : {0} > {1} ", Num, randomNumber);
            Console.WriteLine("Truth is : {0}", a);
        }
    }
}
