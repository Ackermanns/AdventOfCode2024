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
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day1-example.txt");
            Day1_1 day = new Day1_1(input);
            solution = day.HistorianHysteria();
            Assert.AreEqual(11, solution);
        }

        [TestMethod]
        public void Test_Day1_2()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day1-example.txt");
            Day1_2 day = new Day1_2(input);
            solution = day.HistorianHysteria();
            Assert.AreEqual(31, solution);
        }

        [TestMethod]
        public void Test_Day2_1()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day2-example.txt");
            Day2_1 day = new Day2_1(input);
            solution = day.RedNosedReports();
            Assert.AreEqual(2, solution);
        }

        [TestMethod]
        public void Test_Day2_2()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day2-example.txt");
            Day2_2 day = new Day2_2(input);
            solution = day.RedNosedReports();
            Assert.AreEqual(4, solution);
        }

        [TestMethod]
        public void Test_Day3_1()
        {
            input = c.LoadData($"{projectPath}\\AdventOfCode2024\\Input\\Day3-example.txt");
            Day3_1 day = new Day3_1(input);
            solution = day.MullItOver();
            Assert.AreEqual(161, solution);
        }
    }
}
