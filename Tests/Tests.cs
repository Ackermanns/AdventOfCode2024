using AdventOfCode2024.Days;

namespace AdventOfCode2024.Tests
{
    [TestClass]
    public class Tests
    {
        private string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
        private string[] input;
        private int solution;
        Controller c = new Controller();

        [TestMethod]
        public void Test_Day1_1()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day 1\\day1-example.txt");
            Day1_1 day1 = new Day1_1(input);
            solution = day1.HistorianHysteria();
            Assert.AreEqual(11, solution);
        }
    }
}
