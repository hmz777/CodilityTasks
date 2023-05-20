using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.AutoData
{
	public class FrogRiverOneData : AutoDataAttribute
	{
		public FrogRiverOneData() : base(() =>
		{
			var fixture = new Fixture();
			var rand = new Random();
			int XandN() => rand.Next(1, 100000);

			var X = XandN();
			fixture.Register(() => X);

			fixture.Register(() =>
			{
				var numbers = new List<int>();
				var boundry = XandN();

				for (int i = 1; i < boundry; i++)
				{
					numbers.Add(rand.Next(1, X));
				}

				return numbers.ToArray();
			});

			return fixture;
		})
		{ }
	}
}
