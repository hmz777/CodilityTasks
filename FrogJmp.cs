using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTasks
{
	public class FrogJmp
	{
		public static int Solution(int X, int Y, int D)
		{
			var distance = Y - X;
			var steps = distance / (double)D;

			var numberOfSteps = Math.Ceiling((double)steps);

			return (int)numberOfSteps;
		}
	}
}