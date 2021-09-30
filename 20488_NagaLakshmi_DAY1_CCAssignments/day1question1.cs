using System;

namespace question_1
{
    class Program
    {
        static void Main()
        {
            int day;
            Console.WriteLine("Enter a number representing a day in week");
            day = int.Parse(Console.ReadLine());
            if (day <= 7 && day > 0)
            {
                if (day <= 5)
                    Console.WriteLine("its a working day");
                else
                    Console.WriteLine("its a holiday");
            }
            else
                Console.WriteLine("Invalid!!!");
        }
    }
}