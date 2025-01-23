using CodeWars7kyu;

namespace CodeWarsTest;

public class PartridgeWatch
{
    [Test]
    public void PartridgeWatchTest()
    {
        Assert.AreEqual("Mine's a Pint!", PartridgeWatchTask.Part(new string[] { "Grouse", "Partridge", "Pheasant" }));
        Assert.AreEqual("Mine's a Pint!!!!!!!!", PartridgeWatchTask.Part(new string[] { "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster" }));
        Assert.AreEqual("Lynn, I've pierced my foot on a spike!!", PartridgeWatchTask.Part(new string[] { "Pheasant", "Goose", "Starling", "Robin" }));
    }
}