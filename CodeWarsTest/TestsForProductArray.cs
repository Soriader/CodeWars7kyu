using CodeWars7kyu;

namespace CodeWarsTest
{
	[TestFixture]
	class TestsForProductArrayTask
	{
		[TestCase("12 20", "20 12")]
		[TestCase("3 27 4 2", "216 24 162 324")]
		[TestCase("13 10 5 2 9", "900 1170 2340 5850 1300")]
		[TestCase("16 17 4 3 5 2", "2040 1920 8160 10880 6528 16320")]
		public void BasicTest(string s, string str)
		{
			Assert.That(ProductArrayTask.ProductArray(Foo(s)), Is.EqualTo(Foo(str)));
		}
		int[] Foo(string s) => s.Split().Select(int.Parse).ToArray();
		[Test]
		public void RandomTests()
		{
			for (int i = 0; i < 40; i++)
			{
				var array = CreateArray();
				var expected = ProductArraySolution(array);
				Assert.That(ProductArrayTask.ProductArray(array), Is.EqualTo(expected));
			}
		}

		int[] CreateArray()
		{
			var rnd = new Random();
			var length = rnd.Next(3, 8);
			var list = new List<int>();
			for (int i = 0; i < length; i++)
				list.Add(rnd.Next(1, 15));
			return list.ToArray();
		}
		int[] ProductArraySolution(int[] array) => array.Select(x => array.Aggregate((a, b) => a * b) / x).ToArray();
	}
}