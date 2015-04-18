using System;


namespace Problem_9
{
    class PrintASequence
    {
        static void Main()
        {
            Console.WriteLine("The first ten members of sequence area");
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2==0)
                {
                    Console.WriteLine(i + " ");
                }
                else
                {
                    Console.WriteLine(- i + " ");
                }
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
