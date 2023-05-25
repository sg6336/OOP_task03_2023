using System.Collections.Generic;
using MaxSumLibrary;
using NUnit.Framework;

namespace MaxSumTests
{
    public class MaxSumFinderTests
    {
        [Test]
        public void FindMaxSumLineIndex_ReturnsCorrectIndex()
        {
            List<string> lines = new List<string>
            {
                "1, 2, 3, 4",
                "5, 6, 7",
                "8, 9",
                "10",
                "11, 12, 13, 14, 15"
            };

            int maxSumLineIndex = MaxSumFinder.FindMaxSumLineIndex(lines);

            Assert.AreEqual(4, maxSumLineIndex);
        }

        [Test]
        public void FindMaxSumLineIndex_ReturnsMinusOneForEmptyLines()
        {
            List<string> lines = new List<string>();

            int maxSumLineIndex = MaxSumFinder.FindMaxSumLineIndex(lines);

            Assert.AreEqual(-1, maxSumLineIndex);
        }

        [Test]
        public void FindInvalidLines_ReturnsInvalidLines()
        {
            List<string> lines = new List<string>
            {
                "1, 2, 3, 4",
                "5, 6, 7",
                "8, 9",
                "10",
                "a, b, c",
                "x, y, z"
            };

            List<string> invalidLines = MaxSumFinder.FindInvalidLines(lines);

            Assert.AreEqual(2, invalidLines.Count);
            Assert.Contains("a, b, c", invalidLines);
            Assert.Contains("x, y, z", invalidLines);
        }

        [Test]
        public void FindInvalidLines_ReturnsEmptyListForValidLines()
        {
            List<string> lines = new List<string>
            {
                "1, 2, 3, 4",
                "5, 6, 7",
                "8, 9",
                "10"
            };

            List<string> invalidLines = MaxSumFinder.FindInvalidLines(lines);

            Assert.IsEmpty(invalidLines);
        }
    }
}