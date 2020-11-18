using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Week1Challenges
{
    [TestClass]
    public class Week1CodeHere
    {
        [TestMethod]
        public void RandomFromWeek1()
        {
            // Declare and initialize variables that hold your first name, last name, and age
            string firstName = "Timmy";
            string lastName = "Powers";
            short age = 32;

            // Declare and initialize an array that holds a collection of at least four of your favorite book or movie titles
            string[] favoriteBooksAndMovies = { "Memnoch The Devil", "Call Me By Your Name", "Inception", "The Heart of the Buddha's Teaching" };

            foreach (var item in favoriteBooksAndMovies)
            {
                Console.WriteLine(item + "/n");
            }

            // Make a list to hold dates, include on that list the current date and time

            // My First Attempt
            //DateTime date1 = new DateTime(1912, 04, 14);
            //DateTime date2 = new DateTime(1963, 11, 11);
            //DateTime date3 = new DateTime(2001, 09, 11);
            //DateTime current = DateTime.Now;
            //List<int> listOfDates = new List<int>();
            //listOfDates.Add(int date1);

            // My Second Attempt
            var dateList = new List<DateTime>();
            dateList.Add(new DateTime(1912, 04, 14));
            dateList.Add(new DateTime(1963, 11, 11));
            dateList.Add(new DateTime(2001, 09, 11));
            dateList.Add(DateTime.Now);
            Console.WriteLine(dateList);

            // Write out to the console the values calculated by your age variable and the number 7.
            var add7 = age + 7;
            Console.WriteLine(add7);

            var sub7 = age - 7;
            Console.WriteLine(sub7);

            var mult7 = age * 7;
            Console.WriteLine(mult7);

            var quot7 = age / 7;
            Console.WriteLine(quot7);

            var mod7 = age % 7;
            Console.WriteLine(mod7);

            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            var hoursOfSleep = 7;

            if (hoursOfSleep > 24)
            {
                Console.WriteLine("For real? Not even that many hours in a day, but nice try!");
            }
            else if (hoursOfSleep > 18 && hoursOfSleep <= 24)
            {
                Console.WriteLine("You are sleeping the day and the night away. You sure you're not in a coma?");
            }
            else if (hoursOfSleep >= 14 && hoursOfSleep <= 18)
            {
                Console.WriteLine("Dang! You need some aspirin for that headache you must have. It's time to get up!");
            }
            else if (hoursOfSleep > 10 && hoursOfSleep < 14)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursOfSleep >= 8 && hoursOfSleep <= 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursOfSleep > 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("Bummer. Well some sleep is better than none at least!");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            // Write out a switch case that evaluates a variable that holds the value for how the user's day has been

            //Classroom question
            //How do I work with user inputs while testing???

            //Console.WriteLine("How has your day been? Please type Great, Good, Okay, or Bad");
            //string userInput = Console.ReadLine();

            var userInput = "Good";

            switch (userInput)
            {
                case "Great":
                    Console.WriteLine("I'm thrilled you're having a great day!");
                    break;
                case "Good":
                    Console.WriteLine("Yay! Good days are better than bad days!");
                    break;
                case "Okay":
                    Console.WriteLine("Cheer up buckaroo. Okay is one step away from bad!");
                    break;
                case "Bad":
                    Console.WriteLine("Oh no! Bad days are never fun. It'll get better!");
                    break;
                default:
                    Console.WriteLine("Sorry. I didn't catch that. Please try again using the values Great, Good, Okay, or Bad");
                    break;
            }
        }
    }
}
