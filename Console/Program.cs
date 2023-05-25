using System;
using System.Collections.Generic;
using System.IO;
using MaxSumLibrary;

namespace MaxSumConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;

            if (args.Length > 0)
            {
                filePath = args[0];
            }
            else
            {
                Console.WriteLine("Enter the file path:");
                filePath = Console.ReadLine();
            }

            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                int maxSumLineIndex = MaxSumFinder.FindMaxSumLineIndex(lines);
                List<string> invalidLines = MaxSumFinder.FindInvalidLines(lines);

                Console.WriteLine($"The row with the maximum sum of elements: {maxSumLineIndex + 1}");

                if (invalidLines.Count > 0)
                {
                    Console.WriteLine("Rows with incorrect elements:");

                    foreach (string line in invalidLines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}