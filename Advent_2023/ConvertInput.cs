using System.Diagnostics;

namespace Advent_2023
{
    public class ConvertInput
    {
        public static string[] InputValuesFile = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"Files\Advent_Day1_Input.txt"));

        public static Dictionary<string, int> Zero_Nine = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7},
                { "eight", 8 },
                { "nine", 9 }
            };

        public static List<string> ReplaceWordNumberCalibration(bool debug = false)
        {
            var newStrings = new List<string>();
            foreach (var value in InputValuesFile) // original input value
            {
                var newString = value;
                foreach (var word in Zero_Nine) // loop over dict values
                {
                    var numbers = newString;
                    if (numbers.Contains(word.Key)){
                        newString = numbers.Replace(word.Key, word.Key + word.Value + word.Key);
                    }
                }

                newStrings.Add(newString);

                if (debug)
                {
                    Console.WriteLine($"Input replaced: {value} WITH {newString}");
                }
            }
            return newStrings;
        }

        /// <summary>
        /// Return sum of all first and last digits in string.
        /// </summary>
        /// <returns>Returns int sum.</returns>
        public static int ReturnAllDigitsSum()
        {
            // Replace words w nums first
            var replaced = ReplaceWordNumberCalibration();

            var numbersInCalibration = new List<int>();

            foreach (var value in replaced)
            {
                var digits = string.Empty;
                for (var i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        digits += value[i];
                    }
                }

                // Get first and last digits in string
                if (digits.Length == 1)
                {
                    digits += digits;
                }
                else
                {
                    var first = digits.First();
                    var last = digits.Last();
                    digits = string.Empty;
                    digits += first;
                    digits += last;
                }

                numbersInCalibration.Add(int.Parse(digits));
                // Console.WriteLine($"Digits {digits} was found in {value}");
            }

            return numbersInCalibration.Sum();
        }
    }
}