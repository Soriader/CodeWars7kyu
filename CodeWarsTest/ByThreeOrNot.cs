using CodeWars7kyu;

namespace CodeWarsTest;

public class ByThreeOrNot
{
    [Test]
    public void ByThreeOrNotTest()
    {
        Assert.That(ByThreeOrNotTask.DivisibleByThree("1891009"), Is.EqualTo(false));
        Assert.That(ByThreeOrNotTask.DivisibleByThree("00009"), Is.EqualTo(true));
        Assert.That(ByThreeOrNotTask.DivisibleByThree("57"), Is.EqualTo(true));
    }
}