using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPM
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstXNubersFinder.FindFirstXNumbersGreaterOrEqualThanYDivByZAndNotDivByQ(6, 100, 3, 2);

            SumOfFirstXOddNumbers.Count(3, 20);

            var myList = new List<int>() { 4, 15, 7, 2, 9 };
            LowestElemnentsFinder.FindElements(myList, 3);

            Console.ReadKey();
        }
    }
}
