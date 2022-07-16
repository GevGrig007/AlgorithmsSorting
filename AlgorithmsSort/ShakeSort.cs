using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSort
{
    public class ShakeSort : MainAlgorithm
    {
        public ShakeSort(List<int> numbers) : base(numbers)
        {
        }
        public override List<int> MakeSort()
        {
            for (var i = 0; i < Numbers.Count / 2; i++)
            {
                var swapCount = false;
                // moving from left to right
                for (var j = i; j < Numbers.Count - i - 1; j++)
                {
                    if (Numbers[j] > Numbers[j + 1])
                    {
                        var temp = Numbers[j];
                        Numbers[j] = Numbers[j + 1];
                        Numbers[j + 1] = temp;
                        OperationCount++;
                        swapCount = true;
                    }
                }
                //moving from right to left
                for (var j = Numbers.Count - 2 - i; j > i; j--)
                {
                    if (Numbers[j - 1] > Numbers[j])
                    {
                        var temp = Numbers[j - 1];
                        Numbers[j - 1] = Numbers[j];
                        Numbers[j] = temp;
                        OperationCount++;
                        swapCount = true;
                    }
                }
                if (!swapCount)
                {
                    break;
                }
            }
            return Numbers;
        }
    }
}
