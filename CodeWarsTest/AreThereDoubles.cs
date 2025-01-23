using CodeWars7kyu;

namespace CodeWarsTest;

public class AreThereDoubles
{
    [Test]
    public void AreThereDoublesTest()
    {
        Assert.AreEqual(false, AreThereDoublesTask.DoubleCheck("abca"));
        Assert.AreEqual(true, AreThereDoublesTask.DoubleCheck("aabc"));
        Assert.AreEqual(true, AreThereDoublesTask.DoubleCheck("a 11 c d"));
        Assert.AreEqual(true, AreThereDoublesTask.DoubleCheck("AabBcC"));
        Assert.AreEqual(true, AreThereDoublesTask.DoubleCheck("a b  c"));
        Assert.AreEqual(false, AreThereDoublesTask.DoubleCheck("a b c d e f g h i h k"));
        Assert.AreEqual(false, AreThereDoublesTask.DoubleCheck("2020"));
        Assert.AreEqual(false, AreThereDoublesTask.DoubleCheck("a!@€?#$%^&*()_-+=}]{[|\':;?/>.<,~"));
    }
}