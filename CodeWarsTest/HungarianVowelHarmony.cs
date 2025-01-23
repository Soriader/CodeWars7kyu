using CodeWars7kyu;

namespace CodeWarsTest;

public class HungarianVowelHarmony
{
    [Test]
    public void HungarianVowelHarmonyTest()
    {
        Assert.AreEqual("ablaknak", HungarianVowelHarmonyTask.Dative("ablak"));
        Assert.AreEqual("tükörnek", HungarianVowelHarmonyTask.Dative("tükör"));
        Assert.AreEqual("keretnek", HungarianVowelHarmonyTask.Dative("keret"));
        Assert.AreEqual("otthonnak", HungarianVowelHarmonyTask.Dative("otthon"));
        Assert.AreEqual("virágnak", HungarianVowelHarmonyTask.Dative("virág"));
        Assert.AreEqual("tettnek", HungarianVowelHarmonyTask.Dative("tett"));
        Assert.AreEqual("rokkantnak", HungarianVowelHarmonyTask.Dative("rokkant"));
        Assert.AreEqual("rossznak", HungarianVowelHarmonyTask.Dative("rossz"));
        Assert.AreEqual("gonosznak", HungarianVowelHarmonyTask.Dative("gonosz"));
    }
}