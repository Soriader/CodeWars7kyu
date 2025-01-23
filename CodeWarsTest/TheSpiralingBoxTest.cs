namespace CodeWarsTest;

using CodeWars7kyu;

public class TheSpiralingBoxTest
{
    [Test]
    public void TheSpiralingBox()
    {
        int[,] box_7_8 = {{1, 1, 1, 1, 1, 1, 1},
            {1, 2, 2, 2, 2, 2, 1},
            {1, 2, 3, 3, 3, 2, 1},
            {1, 2, 3, 4, 3, 2, 1},
            {1, 2, 3, 4, 3, 2, 1},
            {1, 2, 3, 3, 3, 2, 1},
            {1, 2, 2, 2, 2, 2, 1},
            {1, 1, 1, 1, 1, 1, 1}};

        int[,] box_8_7 = {{1, 1, 1, 1, 1, 1, 1, 1},
            {1, 2, 2, 2, 2, 2, 2, 1},
            {1, 2, 3, 3, 3, 3, 2, 1},
            {1, 2, 3, 4, 4, 3, 2, 1},
            {1, 2, 3, 3, 3, 3, 2, 1},
            {1, 2, 2, 2, 2, 2, 2, 1},
            {1, 1, 1, 1, 1, 1, 1, 1}};

        int[,] box_4_2 = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };

        int[,] box_2_4 = { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 } };

        Assert.That(TheSpiralingBoxTask.CreateBox(7, 8), Is.EqualTo(box_7_8));

        Assert.That(TheSpiralingBoxTask.CreateBox(8, 7), Is.EqualTo(box_8_7));

        Assert.That(TheSpiralingBoxTask.CreateBox(4, 2), Is.EqualTo(box_4_2));

        Assert.That(TheSpiralingBoxTask.CreateBox(2, 4), Is.EqualTo(box_2_4));
    }
}