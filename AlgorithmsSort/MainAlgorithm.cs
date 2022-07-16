using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSort
{
    public class MainAlgorithm
    {
        public List<int> Numbers { get; set; }
        public int OperationCount { get; set; }
        public MainAlgorithm(List<int> numbers)
        {
            Numbers = numbers;
        }
        public MainAlgorithm() { }
        public  void Swap( ref int number1, ref int number2)
        {
            var temp = number1;
            number1 = number2;
            number2 = temp;
        }
        public virtual List<int> MakeSort()
        {
            return Numbers;
        }
    }
}
