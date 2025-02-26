namespace CodeWarsTest;

using CodeWars7kyu;

public class PositiveToNegativeBinaryNumbers
{
    int[] Test1 = new int[] {0,0,0,0};
    int[] Test2 = new int[] {0,0,1,0};
    int[] Test3 = new int[] {0,0,1,1};
    int[] Test4 = new int[] {0,1,0,0};
    int[] Test5 = new int[] {0, 1, 0, 0, 1};


    [Test]
    public void PositiveToNegativeBinaryNumbersTest()
    {
        Assert.That(PositiveToNegativeBinaryNumbersTask.Positive2Negative(Test1), Is.EqualTo(Test1));
        Assert.That(PositiveToNegativeBinaryNumbersTask.Positive2Negative(Test2), Is.EqualTo(new int[] {1,1,1,0}));
        Assert.That(PositiveToNegativeBinaryNumbersTask.Positive2Negative(Test3), Is.EqualTo(new int[] {1,1,0,1}));
        Assert.That(PositiveToNegativeBinaryNumbersTask.Positive2Negative(Test4), Is.EqualTo(new int[] {1,1,0,0}));
        Assert.That(PositiveToNegativeBinaryNumbersTask.Positive2Negative(Test5), Is.EqualTo(new int[] {1, 0, 1, 1, 1}));
    }
}