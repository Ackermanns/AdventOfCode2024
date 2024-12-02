

using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode2024.Days
{
    public class Day1_2
    {
        private string[] input;
        private List<int> list1 = new List<int>();
        private List<int> list2 = new List<int>();
        private int total;

        public Day1_2(string[] input) {
            this.input = input;
        }

        public int HistorianHysteria()
        {
            int value;
            int difference;

            foreach (var item in this.input)
            {
                var toProcess = item.Split("   ");
                
                value = int.Parse(toProcess[0]);
                list1.Add(value);

                value = int.Parse(toProcess[1]);
                list2.Add(value);
            }

            list1.Sort();
            list2.Sort();

            for (int i = 0; i != list1.Count; i++)
            {
                difference = list1[i] - list2[i];
                total += Math.Abs(difference);
            }

            return total;
        }
    }
}
