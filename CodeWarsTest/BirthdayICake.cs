using CodeWars7kyu;

namespace CodeWarsTest;

public class BirthdayICake
{
    [Test]
    public void BirthdayICakeTest()
    {
        Assert.AreEqual("That was close!", BirthdayICakeTask.Cake(900, "abcdef"));
        Assert.AreEqual("Fire!", BirthdayICakeTask.Cake(56, "ifkhchlhfd"));
        Assert.AreEqual("Fire!", BirthdayICakeTask.Cake(256, "aaaaaddddr"));
    }
}