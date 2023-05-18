namespace CodilityTasks
{
	public class OddOccurrencesInArray
	{
		public static int Solution(int[] A)
		{
			var unPairedNumber = 0;

			Array.Sort(A);

			for (int i = 0; i < A.Length; i++)
			{
				var number = A[i];

				if (i + 1 == A.Length)
				{
					unPairedNumber = number;
					break;
				}

				if (number == 0)
					continue;

				if (number == A[i + 1])
				{
					A[i] = 0;
					A[i + 1] = 0;
					continue;
				}
				else
				{
					unPairedNumber = number;
					break;
				}
			}

			return unPairedNumber;
		}
	}
}