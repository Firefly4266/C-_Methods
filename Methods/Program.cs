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
            Console.Write("\n Greetings User! How are you doing today? ");
            string userInput = Console.ReadLine();
        }
        static void Math()
        {
            Console.Write($"\n Help me with some basic math.  What is 2 + 2 / 2? ");
            Console.ReadLine();
        }
        static void Ceeya()
        {
            Console.Write("\n Oh, I'm sorry.  Were you waiting for a response? ");
            Console.ReadLine();
            Console.WriteLine("\n Well I hope you're not holding your breath!\n");
        }
    }
}
