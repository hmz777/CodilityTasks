namespace CodilityTasks.Problems
{
	public class PermCheck
	{
		public static int Solution(int[] A)
		{
			Array.Sort(A);

			var index = 0;

			var firstElm = A[index];

			if (firstElm != 1) { return 0; }

			if (A.Length == 1 && firstElm == 1) { return 1; }

			while (index < A.Length - 1)
			{
				if (A[index] != A[index + 1] - 1) { return 0; }

				index++;
			}

			return 1;
		}
	}
}
