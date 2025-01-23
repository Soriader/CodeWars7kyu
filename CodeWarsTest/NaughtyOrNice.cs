using CodeWars7kyu;

namespace CodeWarsTest;

public class NaughtyOrNice
{
    [Test]
    public void NaughtyOrNiceTest()
    {
        var naughty = new List<NaughtyOrNiceTask> {
            new NaughtyOrNiceTask("Marco", false),
            new NaughtyOrNiceTask("Luc", false),
        };
        var nice = new List<NaughtyOrNiceTask> {
            new NaughtyOrNiceTask("Ryan", true),
            new NaughtyOrNiceTask("Barak", true),
        };

        var both = naughty.Concat(nice);

        Assert.AreEqual(0, NaughtyOrNiceTask.GetNiceNames(naughty).Count(), "Wrong number of nice names");
        Assert.AreEqual(0, NaughtyOrNiceTask.GetNaughtyNames(nice).Count(), "Wrong number of naughty names");
        Assert.AreEqual("Ryan,Barak", string.Join(",", NaughtyOrNiceTask.GetNiceNames(nice)));
        Assert.AreEqual("Marco,Luc", string.Join(",", NaughtyOrNiceTask.GetNaughtyNames(naughty)));
        Assert.AreEqual("Ryan,Barak", string.Join(",", NaughtyOrNiceTask.GetNiceNames(both)));
        Assert.AreEqual("Marco,Luc", string.Join(",", NaughtyOrNiceTask.GetNaughtyNames(both)));
    }
}