using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTasks
{
	public class CyclicRotation
	{
		public static int[] Solution(int[] A, int K)
		{
			for (int j = 0; j < K; j++)
			{
				A = ShiftByOne(A);
			}

			return A;
		}

		private static int[] ShiftByOne(int[] A)
		{
			var shiftedArray = new int[A.Length];
			for (int i = 0; i < A.Length; i++)
			{
				var index = i + 1;

				if (index <= A.Length - 1)
				{
					shiftedArray[index] = A[i];
				}
				else
				{
					shiftedArray[0] = A[i];
				}
			}

			return shiftedArray;
		}
	}
}
