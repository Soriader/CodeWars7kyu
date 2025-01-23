using CodeWars7kyu;

namespace CodeWarsTest;

public class AlternateCapitalization
{
    [Test]
    public void AlternateCapitalizationTest()
    {
        Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, AlternateCapitalizationTask.Capitalize("abcdef"));
        Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, AlternateCapitalizationTask.Capitalize("codewars"));
        Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, AlternateCapitalizationTask.Capitalize("abracadabra"));
        Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, AlternateCapitalizationTask.Capitalize("codewarriors"));
    }
}