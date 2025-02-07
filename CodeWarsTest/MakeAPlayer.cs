namespace CodeWarsTest;

using CodeWars7kyu;

public class MakeAPlayer
{
    [Test]
    public void SampleTest()
    {
        Player player = new Player("Player", "Right Winger", 25, 75, 90, 65);
        Assert.That(player.Name, Is.EqualTo("Player"));
        Assert.That(player.Position, Is.EqualTo("Right Winger"));
        Assert.That(player.Age, Is.EqualTo(25));
        Assert.That(player.Dribbling, Is.EqualTo(75));
        Assert.That(player.Pass, Is.EqualTo(90));
        Assert.That(player.Shoot, Is.EqualTo(65));
    }
}