using CodeWars7kyu;

namespace CodeWarsTest;

public class TurnAnyWordIntoABeefTaco
{
    [Test]
    public void TurnAnyWordIntoABeefTacoTest()
    {
        Assert.AreEqual(new string[] { "shell", "shell" }, TurnAnyWordIntoABeefTacoTask.Tacofy(""));
        Assert.AreEqual(new string[] { "shell", "beef", "shell" }, TurnAnyWordIntoABeefTacoTask.Tacofy("a"));
        Assert.AreEqual(new string[] { "shell", "guacamole", "guacamole", "guacamole", "shell" }, TurnAnyWordIntoABeefTacoTask.Tacofy("ggg"));
        Assert.AreEqual(new string[] { "shell", "beef", "guacamole", "lettuce", "shell" }, TurnAnyWordIntoABeefTacoTask.Tacofy("ogl"));
        Assert.AreEqual(new string[] { "shell", "tomato", "beef", "shell" }, TurnAnyWordIntoABeefTacoTask.Tacofy("ydjkpwqrzto"));
    }
}