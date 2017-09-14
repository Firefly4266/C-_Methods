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
            Greet();
            Math();
            Ceeya();
        }
        static void Greet()
        {
            Console.Write("\n Greetings User! I have some math for you today. We'll keep it simple.  What is 2 + 2? ");
            int greetingAnswer = int.Parse(Console.ReadLine());
            if (greetingAnswer == 4)
            {
                Console.WriteLine("\n You are correct, well done!");
            }
            else
            {
                Console.WriteLine(" I'm sorry, that is incorrect.  Next question...");
            }
        }
        static void Math()
        {
            Console.Write($"\n More basic math.  What is 2 + 2 / 2? ");
            int mathAnswer = Convert.ToInt32(Console.ReadLine());
            if (mathAnswer == 2)
            {
                Console.WriteLine("\n You are correct!");               
            }
            else
            {
                Console.WriteLine("\n I'm sorry, that is incorrect.  Next question...");
            }
        }
        static void Ceeya()
        {
            Console.Write("\n Ok, last one. How many licks does it take to get to the center of a Tootse Roll Tootse Pop? ");
            int ceeyaAnswer = int.Parse(Console.ReadLine());
            if (ceeyaAnswer == 3)
            {
                Console.WriteLine("\n You are correct, well done!");
            }
            else
            {
                Console.WriteLine(" Wow! You messed that up...CEEYA!!!\n");
            }
            
        }
        //static void Answer()
        //{

        //}
    }
}
