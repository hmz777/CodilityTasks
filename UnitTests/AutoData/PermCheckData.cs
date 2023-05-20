using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.AutoData
{
	public class PermCheckData : AutoDataAttribute
	{
		public PermCheckData() : base(() =>
		{
			var fixture = new Fixture();

			var rand = new Random();
			var N = rand.Next(1, 100000);

			fixture.Register(() =>
			{
				var numbers = new List<int>();

				for (int i = 0; i < N; i++)
				{
					numbers.Add(rand.Next(1, 1000000000));
				}

				return numbers.ToArray();
			});

			return fixture;
		})
		{ }
	}
}
