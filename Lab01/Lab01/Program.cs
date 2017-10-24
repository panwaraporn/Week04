using System;
namespace thruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A, Y;
            Console.WriteLine(" Y = Not A ");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" A | Y");
            Console.WriteLine("-----------------------");
            A = false; Y = !A;
            Console.WriteLine(" {0}\t| {1}", A, Y);
            A = true; Y = !A;
            Console.WriteLine(" {0}\t| {1}", A, Y);
        }
    }
}
