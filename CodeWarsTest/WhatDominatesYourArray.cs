using CodeWars7kyu;

namespace CodeWarsTest;

public class WhatDominatesYourArray
{
    [Test]
    public void WhatDominatesYourArrayTest()
    {
        Assert.AreEqual(3, WhatDominatesYourArrayTask.WhoDominates(new int[] { 3, 4, 3, 2, 3, 1, 3, 3 }));
        Assert.AreEqual(-1, WhatDominatesYourArrayTask.WhoDominates(new int[] { 1, 2, 3, 4, 5 }));
        Assert.AreEqual(-1, WhatDominatesYourArrayTask.WhoDominates(new int[] { 1, 1, 1, 2, 2, 2 }));
        Assert.AreEqual(2, WhatDominatesYourArrayTask.WhoDominates(new int[] { 1, 1, 1, 2, 2, 2, 2 }));
    }
}