

using AdventOfCode2024.Days;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode2024
{
    public class Controller
    {
        private string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        private string[] input;
        private int solution;
        static Stopwatch timer = new Stopwatch();

        public void Main()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent?.FullName;
            Console.WriteLine($"{projectPath}");
            RunDay1_1();
        }

        // Loads data from input files, should always be value for AoC
        public string[]? LoadData(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch
            {
                Console.WriteLine("There was an issue getting data from Input file");
            }
            return null;
        }

        private void RunDay1_1()
        {
            input = LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day 1\\day1-1.txt");
            timer.Start();
            Day1_1 day1 = new Day1_1(input);
            solution = day1.HistorianHysteria();
            timer.Stop();
            Console.WriteLine($"[{timer.Elapsed}] Day 1-1 Solution: {solution}");
            timer.Restart();
        }
    }
}
