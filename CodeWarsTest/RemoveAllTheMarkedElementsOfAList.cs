using CodeWars7kyu;

namespace CodeWarsTest;

public class RemoveAllTheMarkedElementsOfAList
{
    [Test]
    public void RemoveAllTheMarkedElementsOfAListTest()
    {

        CollectionAssert.AreEqual(new int[] { 2, 2, 4 }, RemoveAllTheMarkedElementsOfAListTask.Remove(new int[] { 1, 1, 2, 3, 1, 2, 3, 4 }, new int[] { 1, 3 }));
        CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8 }, RemoveAllTheMarkedElementsOfAListTask.Remove(new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 }, new int[] { 1, 3, 4, 2 }));

    }
}