using CodeWars7kyu;

namespace CodeWarsTest;

public class VeryEvenNumbers
{
    [Test]
    public void VeryEvenNumbersTest()
    {
        Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(4));
        Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(0));
        Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(400000220));
        Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(12));
        Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(222));
        Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(5));
        Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(45));
        Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(1234));
    }
}