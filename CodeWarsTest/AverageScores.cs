using CodeWars7kyu;

namespace CodeWarsTest;

public class AverageScores
{
    [Test]
    public void AverageScoresTest()
    {
        var scores = new int[] { 49, 3, 5, 300, 7 };
        Assert.AreEqual(73, AverageScoresTask.Average(scores));

        scores = new int[] { 90, 98, 89, 100, 100, 86, 94 };
        Assert.AreEqual(94, AverageScoresTask.Average(scores));
    }
}