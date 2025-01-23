using CodeWars7kyu;

namespace CodeWarsTest;

public class PasswordSystem
{
    [Test]
    public void PasswordSystemTest()
    {
        string expected = "Yes";

        string actual = PasswordSystemTask.HelpZoom(new int[] { 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1 });

        Assert.AreEqual(expected, actual);
    }
}