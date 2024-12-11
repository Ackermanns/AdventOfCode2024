

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace AdventOfCode2024.Days
{
    public class Day3_1
    {
        private string[] input;
        private int total;

        private int num1;
        private int num2;
        private bool hasClosingBracket = false;

        public Day3_1(string[] input) {
            this.input = input;
        }

        private string GetSequenceTwoNum(string sequenceTwo)
        {
            string currentSequenceTwo = "";
            for (int i = 0; i != sequenceTwo.Length-1; i++)
            {
                if (int.TryParse(sequenceTwo[i].ToString(), out _) == true)
                {
                    currentSequenceTwo += sequenceTwo[i];
                }

                if (sequenceTwo[i + 1] == ')')
                {
                    hasClosingBracket = true;
                    return currentSequenceTwo;
                }
            }
            return "";
        }

        private bool ValidateInput(string sequence)
        {
            // Check for two sequences are separated by a comma
            string[] sequences = sequence.Split(',');
            if (sequences.Length != 2)
            {
                return false;
            }
            // Check if both numbers length is greater than 0
            if (sequences[0].Length == 0 || sequences[1].Length == 0) {
                return false;
            }
            string sequenceTwoProcessed = GetSequenceTwoNum(sequences[1]);
            // Check if sequence two has closing bracket
            if (hasClosingBracket == false)
            {
                return false;
            }
            // Check both numbers are type int
            if (int.TryParse(sequences[0], out _) == false || int.TryParse(sequenceTwoProcessed, out _) == false)
            {
                return false;
            }
            


            // All conditions met, can commit
            num1 = int.Parse(sequences[0]);
            num2 = int.Parse(sequenceTwoProcessed);
            return true;
        }

        public int MullItOver()
        {
            // Get all potential Mul's to validate from input
            List<string> potentialMuls = new List<string>();
            int value;
            int difference;

            // Validate all found Mul( for processing
            foreach (var line in this.input)
            {
                string[] toProcess = line.Split("mul(");
                foreach (var item in toProcess)
                {
                    if (item.Length <= 8)
                    {
                        //Console.WriteLine(item);
                        potentialMuls.Add(item);
                    }
                    else
                    {
                        //Console.WriteLine(item);
                        potentialMuls.Add(item.Substring(0,8));
                    }
                }
            }

           foreach (var item in potentialMuls)
            {
                bool isValid = ValidateInput(item);
                if (isValid == true)
                {
                    Console.WriteLine($"mul({num1},{num2})");
                    total = total + (num1 * num2);
                }
                hasClosingBracket = false;
            }

            return total;
        }
    }
}
