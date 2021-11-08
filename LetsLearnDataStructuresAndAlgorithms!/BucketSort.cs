using System;
using System.Collections.Generic;
using System.Text;

namespace LetsLearnDataStructuresAndAlgorithms_
{
    class BucketSort
    {
        public static void DescribeBucketSort()
        {
            Console.WriteLine("     __________________________________________________________________________________________");
            //BucketSortGraphic();
            bool contBucketSort = true;

            while (contBucketSort)
            {
                Console.WriteLine("");
                Console.WriteLine("     __________________________________________________________________________________________");
                Console.WriteLine(@"

            What do you want to know about bucket sort?

            1. Introduction to Bucket Sort
            2. Example of Bucket Sort with Explanation
            3. See Bucket Sort with Your Own Example
            4. How to Code Bucket Sort in C#
            5. Return to Main Menu
            ");
                string bucketSortMenuSelection = Console.ReadLine();
                if (bucketSortMenuSelection == "1" || bucketSortMenuSelection.ToLower() == "introduction to bucket sort")
                {
                    Console.WriteLine("Introduction to Bucket Sort");
                    //BasicBucketSortDescription();
                }
                else if (bucketSortMenuSelection == "2" || bucketSortMenuSelection.ToLower() == "example of bucket sort with explanation")
                {
                    Console.WriteLine("Example of Bucket Sort with Explanation");
                    //BucketSortExample();
                }
                else if (bucketSortMenuSelection == "3" || bucketSortMenuSelection.ToLower() == "see bucket sort with your own example")
                {
                    Console.WriteLine("See Bucket Sort with Your Own Example");
                    //TryBucketSort();
                }
                else if (bucketSortMenuSelection == "4" || bucketSortMenuSelection.ToLower() == "how to code bucket sort in c#")
                {
                    Console.WriteLine("How to Code Bucket Sort in C#");
                    //ShowBucketSortCode();
                }
                else if (bucketSortMenuSelection == "5" || bucketSortMenuSelection.ToLower() == "return to main menu")
                {
                    Console.WriteLine("Return to Main Menu");
                    contBucketSort = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }
    }
}
