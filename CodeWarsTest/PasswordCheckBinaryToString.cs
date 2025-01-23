﻿using CodeWars7kyu;

namespace CodeWarsTest;

public class PasswordCheckBinaryToString
{
    [Test]
    public void PasswordCheckBinaryToStringTest()
    {
        Assert.AreEqual("password123",
            PasswordCheckBinaryToStringTask.DecodePass(new string[] { "password123", "admin", "admin1" },
                "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
    }
}