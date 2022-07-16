using AlgorithmsSort;
using System;
using System.Collections.Generic;

namespace AlgorithmProgramm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<int>();
            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = Convert.ToInt32(parts[i]);
            }
        }
        
    }
}
