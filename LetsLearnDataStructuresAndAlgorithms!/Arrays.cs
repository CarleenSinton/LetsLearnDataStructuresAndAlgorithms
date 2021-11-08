using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    public class Arrays
    {
        public static void DescribeArray()
        {
            Console.WriteLine("     __________________________________________________________________________________________");
            ArrayGraphic();
            bool contArray = true;
            
            while (contArray) {
                Console.WriteLine("");
                Console.WriteLine("     __________________________________________________________________________________________");
                Console.WriteLine(@"

            What do you want to know about arrays?

            1. Introduction to Arrays
            2. Example of Arrays with Explanation
            3. More Information about Arrays  (Not yet implemented)
            4. How to Work With Arrays in C# (Not yet implemented)
            5. Use Arrays in a LeetCode Question with Explanation  (Not yet implemented)
            6. Return to Main Menu
            ");

                string arrayMenuSelection = Console.ReadLine();
                if (arrayMenuSelection == "1" || arrayMenuSelection.ToLower() == "introduction to arrays")
                {
                    Console.WriteLine("Introduction to Arrays");
                    BasicArrayDescription();
                }
                else if (arrayMenuSelection == "2" || arrayMenuSelection.ToLower() == "example of arrays with explanation")
                {
                    Console.WriteLine("Example of Arrays with Explanation");
                    ArrayExample();
                }
                else if (arrayMenuSelection == "3" || arrayMenuSelection.ToLower() == "more information about Arrays")
                {
                    Console.WriteLine("More Information about Arrays");
                    DeepArrayExample();
                }
                else if (arrayMenuSelection == "4" || arrayMenuSelection.ToLower() == "how to work with arrays in c#")
                {
                    Console.WriteLine("How to Work With Arrays in C#");
                    ShowArrayCode();
                }
                else if (arrayMenuSelection == "5" || arrayMenuSelection.ToLower() == "use arrays in a leetcode question with explanation")
                {
                    Console.WriteLine("Use Arrays in a LeetCode Question with Explanation");
                    UseArraysinLeetCodeY();
                } else if (arrayMenuSelection == "6" || arrayMenuSelection.ToLower() == "return to main menu")
                {
                    Console.WriteLine("Return to Main Menu");
                    contArray = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }

        private static void ArrayGraphic()
        {
            Console.WriteLine(@"
              ____  ____   ____    ____  __ __  _____
             /    ||    \ |    \  /    ||  |  |/ ___/
            |  o  ||  D  )|  D  )|  o  ||  |  (   \_ 
            |  _  ||    \ |    \ |  _  ||___, |\__  |
            |  |  ||  .  \|  .  \|  |  ||     |/  \ |
            |__|__||__|\_||__|\_||__|__||____/ \____|
            ");
        }
        private static void BasicArrayDescription()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
            Arrays are a data structure that can store a fixed-size collection of elements of the same data type.
            They let us store multiple items in just one variable and they are super useful!
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ArrayExample()
        {

            Console.WriteLine(@"
            Let's say you wanted to store the top five scores in your favorite game.
            You could store them each in their own variable, like...

            int firstScore = 2000
            int secondScore = 1550
            int thirdScore...
            ");

            Thread.Sleep(3000);

            Console.WriteLine(@"
            But what happens when you decide you want to store the top 100 scores?
            Should you create 100 variables? 
            This is where arrays shine!
            ");

            Thread.Sleep(3000);

            Console.WriteLine(@"
            You can create an array called scores, where you store a fixed amount of scores.
            Here is an example of our scores array:
            ");

            Thread.Sleep(3000);

            Console.WriteLine(@"
            ╔══════╦══════╦══════╦══════╦══════╗
            ║      ║      ║      ║      ║      ║
            ║ 2000 ║ 1550 ║ 1510 ║ 1325 ║ 1100 ║
            ║      ║      ║      ║      ║      ║
            ╚══════╩══════╩══════╩══════╩══════╝
            ");

            Console.WriteLine("");
            Thread.Sleep(3500);
        }

        private static void DeepArrayExample()
        {
            Console.WriteLine(@"
            Here is where I can continue explaining arrays
            I can explain:
                - what an index is and that they start with 0
                - how to access a specific piece of data
                - the pros and cons of arrays
            ");
        }

        private static void ShowArrayCode()
        {
            Console.WriteLine("This is where I will show how to code arrays in C#");
        }

        private static void UseArraysinLeetCodeY()
        {
            Console.WriteLine("This is where I will give a leetcode problem involving arrays and walk through solving it.");
        }
    }
}
