using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
	/*
	Multiples of 3 and 5
	Problem 1
	If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

	Find the sum of all the multiples of 3 or 5 below 1000.
	 */

	class Problem1
	{
		private static int SumOfMultiples(int from, int toNotIncluded, int[] factors)
		{
			var sum = 0;
			for (var i = from; i < toNotIncluded; i++)
				for (var j = 0; j < factors.Length; j++)
				{
					if (i % factors[j] == 0)
					{
						sum += i;
						break;
					}
				}

			return sum;
		}

		public static void Run()
		{
			Console.WriteLine(
					string.Format("Problem1: {0}", 
						SumOfMultiples(1, 1000, new int[] { 3, 5 })
					)
				);
		}
	}
}
