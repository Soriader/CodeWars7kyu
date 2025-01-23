using CodeWars7kyu;

namespace CodeWarsTest;

public class SelectiveFearOfNumbers
{
    [Test]
    public static void TestFixed()
    {
        void Tester(string day, int num, bool expected)
        {
            bool submitted = SelectiveFearOfNumbersTask.AmIAfraid(day, num);
            string message = $"day = \"{day}\"\n  num = {num}";
            Assert.AreEqual(expected, submitted, message);
        }

        Tester("Monday", 13, false);
        Tester("Sunday", -666, true);
        Tester("Tuesday", 2, false);
        Tester("Tuesday", 965, true);
        Tester("Friday", 2, true);
    }
}