using MyQuery.Logic;
using System;

namespace MyQuery.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new int[] { 1, 2, 3 };
            var doubleList = intList.Map(i => Convert.ToDouble(i));


        }
    }
}
