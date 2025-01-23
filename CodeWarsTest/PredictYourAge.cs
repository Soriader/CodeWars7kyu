using CodeWars7kyu;

namespace CodeWarsTest;

public class PredictYourAge
{
    [Test]
    public void PredictYourAgeTest()
    {
        Assert.AreEqual(86, PredictYourAgeTask.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
        Assert.AreEqual(79, PredictYourAgeTask.PredictAge(32, 54, 76, 65, 34, 63, 64, 45));
    }
}