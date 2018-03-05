using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPM
{
    class FirstXNubersFinder
    {

        public static void FindFirstXNumbersGreaterOrEqualThanYDivByZAndNotDivByQ(int x, int y, int z, int q)
        {

            try
            {
                if (x <= 0) throw new
                        ArgumentException("x must be greater then 0");

                List<int> result = new List<int>();

                while (result.Count() < x)
                {
                    if ((y % z == 0) && (y % q != 0))
                    {
                        result.Add(y);
                    }
                    y++;
                }

                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Arguments z and q must be greater then O");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("x must be greater then 0");
            }

        }

    }
}
