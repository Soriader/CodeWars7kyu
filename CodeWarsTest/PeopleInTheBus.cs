﻿using CodeWars7kyu;

namespace CodeWarsTest;

public class PeopleInTheBus
{
    [Test]
    public void PeopleInTheBusTest()
    {

        Assert.AreEqual(5, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));
        Assert.AreEqual(17, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } }));
        Assert.AreEqual(21, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } }));
    }
}