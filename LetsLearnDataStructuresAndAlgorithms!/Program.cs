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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Arrays");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Dictionaries");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3. Lists");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4. BubbleSort");
            Console.WriteLine(@"
            Data Structures yet to be implemented: stacks, queues, trees, tries, matrices, graphs, heaps
            Sorting algorithms, traversal algorithms, searching algorithms
            ");
            string mainMenuSelection = Console.ReadLine();
            if(mainMenuSelection == "1" || mainMenuSelection.ToLower() == "arrays")
            {
                Arrays.DescribeArray();
            } else if(mainMenuSelection == "2" || mainMenuSelection.ToLower() == "dictionaries")
            {
                Dictionaries.DescribeDictionary();
            } else if(mainMenuSelection == "3" || mainMenuSelection.ToLower() == "lists")
            {
                Lists.DescribeList();
            } else if(mainMenuSelection == "4" || mainMenuSelection.ToLower() == "bubble sort")
            {
                BubbleSort.DescribeBubbleSort();
            }
        }
    }
}
