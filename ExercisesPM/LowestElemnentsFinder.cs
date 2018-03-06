using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesPM
{
    class LowestElemnentsFinder
    {
        public static void FindElements(List<int> myList, int x)
        {
            try
            {
                if (myList.Count == 0)
                {
                    throw new ArgumentException("Input list cannot be empty.");
                }
                if (x <= 0)
                {
                    throw new ArgumentException("x must be grather then 0.");
                }

                List<int> resultList = new List<int>();
                while (resultList.Count < x)
                {
                    resultList.Add(myList.Min());
                    myList.Remove(myList.Min());
                }

                foreach (int i in resultList)
                {
                    Console.WriteLine(i);
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
