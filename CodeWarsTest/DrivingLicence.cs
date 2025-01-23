using CodeWars7kyu;

namespace CodeWarsTest;

public class DrivingLicence
{
    [Test]
    public void DrivingLicenceTest()
    {
        DrivingLicenceTask test2 = new DrivingLicenceTask();
        string[] data2 = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };
        Assert.AreEqual("GIBBS862131J99AA", test2.Driver(data2));

        DrivingLicenceTask test = new DrivingLicenceTask();
        string[] data = new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
        Assert.AreEqual("LEE99809021AR9AA", test.Driver(data));
    }
}