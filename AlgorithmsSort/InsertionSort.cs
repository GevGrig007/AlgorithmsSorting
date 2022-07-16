using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSort
{
    public class InsertionSort : MainAlgorithm
    {
        public InsertionSort(List<int> numbers) : base(numbers)
        {

        }
        public override List<int> MakeSort()
        {
            for (var i = 1; i < Numbers.Count; i++)
            {
                var temp = Numbers[i];
                var j = i;
                while ((j > 0) && (Numbers[j - 1] > temp))
                {
                    var a = Numbers[j - 1];
                    Numbers[j - 1] = Numbers[j];
                    Numbers[j] = a;
                    OperationCount++;
                    j--;
                }
                Numbers[j] = temp;
            }
            return Numbers;
        }
    }
}
