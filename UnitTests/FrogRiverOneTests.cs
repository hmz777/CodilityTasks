using CodilityTasks.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.AutoData;

namespace UnitTests
{
	public class FrogRiverOneTests
	{
		[Theory(Timeout = 6000)]
		[FrogRiverOneData]
		public void TestFrogJump(int X, int[] A)
		{
			FrogRiverOne.Solution(X, A);
		}
	}
}