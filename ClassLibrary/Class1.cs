using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumLibrary
{
    public static class MaxSumFinder
    {
        public static int FindMaxSumLineIndex(List<string> lines)
        {
            int maxSumLineIndex = -1;
            double maxSum = double.MinValue;

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                string[] numbers = line.Split(',');

                double sum = 0;
                bool isValidLine = true;

                foreach (string number in numbers)
                {
                    if (double.TryParse(number, out double parsedNumber))
                    {
                        sum += parsedNumber;
                    }
                    else
                    {
                        isValidLine = false;
                        break;
                    }
                }

                if (isValidLine && sum > maxSum)
                {
                    maxSum = sum;
                    maxSumLineIndex = i;
                }
            }

            return maxSumLineIndex;
        }

        public static List<string> FindInvalidLines(List<string> lines)
        {
            List<string> invalidLines = new List<string>();

            foreach (string line in lines)
            {
                string[] numbers = line.Split(',');

                foreach (string number in numbers)
                {
                    if (!double.TryParse(number, out _))
                    {
                        invalidLines.Add(line);
                        break;
                    }
                }
            }

            return invalidLines;
        }
    }
}