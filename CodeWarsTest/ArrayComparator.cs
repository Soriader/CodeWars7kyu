namespace CodeWarsTest;

using CodeWars7kyu;

public class ArrayComparator
{
    [Test]
    public void ArrayComparatorTest()
    {
        Assert.That(ArrayComparatorTask.MatchArrays(new int[] {1,2,3,4,5}, new int[] {2, 3, 4, 5, 6}), Is.EqualTo(4));
        Assert.That(ArrayComparatorTask.MatchArrays(new int[] {1,2,3,4,5}, new int[] {5, 4}), Is.EqualTo(2));
        Assert.That(ArrayComparatorTask.MatchArrays(new int[] {0, -1, 1, 4}, new int[] {-1}), Is.EqualTo(1));
    }
}