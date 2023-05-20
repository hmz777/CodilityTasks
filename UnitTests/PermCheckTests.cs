using CodilityTasks.Problems;
using UnitTests.AutoData;

namespace UnitTests
{
	public class PermCheckTests
	{
		[Theory(Timeout = 6000)]
		[PermCheckData]
		public void TestPermCheck(int[] A)
		{
			PermCheck.Solution(A);
		}
	}
}
