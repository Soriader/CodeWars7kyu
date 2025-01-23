using CodeWars7kyu;

namespace CodeWarsTest;

public class RegexpBasicsIsItAVowel
{
    [Test]
    public void RegexpBasicsIsItAVowelTest()
    {
        Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel(""));
        Assert.AreEqual(true, RegexpBasicsIsItAVowelTask.Vowel("a"));
        Assert.AreEqual(true, RegexpBasicsIsItAVowelTask.Vowel("E"));
        Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel("ou"));
        Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel("z"));
        Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel("lol"));

    }
}