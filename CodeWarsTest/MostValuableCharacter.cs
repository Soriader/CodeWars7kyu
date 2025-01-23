using CodeWars7kyu;

namespace CodeWarsTest;

public class MostValuableCharacter
{
    [Test]
    public void MostValuableCharacterTest()
    {
        Assert.AreEqual('a', MostValuableCharacterTask.Solve("a"));
        Assert.AreEqual('a', MostValuableCharacterTask.Solve("aa"));
        Assert.AreEqual('b', MostValuableCharacterTask.Solve("bcd"));
        Assert.AreEqual('x', MostValuableCharacterTask.Solve("axyzxyz"));
        Assert.AreEqual('a', MostValuableCharacterTask.Solve("dcbadcba"));
        Assert.AreEqual('c', MostValuableCharacterTask.Solve("aabccc"));
        Assert.AreEqual('e', MostValuableCharacterTask.Solve("efgefg"));
        Assert.AreEqual('e', MostValuableCharacterTask.Solve("efghijefghi"));
        Assert.AreEqual('a', MostValuableCharacterTask.Solve("acefacef"));
        Assert.AreEqual('a', MostValuableCharacterTask.Solve("acefacefacef"));
    }
}