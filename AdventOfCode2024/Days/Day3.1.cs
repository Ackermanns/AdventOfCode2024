

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

        private string sequence1;
        private string sequence2;

        public Day3_1(string[] input) {
            this.input = input;
        }

        private string ValidateSequence(string sequence)
        {
            string seq = "";
            if (sequence.Contains(" ")) {
                return "Bad";
            }
            for (int i = 0; i != sequence.Length; i++)
            {
                if (int.TryParse(sequence[i].ToString(), out _) == true)
                {
                    seq += sequence[i];
                }
                else
                {
                    return "Bad";
                }
            }
            return seq;
        }

        private bool ValidateInput(string sequence)
        {
            // get two sequence blocks for further processing
            string[] sequences = sequence.Split(',');
            if (sequences.Length < 2)
            {
                return false;
            }
            // Confirm closing bracket
            if (sequences[1].Contains(')') == false) 
            { 
                return false;
            }
            sequence1 = sequences[0];
            sequence2 = sequences[1].Split(')')[0];
            // Length check
            if (sequence1.Length == 0 || sequence2.Length == 0)
            {
                return false;
            }
            sequence1 = ValidateSequence(sequence1);
            sequence2 = ValidateSequence(sequence2);
            // Check both numbers are type int
            if (int.TryParse(sequence1, out num1) == false || int.TryParse(sequence2, out num2) == false)
            {
                return false;
            }
            return true;
        }

        public int MullItOver()
        {
            // Get all potential Mul's to validate from input
            List<string> potentialMuls = new List<string>();
            int value;
            int difference;

            // find all 'mul(' from input as potential values
            foreach (var line in this.input)
            {
                string[] toProcess = line.Split("mul(");
                foreach (var item in toProcess)
                {
                    potentialMuls.Add(item);
                }
            }

            // Process all 'mul(' found 
           foreach (var item in potentialMuls)
            {
                bool isValid = ValidateInput(item);
                if (isValid == true)
                {
                    total = total + (num1 * num2);
                }
            }
            return total;
        }
    }
}
