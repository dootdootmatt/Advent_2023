using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent_2023;
using System;

namespace Advent_2023_Tests
{
    [TestClass()]
    public class ConvertInputTests
    {
        [TestMethod]
        public void ExtractInputWordNumberCalibrationTest()
        {
            ConvertInput.ReplaceWordNumberCalibration(true);
        }

        [TestMethod]
        public void ReturnAllDigitsTest()
        {
            Console.WriteLine(ConvertInput.ReturnAllDigitsSum());
        }
    }
}