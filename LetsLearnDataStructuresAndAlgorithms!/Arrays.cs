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
            bool describeArrays = true;
            while (describeArrays) {
                ArrayGraphic();
                Thread.Sleep(1000);
                BasicArrayDescription();


                Console.WriteLine("Would you like an example (y/n)?");
                string continueDescribeArray = Console.ReadLine();
                if(continueDescribeArray == "y" || continueDescribeArray == "yes")
                {
                    describeArrays = ArrayExample();
                } else
                {
                    describeArrays = false;
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
            Console.WriteLine(@"
            Arrays are a data structure that can store a fixed-size collection of elements of the same data type.

            They let us store multiple items in just one variable and they are super useful!
            ");
        }

        private static bool ArrayExample()
        {

            Console.WriteLine(@"
            Let's say you wanted to store the top five scores in your favorite game.
            You could store them each in their own variable, like...

            int firstScore = 2000
            int secondScore = 1550
            int thirdScore...
            ");

            Console.WriteLine(@"
            But what happens when you decide you want to store the top 100 scores?
            Should you create 100 variables? 
            This is where arrays shine!
            ");

            Console.WriteLine(@"
            You can create an array called scores, where you store a fixed amount of scores.
            Here is an example of our scores array:
            ");

            Console.WriteLine(@"
            ╔══════╦══════╦══════╦══════╦══════╗
            ║      ║      ║      ║      ║      ║
            ║ 2000 ║ 1550 ║ 1510 ║ 1325 ║ 1100 ║
            ║      ║      ║      ║      ║      ║
            ╚══════╩══════╩══════╩══════╩══════╝
            ");

            Console.WriteLine("");
            Console.WriteLine(@"
            Here is where I can continue explaining arrays
            I can explain:
                - what an index is and that they start with 0
                - how to access a specific piece of data
                - the pros and cons of arrays
            ");

            return false;
        }
    }
}
