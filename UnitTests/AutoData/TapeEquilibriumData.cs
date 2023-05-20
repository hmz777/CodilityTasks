using AutoFixture;
using AutoFixture.Xunit2;

namespace UnitTests.AutoData
{
	public class TapeEquilibriumDataAttribute : AutoDataAttribute
	{
		public TapeEquilibriumDataAttribute() : base(() =>
		{
			var fixture = new Fixture();

			fixture.Register(() =>
			{
				var numbers = new List<int>();
				var rand = new Random();
				var bound = rand.Next(2, 100000);

				for (int i = 0; i < bound; i++)
				{
					numbers.Add(rand.Next(-1000, 1000));
				}

				return numbers.ToArray();
			});

			return fixture;
		})
		{ }
	}
}
