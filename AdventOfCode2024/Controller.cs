

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
            //RunDay1_1();
            //RunDay1_2();
            //RunDay2_1();
            //RunDay2_2();
            RunDay3_1();
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
            input = LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day1-1.txt");
            timer.Start();
            Day1_1 day = new Day1_1(input);
            solution = day.HistorianHysteria();
            timer.Stop();
            Console.WriteLine($"[{timer.Elapsed}] Day 1-1 Solution: {solution}");
            timer.Restart();
        }

        private void RunDay1_2()
        {
            input = LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day1-1.txt");
            timer.Start();
            Day1_2 day = new Day1_2(input);
            solution = day.HistorianHysteria();
            timer.Stop();
            Console.WriteLine($"[{timer.Elapsed}] Day 1-2 Solution: {solution}");
            timer.Restart();
        }

        private void RunDay2_1()
        {
            input = LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day2-1.txt");
            timer.Start();
            Day2_1 day = new Day2_1(input);
            solution = day.RedNosedReports();
            timer.Stop();
            Console.WriteLine($"[{timer.Elapsed}] Day 2-1 Solution: {solution}");
            timer.Restart();
        }

        private void RunDay2_2()
        {
            input = LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day2-1.txt");
            timer.Start();
            Day2_2 day = new Day2_2(input);
            solution = day.RedNosedReports();
            timer.Stop();
            Console.WriteLine($"[{timer.Elapsed}] Day 2-2 Solution: {solution}");
            timer.Restart();
        }

        private void RunDay3_1()
        {
            input = LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day3-1.txt");
            timer.Start();
            Day3_1 day = new Day3_1(input);
            solution = day.MullItOver();
            timer.Stop();
            Console.WriteLine($"[{timer.Elapsed}] Day 3-1 Solution: {solution}");
            timer.Restart();
        }
    }
}
