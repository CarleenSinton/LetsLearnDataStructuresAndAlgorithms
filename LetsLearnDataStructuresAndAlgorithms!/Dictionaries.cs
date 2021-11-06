using System;
using System.Collections.Generic;
using System.Text;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    class Dictionaries
    {
        public static void DescribeDictionary()
        {
            BasicDictionaryDescription();
        }

        private static void BasicDictionaryDescription()
        {
            Console.WriteLine(@"
             ____  _      _   _                        _           
            |  _ \(_)    | | (_)                      (_)          
            | | | |_  ___| |_ _  ___  _ __   __ _ _ __ _  ___  ___ 
            | | | | |/ __| __| |/ _ \| '_ \ / _` | '__| |/ _ \/ __|
            | |/ /| | (__| |_| | (_) | | | | (_| | |  | |  __/\__ \
            |___/ |_|\___|\__|_|\___/|_| |_|\__,_|_|  |_|\___||___/
                                                       
            ");

            Console.WriteLine(@"
            A dictionary in computer science is like a dictionary for words. 
            The dictonary's keys are like the words.
            The values are like the definitions.
            ");
        }
    }
}
