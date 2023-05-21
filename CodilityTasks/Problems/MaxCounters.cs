namespace CodilityTasks.Problems
{
	public class MaxCounters
	{
		public static int[] Solution(int N, int[] A)
		{
			var counters = new int[N];
			var max = 0;
			var gMax = 0;

			for (int i = 0; i < A.Length; i++)
			{
				var number = A[i];

				if (number > N)
				{
					gMax = max;
				}
				else
				{
					if (counters[number - 1] < gMax)
					{
						counters[number - 1] = gMax;
					}

					counters[number - 1] += 1;

					if (counters[number - 1] > max)
					{
						max = counters[number - 1];
					}
				}
			}

			for (int i = 0; i < counters.Length; i++)
			{
				if (counters[i] < gMax)
				{
					counters[i] = gMax;
				}
			}

			return counters;
		}
	}
}