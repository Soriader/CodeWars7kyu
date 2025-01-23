using CodeWars7kyu;

namespace CodeWarsTest;

public class CatDog
{
    [Test]
    public void CatDogTest()
    {
        Assert.AreEqual((1, 1), CatDogTask.OwnedCatAndDog(15, 15));
        Assert.AreEqual((2, 2), CatDogTask.OwnedCatAndDog(24, 24));
        Assert.AreEqual((10, 10), CatDogTask.OwnedCatAndDog(56, 64));
    }
}