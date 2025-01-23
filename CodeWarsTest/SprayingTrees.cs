using CodeWars7kyu;

namespace CodeWarsTest;

public class SprayingTrees
{
    [Test]
    public void SprayingTreesTest()
    {
        Assert.AreEqual("It is Wednesday today, Robert, you have to work, you must spray 10 trees and you need 20 dollars to buy liquid", SprayingTreesTask.Task("Wednesday", 10, 2));
        Assert.AreEqual("It is Monday today, James, you have to work, you must spray 4 trees and you need 12 dollars to buy liquid", SprayingTreesTask.Task("Monday", 4, 3));
        Assert.AreEqual("It is Friday today, William, you have to work, you must spray 5 trees and you need 20 dollars to buy liquid", SprayingTreesTask.Task("Friday", 5, 4));
        Assert.AreEqual("It is Tuesday today, John, you have to work, you must spray 6 trees and you need 6 dollars to buy liquid", SprayingTreesTask.Task("Tuesday", 6, 1));
        Assert.AreEqual("It is Thursday today, Michael, you have to work, you must spray 5 trees and you need 15 dollars to buy liquid", SprayingTreesTask.Task("Thursday", 5, 3));
    }
}