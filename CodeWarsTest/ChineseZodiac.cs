using CodeWars7kyu;

namespace CodeWarsTest;

public class ChineseZodiac
{
    [Test]
    public void ChineseZodiacTest()
    {
        Assert.AreEqual("Wood Snake", ChineseZodiacTask.ChineseZodiac(1965));
        Assert.AreEqual("Earth Tiger", ChineseZodiacTask.ChineseZodiac(1938));
        Assert.AreEqual("Earth Tiger", ChineseZodiacTask.ChineseZodiac(1998));
        Assert.AreEqual("Fire Monkey", ChineseZodiacTask.ChineseZodiac(2016));
        Assert.AreEqual("Wood Rat", ChineseZodiacTask.ChineseZodiac(1924));
        Assert.AreEqual("Earth Monkey", ChineseZodiacTask.ChineseZodiac(1968));
        Assert.AreEqual("Water Dog", ChineseZodiacTask.ChineseZodiac(2162));
    }
}