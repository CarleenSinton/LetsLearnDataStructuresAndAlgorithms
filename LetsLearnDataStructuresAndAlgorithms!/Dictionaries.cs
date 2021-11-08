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
            DictionaryGraphic();
            Thread.Sleep(1000);
            BasicDictionaryDescription();
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
            Console.WriteLine(@"
            A dictionary in computer science is like a dictionary for words. 
            The dictonary's keys are like the words.
            The values are like the definitions.
            ");
        }
    }
}
