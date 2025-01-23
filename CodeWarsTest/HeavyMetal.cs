using CodeWars7kyu;

namespace CodeWarsTest;

public class HeavyMetal
{
    [Test]
    public void HeavyMetalTest()
    {
        Assert.AreEqual("Ännöüncïng thë Mäcböök Äïr Güïtär", HeavyMetalTask.HeavyMetalUmlauts("Announcing the Macbook Air Guitar"));
        Assert.AreEqual("Fäcëböök ïntrödücës nëw hëävÿ mëtäl rëäctïön büttöns", HeavyMetalTask.HeavyMetalUmlauts("Facebook introduces new heavy metal reaction buttons"));
        Assert.AreEqual("Ströng sälës öf Gööglë's VR Mëtälhëädsëts sënd tëch stöck prïcës söärïng", HeavyMetalTask.HeavyMetalUmlauts("Strong sales of Google's VR Metalheadsets send tech stock prices soaring"));
        Assert.AreEqual("Vëgän Bläck Mëtäl Chëf hïts thë bïg tïmë ön Ämäzön TV", HeavyMetalTask.HeavyMetalUmlauts("Vegan Black Metal Chef hits the big time on Amazon TV"));
    }
}