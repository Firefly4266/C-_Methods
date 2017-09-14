using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            CountToTen();
            GetNumberFromUser();
            Count(5);
            Count(15);
        }
        static void CountToTen()
        {
            for (var i = 1; i <= 10; i++)
            Console.WriteLine(i);
        }
        static int GetNumberFromUser()
        {
            int userNumber = 0;

            while (userNumber < 1 || userNumber > 10)
            {
                Console.Write("Greetings user, please enter a number between 1 and 10: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(userNumber);
            return userNumber;
        }
        static int Count(int numberToCountTo)
        {
            for (var current = 1; current < numberToCountTo; current++)
                Console.WriteLine(current);
        }
    }
}
