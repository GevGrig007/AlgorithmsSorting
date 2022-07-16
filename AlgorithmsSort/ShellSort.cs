using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSort
{
    public class ShellSort : MainAlgorithm
    {
        public ShellSort(List<int> numbers) : base(numbers)
        {
        }
        public override List<int> MakeSort()
        {
            var d = Numbers.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < Numbers.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (Numbers[j - d] > Numbers[j]))
                    {
                        var temp = Numbers[j];
                        Numbers[j] = Numbers[j - d];
                        Numbers[j - d] = temp;
                        OperationCount++;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return Numbers;
        }
    }
}
