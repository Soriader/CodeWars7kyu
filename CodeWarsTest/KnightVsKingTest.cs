namespace CodeWarsTest;

using CodeWars7kyu;

public class KnightVsKingTest
{
    [Test]
    public void KnightVsKing()
    {
        object[] kingPosition = { 2, "F" };
        object[] knightPosition = { 6, "B" };
        Assert.That(KnightVsKingTask.KnightVsKing(knightPosition, kingPosition), Is.EqualTo("None").IgnoreCase);

        object[] kingPosition2 = { 4, "C" };
        object[] knightPosition2 = { 6, "D" };
        Assert.That(KnightVsKingTask.KnightVsKing(knightPosition2, kingPosition2), Is.EqualTo("Knight").IgnoreCase);

        object[] kingPosition3 = { 7, "B" };
        object[] knightPosition3 = { 6, "C" };
        Assert.That(KnightVsKingTask.KnightVsKing(knightPosition3, kingPosition3), Is.EqualTo("King").IgnoreCase);
    }
}