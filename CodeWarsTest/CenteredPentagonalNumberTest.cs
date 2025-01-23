namespace CodeWarsTest;

using CodeWars7kyu;

public class CenteredPentagonalNumberTest
{
    [Test]
    public void CenteredPentagonalNumber()
    {
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(0), Is.EqualTo(-1));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(-1), Is.EqualTo(-1));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(-21), Is.EqualTo(-1));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(1), Is.EqualTo(1));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(2), Is.EqualTo(6));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(8), Is.EqualTo(141));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(10), Is.EqualTo(226));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(100), Is.EqualTo(24751));
        Assert.That(CenteredPentagonalNumberTask.Pentagonal(77686), Is.EqualTo(15087592276));
    }
}