namespace CodeWarsTest;

using CodeWars7kyu;

public class FastCookingPancakes
{
    static void Act(int expected, int n, int m)
        => Assert.That(FastCookingPancakesTask.CookPancakes(n, m), Is.EqualTo(expected), $"Input -> n = {n}, m = {m}");
    
    [TestCase(2, 1, 2)]
    [TestCase(2, 2, 2)]
    [TestCase(3, 3, 2)]
    [TestCase(4, 4, 2)]
    [TestCase(3, 4, 3)]
    [TestCase(2, 4, 4)]
    [TestCase(2, 1, 4)]
    [TestCase(2, 2, 3)]
    [TestCase(3, 5, 4)]
    [TestCase(4, 6, 3)]
    [TestCase(3, 6, 5)]
    [TestCase(6, 3, 1)]
    public void FixedTests(int expected, int n, int m) => Act(expected, n, m);
}
