using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    class Dictionaries
    {
        public static void DescribeDictionary()
        {
            Console.WriteLine("     _______________________________________________________________________________________________");
            DictionaryGraphic();
            bool contDictionary = true;

            while (contDictionary)
            {
                Console.WriteLine("");
                Console.WriteLine("     _______________________________________________________________________________________________");
                Console.WriteLine(@"

            What do you want to know about dictionaries??

            1. Introduction to Dictionaries
            2. Example of Dictionaries with Explanation (Not yet implemented)
            3. More Information about Dictionaries (Not yet implemented)
            4. How to Work with Dictionaries in C# (Not yet implemented)
            5. Use Dictionaries in a LeetCode Question with Explanation (Not yet implemented)
            6. Return to Main Menu
            ");
                string dictionaryMenuSelection = Console.ReadLine();
                if (dictionaryMenuSelection == "1" || dictionaryMenuSelection.ToLower() == "introduction to dictionaries")
                {
                    Console.WriteLine("Introduction to Dictionaries");
                    BasicDictionaryDescription();
                }
                else if (dictionaryMenuSelection == "2" || dictionaryMenuSelection.ToLower() == "example of dictionaries with explanation")
                {
                    Console.WriteLine("Example of Dictionaries with Explanation");
                    //DictionaryExample();
                }
                else if (dictionaryMenuSelection == "3" || dictionaryMenuSelection.ToLower() == "more information about dictionaries")
                {
                    Console.WriteLine("More Information about Dictionaries");
                    //DeepDictionaryExample();
                }
                else if (dictionaryMenuSelection == "4" || dictionaryMenuSelection.ToLower() == "how to work with dictionaries in c#")
                {
                    Console.WriteLine("How to Work with Dictionaries in C#");
                    //ShowDictionaryCode();
                }
                else if (dictionaryMenuSelection == "5" || dictionaryMenuSelection.ToLower() == "use dictionaries in a leetcode question with explanation")
                {
                    Console.WriteLine("Use Dictionaries in a LeetCode Question with Explanation");
                    //UseDictionariesinLeetCodeY();
                }
                else if (dictionaryMenuSelection == "6" || dictionaryMenuSelection.ToLower() == "return to main menu")
                {
                    Console.WriteLine("Return to Main Menu");
                    contDictionary = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }

        private static void DictionaryGraphic()
        {
            Console.WriteLine(@"
             ____  _      _   _                        _           
            |  _ \(_)    | | (_)                      (_)          
            | | | |_  ___| |_ _  ___  _ __   __ _ _ __ _  ___  ___ 
            | | | | |/ __| __| |/ _ \| '_ \ / _` | '__| |/ _ \/ __|
            | |/ /| | (__| |_| | (_) | | | | (_| | |  | |  __/\__ \
            |___/ |_|\___|\__|_|\___/|_| |_|\__,_|_|  |_|\___||___/
                                                       
            ");
        }

        private static void BasicDictionaryDescription()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
            A dictionary in computer science is like a dictionary for words. 
            The dictonary's keys are like the words.
            The values are like the definitions.
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
