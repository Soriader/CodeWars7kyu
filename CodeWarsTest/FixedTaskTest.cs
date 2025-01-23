using CodeWars7kyu;

namespace CodeWarsTest;

public class FixedTaskTest
{
    [Test]
    public static void FixedTest()
    {
        InvalidInputErrorHandlingTask re = InvalidInputErrorHandlingTask.GetCount("Test");
        Assert.AreEqual(1, re.Vowels);
        Assert.AreEqual(3, re.Consonants);

        re = InvalidInputErrorHandlingTask.GetCount("Here is some text!");
        Assert.AreEqual(6, re.Vowels);
        Assert.AreEqual(8, re.Consonants);

        re = InvalidInputErrorHandlingTask.GetCount("To be a Codewarrior or not to be");
        Assert.AreEqual(12, re.Vowels);
        Assert.AreEqual(13, re.Consonants);

        re = InvalidInputErrorHandlingTask.GetCount("To Kata or not to Kata");
        Assert.AreEqual(8, re.Vowels);
        Assert.AreEqual(9, re.Consonants);

        re = InvalidInputErrorHandlingTask.GetCount("aeiou");
        Assert.AreEqual(5, re.Vowels);
        Assert.AreEqual(0, re.Consonants);
    }
}