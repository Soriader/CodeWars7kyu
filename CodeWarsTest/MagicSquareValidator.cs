namespace CodeWarsTest;

using CodeWars7kyu;

public class MagicSquareValidator
{
    [Test]
    public void MagicSquareValidatorTest()
    {
        Assert.That(MagicSquareValidatorTask.IsMagical(new int[] {4, 9, 2, 3, 5, 7, 8, 1, 6}), Is.True, "This is a valid magic square.");
        Assert.That(MagicSquareValidatorTask.IsMagical(new int[] {4, 9, 2, 3, 5, 7, 8, 6, 1}), Is.False, "Some column(s) and diagonal(s) don't sum to 15");
        Assert.That(MagicSquareValidatorTask.IsMagical(new int[] {4, 5, 2, 3, 9, 7, 8, 1, 6}), Is.False, "Some row(s) don't sum to 15");
    }
}