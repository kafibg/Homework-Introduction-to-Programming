using System;


namespace Problem_11
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Enter your year:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 year be: {0}",age + 10);
        }
    }
}
