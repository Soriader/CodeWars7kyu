using CodeWars7kyu;

namespace CodeWarsTest;

public class RemoveTheNoiseFromTheString
{
    [Test]
    public void RemoveTheNoiseFromTheStringTest()
    {
        Assert.That(RemoveTheNoiseFromTheStringTask.RemoveNoise("%$&/#·@|º\\ª"), Is.EqualTo(""), "You failed the test for '%$&/#·@|º\\ª'. (Please note that in c# special characters are displayed as '?' in the error screen)");
        Assert.That(RemoveTheNoiseFromTheStringTask.RemoveNoise("h%e&·%$·llo w&%or&$l·$%d"), Is.EqualTo("hello world"), "You failed the test for 'h%e&·%$·llo w&%or&$l·$%d'.");    
        Assert.That(RemoveTheNoiseFromTheStringTask.RemoveNoise("he%$·ll@o c$&%odi%&ng for ev|#·ery&$$#$on%$·e"), Is.EqualTo("hello coding for everyone"), "You failed the test for 'he%$·ll@o c$&%odi%&ng for ev|#·ery&$$#$on%$·e'.");
        Assert.That(RemoveTheNoiseFromTheStringTask.RemoveNoise("c|o@$%de%w@a·$r%s &rºocªks"), Is.EqualTo("codewars rocks"), "You failed the test for 'c|o@$%de%w@a·$r%s &rºocªks'.(Please note that in c# special characters are displayed as '?' in the error screen)");
    }
}