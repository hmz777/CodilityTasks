using CodilityTasks.Problems;
using UnitTests.AutoData;

namespace UnitTests
{
	public class MaxCountersTests
	{
		[Theory(Timeout = 6000)]
		[MaxCountersData]
		public void TestMaxCounters(int N, int[] A)
		{
			MaxCounters.Solution(N, A);
		}
	}
}
