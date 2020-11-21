using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    public class Greeter
    {
        static void Main(string[] args)
        {
            Greeter greeting = new Greeter();
            greeting.Greeting();
            greeting.TimeOfDayGreeting();
            greeting.Farewell();
        }

        public void Greeting()
        {
            Console.WriteLine("What is your name?:");
            string userName = Console.ReadLine();            
            Console.WriteLine($"Hello {userName} !");
        }

        public void Farewell()
        {
            Console.WriteLine("What is your name?:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Goodbye {userName} !");
        }

        public void TimeOfDayGreeting()
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 12 && now.Hour >=6)
            {
                Console.WriteLine("Good Morning");
            }
            else if (now.Hour >= 12)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (now.Hour >= 16)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
            Console.ReadKey();
        }
    }
}
