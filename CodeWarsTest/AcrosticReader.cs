using CodeWars7kyu;

namespace CodeWarsTest;

public class AcrosticReader
{
    [Test]
    public void AcrosticReaderTest()
    {
        Assert.AreEqual("JACK", AcrosticReaderTask.ReadOut(new string[] { "Jolly", "Amazing", "Courteous", "Keen" }));
        Assert.AreEqual("MEG", AcrosticReaderTask.ReadOut(new string[] { "Marvelous", "Excellent", "Gifted" }));
    }
}