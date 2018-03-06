using System;

namespace ExercisesPM
{
    class SumOfFirstXOddNumbers
    {

        public static void Count(int x, int start = 0)
        {
            try
            {
                if (x <= 0)
                {
                    throw new ArgumentException("x must be greater then 0");
                }
                int result = 0;
                int i = x;
                while (i != 0)
                {
                    if (start % 2 != 0)
                    {
                        result = result + start;
                        i--;
                    }
                    start++;

                }
                Console.WriteLine("Sum of the first {0} odd numbers start form {1} is {2} ", x, start, result);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex);
            }

        }

    }
}
