using AutoFixture;
using AutoFixture.Kernel;
using AutoFixture.Xunit2;
using System.Reflection;

namespace UnitTests.AutoData
{
	public class MaxCountersData : AutoDataAttribute
	{
		public MaxCountersData() : base(() =>
		{
			var fixture = new Fixture();

			var rand = new Random();
			var N = rand.Next(1, 100000);

			fixture.Register(() =>
			{
				return N;
			});

			fixture.Register(() =>
			{
				var numbers = new List<int>();
				var M = rand.Next(1, 100000);

				for (int i = 0; i < M; i++)
				{
					numbers.Add(rand.Next(1, N + 1));
				}

				// To make sure we hit the X = N + 1 case to better asses the performance
				//for (int i = 0; i < M; i++)
				//{
				//	numbers.Add(N + 1);
				//}

				return numbers.ToArray();
			});

			return fixture;
		})
		{ }
	}
}
