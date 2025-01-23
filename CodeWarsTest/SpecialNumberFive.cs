using CodeWars7kyu;

namespace CodeWarsTest;

public class SpecialNumberFive
{
    [Test]
    public void SpecialNumberFiveTest()
    {
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00002), Is.EqualTo("Special!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00003), Is.EqualTo("Special!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00011), Is.EqualTo("Special!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00055), Is.EqualTo("Special!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(25432), Is.EqualTo("Special!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(02783), Is.EqualTo("NOT!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00006), Is.EqualTo("NOT!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00009), Is.EqualTo("NOT!!"));
        Assert.That(SpecialNumberFiveTask.SpecialNumber(00026), Is.EqualTo("NOT!!"));
    }
}