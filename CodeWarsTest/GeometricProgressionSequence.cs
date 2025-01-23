using CodeWars7kyu;

namespace CodeWarsTest;

public class GeometricProgressionSequence
{
    [Test]
    public void GeometricProgressionSequenceTest()
    {
        Assert.AreEqual("2, 6, 18, 54, 162", GeometricProgressionSequenceTask.GeometricSequenceElements(2, 3, 5));
        Assert.AreEqual("2, 4, 8, 16, 32, 64, 128, 256, 512, 1024", GeometricProgressionSequenceTask.GeometricSequenceElements(2, 2, 10));
        Assert.AreEqual("1, -2, 4, -8, 16, -32, 64, -128, 256, -512", GeometricProgressionSequenceTask.GeometricSequenceElements(1, -2, 10));
    }
}