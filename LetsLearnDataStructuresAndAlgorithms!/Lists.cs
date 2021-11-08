using System;
using System.Collections.Generic;
using System.Text;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    class Lists
    {
        public static void DescribeList()
        {
            Console.WriteLine("     _______________________________________________________________________________________________");
            //ListGraphic();
            bool contList = true;

            while (contList)
            {
                Console.WriteLine("");
                Console.WriteLine("     _______________________________________________________________________________________________");
                Console.WriteLine(@"

            What do you want to know about lists??

            1. Introduction to Lists (Not yet implemented)
            2. Example of Lists with Explanation (Not yet implemented)
            3. More Information about Lists (Not yet implemented)
            4. How to Work with Lists in C# (Not yet implemented)
            5. Use Lists in a LeetCode Question with Explanation (Not yet implemented)
            6. Return to Main Menu
            ");
                string listMenuSelection = Console.ReadLine();
                if (listMenuSelection == "1" || listMenuSelection.ToLower() == "introduction to lists")
                {
                    Console.WriteLine("Introduction to Lists");
                    //BasicListDescription();
                }
                else if (listMenuSelection == "2" || listMenuSelection.ToLower() == "example of lists with explanation")
                {
                    Console.WriteLine("Example of Lists with Explanation");
                    //ListExample();
                }
                else if (listMenuSelection == "3" || listMenuSelection.ToLower() == "more information about lists")
                {
                    Console.WriteLine("More Information about Lists");
                    //DeepListExample();
                }
                else if (listMenuSelection == "4" || listMenuSelection.ToLower() == "how to work with lists in c#")
                {
                    Console.WriteLine("How to Work with Lists in C#");
                    //ShowListCode();
                }
                else if (listMenuSelection == "5" || listMenuSelection.ToLower() == "use lists in a leetcode question with explanation")
                {
                    Console.WriteLine("Use Lists in a LeetCode Question with Explanation");
                    //UseListsinLeetCodeY();
                }
                else if (listMenuSelection == "6" || listMenuSelection.ToLower() == "return to main menu")
                {
                    Console.WriteLine("Return to Main Menu");
                    contList = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }
    }
}
