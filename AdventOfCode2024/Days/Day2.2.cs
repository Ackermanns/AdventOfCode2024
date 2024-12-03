

using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode2024.Days
{
    public class Day2_2
    {
        private string[] input;

        private bool isAllIncreasing = true;
        private bool isAllDecreasing = true;
        private bool isValidReport = true;
        private bool rule1Result = true;
        private bool rule2Result = true;
        private bool dampenderUsed = false;
        
        private bool i;

        private int total;

        public Day2_2(string[] input) {
            this.input = input;
        }

        public int RedNosedReports()
        {
            foreach (string r in input)
            {
                List<string> report = r.Split(" ").ToList();

                for (int i = 0; i != report.Count - 1; i++)
                {
                    // Check for rule 1
                    rule1Result = CheckRule1(int.Parse(report[i]), int.Parse(report[i + 1]));

                    // Check for rule 2
                    rule2Result = CheckRule2(int.Parse(report[i]), int.Parse(report[i + 1]));

                    if (rule1Result == false || rule2Result == false)
                    {
                        if (dampenderUsed == false)
                        {
                            dampenderUsed = true;
                            report.RemoveAt(i+1);
                            i = 0;
                        }
                        else
                        {
                            isValidReport = false;
                            break;
                        }
                    }
                }
                if (isValidReport == true)
                {
                    total++;
                }

                // Reset for next
                isValidReport = true;
                isAllIncreasing = true;
                isAllDecreasing = true;
                dampenderUsed = false;
            }
            return total;
        }

        // Check if sequence is consistently increasing/decreasing
        private bool CheckRule1(int num1, int num2)
        {
            // Should only be triggered on first number
            if (isAllIncreasing == true && isAllDecreasing == true)
            {
                if (num1 < num2)
                {
                    isAllDecreasing = false;
                    return true;
                }
                else if (num1 > num2)
                {
                    isAllIncreasing = false;
                    return true;
                }
            }
            // Rest of sequence
            else if (isAllIncreasing == true && num1 < num2)
            {
                return true;
            }
            else if (isAllDecreasing == true && num1 > num2)
            {
                return true;
            }
            return false;
        }

        // Difference size between numbers
        private bool CheckRule2(int num1, int num2)
        {
            if (Math.Abs(num1 - num2) <= 3)
            {
                return true;
            }
            else if (Math.Abs(num1 - num2) <= 1)
            {
                return true;
            }
            return false;
        }
    }
}
