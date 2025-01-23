using CodeWars7kyu;

namespace CodeWarsTest;

public class Switcheroo
{
    [Test]
    public void SwitcherooTest()
    {
        Assert.AreEqual("bac", SwitcherooTask.Switcheroo("abc"));
        Assert.AreEqual("bbbacccabbb", SwitcherooTask.Switcheroo("aaabcccbaaa"));
        Assert.AreEqual("ccccc", SwitcherooTask.Switcheroo("ccccc"));
    }
}