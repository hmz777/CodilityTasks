using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTasks
{
	public class PermMissingElem
	{
		public static int Solution(int[] A)
		{
			var lookupNumber = 1;

			Array.Sort(A);

			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == lookupNumber)
				{
					lookupNumber++;
				}
				else
				{
					break;
				}
			}

			return lookupNumber;
		}
	}
}
