using CodilityTasks.Problems;
using System.Diagnostics;
using UnitTests.AutoData;

namespace UnitTests
{
    public class TapeEquilibriumTests
	{
		[Theory(Timeout = 7500)]
		[TapeEquilibriumData]
		public void TestTapeEquilibrium(int[] a)
		{
			TapeEquilibrium.Solution2(a);
		}
	}
}