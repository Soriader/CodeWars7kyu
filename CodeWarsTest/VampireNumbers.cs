using CodeWars7kyu;

namespace CodeWarsTest;

public class VampireNumbers
{
    [Test]
    public void VampireNumbersTest()
    {
        Assert.AreEqual(true, VampireNumbersTask.Vampire(21, 6), "Basic: 21 * 6 = 126 should return True");
        Assert.AreEqual(true, VampireNumbersTask.Vampire(30, -51), "One Negative: 30 * -51 = -1530 should return True");
        Assert.AreEqual(false, VampireNumbersTask.Vampire(-246, -510), "Double Negatives: -246 * -510 = 125460 should return False (The negative signs aren't present on the product)");
        Assert.AreEqual(true, VampireNumbersTask.Vampire(204, 615), "Basic: 204 * 615 = 125460 should return True");
        Assert.AreEqual(true, VampireNumbersTask.Vampire(204, 615), "Basic: 204 * 615 = 125460 should return True");

    }
}