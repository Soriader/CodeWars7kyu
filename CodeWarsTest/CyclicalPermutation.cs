using CodeWars7kyu;

namespace CodeWarsTest;

public class CyclicalPermutation
{
    [Test]
    public void CyclicalPermutationTest()
    {
        Assert.AreEqual("1234567\n2345671\n3456712\n4567123\n5671234\n6712345\n7123456", CyclicalPermutationTask.Pattern(7));
        Assert.AreEqual("1", CyclicalPermutationTask.Pattern(1));
        Assert.AreEqual("1234\n2341\n3412\n4123", CyclicalPermutationTask.Pattern(4));
        Assert.AreEqual("", CyclicalPermutationTask.Pattern(0));
        Assert.AreEqual("", CyclicalPermutationTask.Pattern(-25));
    }
}