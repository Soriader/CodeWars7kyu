using CodeWars7kyu;

namespace CodeWarsTest;

public class SpotTheDifferences
{
    [Test]
    public void SpotTheDifferencesTest()
    {
        Assert.AreEqual(new List<int> { 3, 5 }, SpotTheDifferencesTask.Spot("abcdefg", "abcqetg"));
        Assert.AreEqual(new List<int> { 0, 6, 11 }, SpotTheDifferencesTask.Spot("Hello World!", "hello world."));
        Assert.AreEqual(new List<int>(), SpotTheDifferencesTask.Spot("FixedGrey", "FixedGrey"));

    }
}