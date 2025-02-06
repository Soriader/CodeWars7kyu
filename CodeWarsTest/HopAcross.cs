namespace CodeWarsTest;

using CodeWars7kyu;

public class HopAcross
{
    [Test]
    public void HopAcrossTest()
    {
        Assert.That(HopAcrossTask.HopAcross(new List<int> {1}), Is.EqualTo(2));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {2}), Is.EqualTo(2));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {1,1}), Is.EqualTo(4));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {2,1}), Is.EqualTo(3));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {2,1,1}), Is.EqualTo(5));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {1,2,1,2}), Is.EqualTo(5));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {1,2,5,1}), Is.EqualTo(5));
        Assert.That(HopAcrossTask.HopAcross(new List<int> {2,2,3,1,1,2,1}), Is.EqualTo(7));
    }
}