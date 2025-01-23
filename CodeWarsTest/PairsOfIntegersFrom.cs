using CodeWars7kyu;

namespace CodeWarsTest;

public class PairsOfIntegersFrom
{
    [Test]
    public void PairsOfIntegersFromTest()
    {
        Act(2, 4, new[] { (2, 2), (2, 3), (2, 4), (3, 3), (3, 4), (4, 4) });
        Act(0, 1, new[] { (0, 0), (0, 1), (1, 1) });
        Act(0, 0, new[] { (0, 0) });

        static void Act(int m, int n, (int, int)[] expected)
        {
            var msg = $"Invalid answer for m: {m}, n: {n}";
            var actual = PairsOfIntegersFromTask.GeneratePairs(m, n).ToArray();
            CollectionAssert.AreEqual(Format(expected), Format(actual), msg);
        }

        static string Format((int, int)[] xs) => string.Join(", ", xs);
    }
}