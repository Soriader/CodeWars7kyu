using CodeWars7kyu;

namespace CodeWarsTest;

public class CountSalutes
{
    [Test]
    public void CountSalutesTest()
    {
        static void Act(string hallway, int expected)
        {
            var actual = CountSalutesTask.CountSalutes(hallway);
            Console.WriteLine($"input: {hallway} expected: {expected} actual: {actual}");
            Assert.AreEqual(expected, actual, $"Input:  {hallway}");
        }

        Act("<---->---<---<-->", 4);
        Act("------", 0);
        Act(">>>>>>>>>>>>>>>>>>>>>----<->", 42);
        Act("<<----<>---<", 2);
        Act(">", 0);
    }
}