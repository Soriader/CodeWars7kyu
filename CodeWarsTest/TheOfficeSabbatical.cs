using CodeWars7kyu;

namespace CodeWarsTest;

public class TheOfficeSabbatical
{
    [Test]
    public void TheOfficeSabbaticalTest()
    {
        Assert.AreEqual("Sabbatical! Boom!", TheOfficeSabbaticalTask.Sabb("Can I have a sabbatical?", 5, 5));
        Assert.AreEqual("Back to your desk, boy.", TheOfficeSabbaticalTask.Sabb("Why are you shouting?", 7, 2));
        Assert.AreEqual("Sabbatical! Boom!", TheOfficeSabbaticalTask.Sabb("What do you mean I cant learn to code??", 8, 9));
        Assert.AreEqual("Back to your desk, boy.", TheOfficeSabbaticalTask.Sabb("Please calm down", 9, 1));
    }
}