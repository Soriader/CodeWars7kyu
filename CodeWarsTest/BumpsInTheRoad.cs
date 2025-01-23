using CodeWars7kyu;

namespace CodeWarsTest;

public class BumpsInTheRoad
{
    [Test]
    public void BumpsInTheRoadTest()
    {
        Assert.AreEqual("Woohoo!", BumpsInTheRoadTask.Bump("n"));
        Assert.AreEqual("Woohoo!", BumpsInTheRoadTask.Bump("nnn_n__n_n___nnnnn___n__nnn__"));
        Assert.AreEqual("Car Dead", BumpsInTheRoadTask.Bump("_nnnnnnn_n__n______nn__nn_nnn"));
        Assert.AreEqual("Car Dead", BumpsInTheRoadTask.Bump("nnnn____nnnnnn___nnnnnnnn_____nnnnnnn"));

    }
}