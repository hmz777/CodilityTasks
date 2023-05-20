using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTasks.Problems
{
	public class FrogRiverOne
	{
		public static int Solution(int X, int[] A)
		{
			var allSteps = new HashSet<int>();

			for (int i = 1; i <= X; i++)
			{
				allSteps.Add(i);
			}

			for (int i = 0; i < A.Length; i++)
			{
				var step = A[i];

				allSteps.Remove(step);

				if (allSteps.Count == 0)
				{
					return i;
				}
			}

			return -1;
		}
	}
}
