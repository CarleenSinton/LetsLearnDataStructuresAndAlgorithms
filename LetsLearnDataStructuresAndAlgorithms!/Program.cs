using System;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"

             ██╗     ███████╗████████╗██╗ ██████╗  ██╗     ███████╗ █████╗ ██████╗ ███╗  ██╗
             ██║     ██╔════╝╚══██╔══╝╚█║██╔════╝  ██║     ██╔════╝██╔══██╗██╔══██╗████╗ ██║
             ██║     █████╗     ██║    ╚╝╚█████╗   ██║     █████╗  ███████║██████╔╝██╔██╗██║
             ██║     ██╔══╝     ██║       ╚═══██╗  ██║     ██╔══╝  ██╔══██║██╔══██╗██║╚████║
             ███████╗███████╗   ██║      ██████╔╝  ███████╗███████╗██║  ██║██║  ██║██║ ╚███║
             ╚══════╝╚══════╝   ╚═╝      ╚═════╝   ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚══╝

                 ████████╗ █████╗  ██████╗ ███████╗████████╗██╗  ██╗███████╗██████╗ ██╗
                 ╚══██╔══╝██╔══██╗██╔════╝ ██╔════╝╚══██╔══╝██║  ██║██╔════╝██╔══██╗██║
                    ██║   ██║  ██║██║  ██╗ █████╗     ██║   ███████║█████╗  ██████╔╝██║
                    ██║   ██║  ██║██║  ╚██╗██╔══╝     ██║   ██╔══██║██╔══╝  ██╔══██╗╚═╝
                    ██║   ╚█████╔╝╚██████╔╝███████╗   ██║   ██║  ██║███████╗██║  ██║██╗
                    ╚═╝    ╚════╝  ╚═════╝ ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝

              ");

            while (true)
            {
                MainMenu();
            }
        }

        static void MainMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("     _____________________________________________________________________________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Let's Learn Data Structures and Algorithms!");
            Console.WriteLine(" ");
            Console.WriteLine("Please start by choosing what you want to learn from the options below. You can type the number or the word(s) to select an option.");
            Console.WriteLine("1. Arrays");
            Console.WriteLine("2. Dictionaries");
            string mainMenuSelection = Console.ReadLine();
            if(mainMenuSelection == "1" || mainMenuSelection.ToLower() == "arrays")
            {
                Arrays.DescribeArray();
            } else if(mainMenuSelection == "2" || mainMenuSelection.ToLower() == "dictionaries")
            {
                Dictionaries.DescribeDictionary();
            }
        }
    }
}
