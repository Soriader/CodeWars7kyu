namespace CodeWarsTest;

using CodeWars7kyu;

public class AirportItinerary
{
    [Test, Order(1)]
    public void SimpleTest()
    {
        var travel = new [] 
        { 
            new Route { In = "TRN", Out = "FCO"}
        };
        Assert.That(AirportItineraryTask.Itinerary(travel), Is.EqualTo("TRN-FCO"));
    }
    
    [Test, Order(2)]
    public void MultipleTest()
    {
        var travel = new [] 
        { 
            new Route { In = "TRN", Out = "FCO"}, 
            new Route { In = "CIA", Out = "JFK"} 
        };
        Assert.That(AirportItineraryTask.Itinerary(travel), Is.EqualTo("TRN-FCO-CIA-JFK"));
    }
    
    [Test, Order(3)]
    public void SameAirportsAreSkippedTest()
    {
        var travel = new [] 
        { 
            new Route { In = "TRN", Out = "FCO"}, 
            new Route { In = "FCO", Out = "JFK"} 
        };
        Assert.That(AirportItineraryTask.Itinerary(travel), Is.EqualTo("TRN-FCO-JFK"));
    }

    [Test, Order(4)]
    public void RoundTripAreConservedTest()
    {
        var travel = new [] 
        { 
            new Route { In = "TRN", Out = "FCO"}, 
            new Route { In = "CIA", Out = "TRN"} 
        };
        Assert.That(AirportItineraryTask.Itinerary(travel), Is.EqualTo("TRN-FCO-CIA-TRN"));
    }
    
    [Test, Order(5)]
    public void RoundTripAreConservedWithSharedAirportsTest()
    {
        var travel = new [] 
        { 
            new Route { In = "TRN", Out = "FCO"}, 
            new Route { In = "FCO", Out = "TRN"} 
        };
        Assert.That(AirportItineraryTask.Itinerary(travel), Is.EqualTo("TRN-FCO-TRN"));
    }    
}