using CodeWars7kyu;

namespace CodeWarsTest;

public class AnimalsAndInheritance
{
    [Test]
    public void AnimalsAndInheritanceTest()
    {
        Dog doug = new Dog("Doug", 12, "Serving his master", "Eliza");
        Assert.AreEqual("Doug", doug.Name);
        Assert.AreEqual(12, doug.Age);
        Assert.AreEqual(4, doug.Legs);
        Assert.AreEqual("dog", doug.Species);
        Assert.AreEqual("Serving his master", doug.Status);
        Assert.AreEqual("Hello Eliza", doug.GreetMaster());
    }
}