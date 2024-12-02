

using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode2024.Days
{
    public class Day1_2
    {
        private string[] input;
        private List<int> list1 = new List<int>();
        private List<int> list2 = new List<int>();
        private int total;

        Dictionary<string, int> list2NumInstances = new Dictionary<string, int> { };

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
                if (list2NumInstances.ContainsKey(toProcess[1]))
                {
                    list2NumInstances[toProcess[1]] = list2NumInstances[toProcess[1]] + 1;
                }
                else
                {
                    list2NumInstances[toProcess[1]] = 1;
                }
            }

            for (int i = 0; i != list1.Count; i++)
            {
                value = list1[i];
                if (list2NumInstances.ContainsKey(value.ToString()))
                {
                    total += list1[i] * list2NumInstances[list1[i].ToString()];
                }
            }

            return total;
        }
    }
}
