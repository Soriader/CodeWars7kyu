using CodeWars7kyu;

namespace CodeWarsTest;

public class ToTime
{
    [Test]
    public void ToTimeTest()
    {
        Act(3600, "1 hour(s) and 0 minute(s)");
        Act(3601, "1 hour(s) and 0 minute(s)");
        Act(3500, "0 hour(s) and 58 minute(s)");
        Act(323500, "89 hour(s) and 51 minute(s)");
        Act(0, "0 hour(s) and 0 minute(s)");

        static void Act(int seconds, string expected)
        {
            var actual = ToTimeTask.ToTime(seconds);
            Console.WriteLine($"   Input: seconds = {seconds}\nExpected: {expected}\n  Actual: {actual}\n");
            Assert.AreEqual(expected, actual, $"Input: seconds = {seconds}");
        }
    }
}