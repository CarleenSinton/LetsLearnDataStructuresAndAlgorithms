using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    class BubbleSort
    {
        public static void DescribeBubbleSort()
        {
            Console.WriteLine("     __________________________________________________________________________________________");
            BubbleSortGraphic();
            bool contBubbleSort = true;

            while (contBubbleSort)
            {
                Console.WriteLine("");
                Console.WriteLine("     __________________________________________________________________________________________");
                Console.WriteLine(@"

            What do you want to know about bubble sort?

            1. Introduction to Bubble Sort
            2. Example of Bubble Sort with Explanation
            3. See Bubble Sort with Your Own Example
            4. How to Code Bubble Sort in C#
            5. Return to Main Menu
            ");
                string bubbleSortMenuSelection = Console.ReadLine();
                if (bubbleSortMenuSelection == "1" || bubbleSortMenuSelection.ToLower() == "introduction to bubble sort")
                {
                    Console.WriteLine("Introduction to Bubble Sort");
                    BasicBubbleSortDescription();
                }
                else if (bubbleSortMenuSelection == "2" || bubbleSortMenuSelection.ToLower() == "example of bubble sort with explanation")
                {
                    Console.WriteLine("Example of Bubble Sort with Explanation");
                    BubbleSortExample();
                }
                else if (bubbleSortMenuSelection == "3" || bubbleSortMenuSelection.ToLower() == "see bubble sort with your own example")
                {
                    Console.WriteLine("See Bubble Sort with Your Own Example");
                    TryBubbleSort();
                } else if (bubbleSortMenuSelection == "4" || bubbleSortMenuSelection.ToLower() == "how to code bubble sort in c#")
                {
                    Console.WriteLine("How to Code Bubble Sort in C#");
                    ShowBubbleSortCode();
                }
                else if (bubbleSortMenuSelection == "5" || bubbleSortMenuSelection.ToLower() == "return to main menu")
                {
                    Console.WriteLine("Return to Main Menu");
                    contBubbleSort = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }

        private static void BubbleSortGraphic()
        {
            Console.WriteLine(@"
             ____  __  __  ____  ____  __    ____    ___  _____  ____  ____ 
            (  _ \(  )(  )(  _ \(  _ \(  )  ( ___)  / __)(  _  )(  _ \(_  _)
             ) _ < )(__)(  ) _ < ) _ < )(__  )__)   \__ \ )(_)(  )   /  )(  
            (____/(______)(____/(____/(____)(____)  (___/(_____)(_)\_) (__) 
            ");
        }

        private static void BasicBubbleSortDescription()
        {
            Console.WriteLine(@"
            One of the simplest sorting algorithms (but not very efficient), bubble sort repeatedly compares
            adjacent elements and swaps them if they are in the wrong order. 
            ");
            Thread.Sleep(2000);
        }

        private static void BubbleSortExample()
        {
            Console.WriteLine("First Pass: ");
            Console.Write("( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("5 1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("4 2 8 ) –> ( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("4 2 8 ), Here, the algorithm compares the first two elements, and swaps them since 5 > 1.");
            
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");
            
            Console.Write("( 1 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("5 4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2 8 ) –> ( 1 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4 5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2 8 ), Swap since 5 > 4");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("( 1 4 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("5 2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("8 ) –> ( 1 4 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2 5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("8 ), Swap since 5 > 2 ");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("( 1 4 2 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("5 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") –> ( 1 4 2 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("5 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("), Since these elements are already in order (8 > 5), the algorithm does not swap them.");

            Console.WriteLine("");
            Thread.Sleep(1500);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
            As an optimization, we can decrement are loop by one each pass through.
            This is because we know that the largest number will have bubbled to the end.
            In this example, the we know the largest number (8) is now in it's correct place(shown now in blue)
            ");

            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Second Pass: ");
            Console.Write("( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2 5 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") –> ( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2 5 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(")");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("( 1 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4 2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("5 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") –> ( 1 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2 4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("5 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("), Swap since 4 > 2");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("( 1 2 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4 5 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") –> ( 1 2 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4 5 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(")");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
            We can now see that the array is already sorted, but our algorithm does not know if it is completed yet. 
            The algorithm needs one whole pass without any swaps to know it is sorted.
            ");

            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Third Pass: ");
            Console.Write("( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("4 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("5 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") –> ( ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("4 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("5 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(")");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("( 1 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2 4 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("5 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") –> ( 1 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2 4 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("5 8 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(")");

            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.WriteLine("We've now made it a whole time through without any swaps! Our array is sorted.");
            Console.WriteLine("( 1 2 4 5 8 )");

            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("");
        }

        private static void TryBubbleSort()
        {
            Console.WriteLine("Please enter your numbers separated by a space, like the example below: ");
            Console.WriteLine("1 3 7 9 2");
            string tryBubbleSortUserInput = Console.ReadLine();
            string[] splitString = tryBubbleSortUserInput.Split(" ");
            int[] toSort = new int[splitString.Length];
            for(int i = 0; i < toSort.Length; i++)
            {
                toSort[i] = Convert.ToInt32(splitString[i]);
            }

            DoBubbleSort(toSort);
        }

        private static void DoBubbleSort(int[] toSort)
        {
            //to check if sorted (full pass without any swaps)
            bool isSorted = false;
            //to shorten the length to loop through by 1 each pass through the array
            //because each pass bubbles the largest number to the end
            int lastUnsorted = toSort.Length - 1;
            int numPassThrough = 1;
            //loop through until sorted
            while (!isSorted)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pass Through #{0}", numPassThrough);
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.White;

                isSorted = true;
                // loop and compare side by side
                for(int i = 0; i < lastUnsorted; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Step #{0}", i + 1);
                    for (int j = 0; j < toSort.Length; j++)
                    {
                        Console.Write(toSort[j] + " ");
                    }
                    Console.Write(" ---> ");
                    Thread.Sleep(1000);
                    if (toSort[i] > toSort[i + 1])
                    {
                        //swap them
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                        isSorted = false;
                    }
                    for (int j = 0; j < toSort.Length; j++)
                    {
                        Console.Write(toSort[j] + " ");
                    }
                    Console.WriteLine("");
                }
                lastUnsorted = lastUnsorted - 1;
                numPassThrough = numPassThrough + 1;
            }

            Console.WriteLine("The array is sorted!");

        }

        private static void ShowBubbleSortCode()
        {
            Console.WriteLine(@"
            private static void DoBubbleSort(int[] toSort)
            {
                //to check if sorted (full pass without any swaps)
                bool isSorted = false;

                //to shorten the length to loop through by 1 each pass through the array
                //because each pass bubbles the largest number to the end
                int lastUnsorted = toSort.Length - 1;

                //loop through until sorted
                while (!isSorted)
                {
                    // set to true so that if there are no swaps, the loop is exited
                    isSorted = true;

                    // loop and compare side by side
                    for (int i = 0; i < lastUnsorted; i++)
                    {
                        //check if the left is larger than the right element to see if they need to swap
                        if (toSort[i] > toSort[i + 1])
                        {
                            //swap the two that are out of order
                            int temp = toSort[i];
                            toSort[i] = toSort[i + 1];
                            toSort[i + 1] = temp;

                            //set isSorted to false because a trade needed to happen
                            isSorted = false;
                        }
                    }

                    // decrease the size of lastUnsorted on each pass through the array
                    lastUnsorted = lastUnsorted - 1;
                }

            }
            ");

            Thread.Sleep(2000);
        }
    }
}
