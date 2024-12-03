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
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\day1-example.txt");
            Day1_1 day1 = new Day1_1(input);
            solution = day1.HistorianHysteria();
            Assert.AreEqual(11, solution);
        }

        [TestMethod]
        public void Test_Day1_2()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\day1-example.txt");
            Day1_2 day1 = new Day1_2(input);
            solution = day1.HistorianHysteria();
            Assert.AreEqual(31, solution);
        }

        [TestMethod]
        public void Test_Day2_1()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\day2-example.txt");
            Day2_1 day2 = new Day2_1(input);
            solution = day2.RedNosedReports();
            Assert.AreEqual(2, solution);
        }
    }
}
