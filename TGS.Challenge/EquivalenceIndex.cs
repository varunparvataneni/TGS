using System;
namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            try
            {
                int right_sum = 0,
                     left_sum = 0;

                // Computing right_sum
                for (int i = 1; i < numbers.Length; i++)
                    right_sum += numbers[i];

                // Checking the point
                // of partition i.e.
                // left_Sum == right_sum
                for (int i = 0, j = 1; j < numbers.Length; i++, j++)
                {
                    right_sum -= numbers[j];
                    left_sum += numbers[i];

                    if (left_sum == right_sum)
                        return i + 1;
                }

                return -1;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
      }
    }
}
