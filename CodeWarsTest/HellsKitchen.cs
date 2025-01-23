using CodeWars7kyu;

namespace CodeWarsTest;

public class HellsKitchen
{
    [Test]
    public void HellsKitchenTest()
    {
        Assert.AreEqual("WH@T!!!! F*CK!!!! D@MN!!!! C@K*!!!!", HellsKitchenTask.Gordon("What feck damn cake"));
        Assert.AreEqual("@R*!!!! Y**!!!! ST*!!!! P*D!!!!", HellsKitchenTask.Gordon("are you stu pid"));
        Assert.AreEqual("*!!!! @M!!!! @!!!! CH*F!!!!", HellsKitchenTask.Gordon("i am a chef"));
    }
}