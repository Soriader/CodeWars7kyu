using CodeWars7kyu;

namespace CodeWarsTest;

public class NumbersToLetters
{
    [Test]
    public void NumbersToLettersTest()
    {
        string expected1 = "codewars";

        string actual1 = NumbersToLettersTask.Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" });

        Assert.AreEqual(expected1, actual1);

        string expected2 = "btswmdsbd kkw";

        string actual2 = NumbersToLettersTask.Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" });

        Assert.AreEqual(expected2, actual2);

        string expected3 = "wc";

        string actual3 = NumbersToLettersTask.Switcher(new string[] { "4", "24" });

        Assert.AreEqual(expected3, actual3);
    }
}