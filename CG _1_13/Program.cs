using System;
using System.Linq;
using System.Collections.Generic;
using NumberUtility;

namespace CG__1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(10);
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(8);
            nums.Add(2);
            nums.Add(14);
            nums.Add(3);
            nums.Add(4);
            nums.Add(22);

            Console.WriteLine(NumberCruncher.SumOfEvens(nums));

            Console.ReadLine();
        }
    }
}
