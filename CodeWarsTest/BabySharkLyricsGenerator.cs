﻿using CodeWars7kyu;

namespace CodeWarsTest;

public class BabySharkLyricsGenerator
{
    [Test]
    public void BabySharkLyricsGeneratorTest()
    {
        Assert.AreEqual(string.Join("\n", new string[] {
            "Baby shark, doo doo doo doo doo doo",
            "Baby shark, doo doo doo doo doo doo",
            "Baby shark, doo doo doo doo doo doo",
            "Baby shark!",
            "Mommy shark, doo doo doo doo doo doo",
            "Mommy shark, doo doo doo doo doo doo",
            "Mommy shark, doo doo doo doo doo doo",
            "Mommy shark!",
            "Daddy shark, doo doo doo doo doo doo",
            "Daddy shark, doo doo doo doo doo doo",
            "Daddy shark, doo doo doo doo doo doo",
            "Daddy shark!",
            "Grandma shark, doo doo doo doo doo doo",
            "Grandma shark, doo doo doo doo doo doo",
            "Grandma shark, doo doo doo doo doo doo",
            "Grandma shark!",
            "Grandpa shark, doo doo doo doo doo doo",
            "Grandpa shark, doo doo doo doo doo doo",
            "Grandpa shark, doo doo doo doo doo doo",
            "Grandpa shark!",
            "Let's go hunt, doo doo doo doo doo doo",
            "Let's go hunt, doo doo doo doo doo doo",
            "Let's go hunt, doo doo doo doo doo doo",
            "Let's go hunt!",
            "Run away,…",
            ""
        }), BabySharkLyricsGeneratorTask.BabySharkLyrics());
    }
}