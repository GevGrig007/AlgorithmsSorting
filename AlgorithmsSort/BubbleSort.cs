using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSort
{
    public class BubbleSort : MainAlgorithm
    {
        public  BubbleSort(List<int> numbers) : base(numbers)
        {
        }
        public BubbleSort() { }
        public override List<int> MakeSort()
        {
            var count = Numbers.Count;
            for (var i = 1; i < count; i++)
            {
                for (var j = 0; j < count - i; j++)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        var temp = Numbers[j];
                        Numbers[j] = Numbers[j + 1];
                        Numbers[j + 1] = temp;
                        OperationCount++;
                    }
                }
            }
            return Numbers;
        }
        
    }
}
