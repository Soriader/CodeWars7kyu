using CodeWars7kyu;

namespace CodeWarsTest;

public class ClassFunctionFactory
{
    [Test]
    public static void ClassFunctionFactoryTest()
    {
        Func<int[], int[]> threes = ClassFunctionFactoryTask.Factory(3);
        int[] myArr = new int[] { 1, 2, 3 };
        testing(threes(myArr), new int[] { 3, 6, 9 });
        Func<int[], int[]> fives = ClassFunctionFactoryTask.Factory(5);
        testing(fives(myArr), new int[] { 5, 10, 15 });

        static void testing(int[] expected, int[] actual)
        {
            Assert.AreEqual(expected, actual);
        }

    }
}