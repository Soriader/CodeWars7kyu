using CodeWars7kyu;

namespace CodeWarsTest;

public class EasyWallpaper
{
    [Test]
    public static void EasyWallpaperTest()
    {
        Assert.AreEqual("sixteen", EasyWallpaperTask.WallPaper(6.3, 4.5, 3.29));
        Assert.AreEqual("seventeen", EasyWallpaperTask.WallPaper(6.3, 5.8, 3.13));
        Assert.AreEqual("zero", EasyWallpaperTask.WallPaper(7.9, 0, 5.4));
    }
}