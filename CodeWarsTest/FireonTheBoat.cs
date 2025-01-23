using CodeWars7kyu;

namespace CodeWarsTest;

public class FireonTheBoat
{
    [Test]
    public void FireonTheBoatTest()
    {
        Assert.AreEqual("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast", FireonTheBoatTask.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));
        Assert.AreEqual("Mast Deck Engine Water ~~", FireonTheBoatTask.FireFight("Mast Deck Engine Water Fire"));
        Assert.AreEqual("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain", FireonTheBoatTask.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
    }
}