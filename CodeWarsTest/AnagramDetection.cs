using CodeWars7kyu;

namespace CodeWarsTest;

public class AnagramDetection
{
    [Test]
    public void AnagramDetectionTest()
    {
        Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("foefet", "toffee"));
        Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("Buckethead", "DeathCubeK"));
        Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("Twoo", "Woot"));
        Assert.AreEqual(false, AnagramDetectionTask.IsAnagram("apple", "pale"));

    }
}