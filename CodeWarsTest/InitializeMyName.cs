using CodeWars7kyu;

namespace CodeWarsTest;

public class InitializeMyName
{
    [Test]
    public void InitializeMyNameTest()
    {
        Assert.AreEqual("Jack Ryan", InitializeMyNameTask.InitializeNames("Jack Ryan"));
        Assert.AreEqual("Lois M. Lane", InitializeMyNameTask.InitializeNames("Lois Mary Lane"));
        Assert.AreEqual("Dimitri", InitializeMyNameTask.InitializeNames("Dimitri"));
        Assert.AreEqual("Alice B. C. Davis", InitializeMyNameTask.InitializeNames("Alice Betty Catherine Davis"));
    }
}