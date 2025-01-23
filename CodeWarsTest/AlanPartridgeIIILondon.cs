using CodeWars7kyu;

namespace CodeWarsTest;

public class AlanPartridgeIIILondon
{
    [Test]
    public void AlanPartridgeIIILondonTest()
    {
        Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIIILondonTask.Alan(new string[] { "Norwich", "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway", "London" }));
        Assert.AreEqual("No, seriously, run. You will miss it.", AlanPartridgeIIILondonTask.Alan(new string[] { "London", "Norwich" }));
        Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIIILondonTask.Alan(new string[] { "Norwich", "Tooting", "Bank", "Rejection", "Disappointment", "Backstabbing Central", "Exeter", "Shattered Dreams Parkway", "Belgium", "London" }));
    }
}