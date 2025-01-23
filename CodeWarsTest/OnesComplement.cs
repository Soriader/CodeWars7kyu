using CodeWars7kyu;

namespace CodeWarsTest;

public class OnesComplement
{
    [Test]
    public void OnesComplementTest()
    {
        Assert.AreEqual("1", OnesComplementTask.OnesComplement("0"));
        Assert.AreEqual("0", OnesComplementTask.OnesComplement("1"));
        Assert.AreEqual("01", OnesComplementTask.OnesComplement("10"));
        Assert.AreEqual("10", OnesComplementTask.OnesComplement("01"));
        Assert.AreEqual("0010", OnesComplementTask.OnesComplement("1101"));
    }
}