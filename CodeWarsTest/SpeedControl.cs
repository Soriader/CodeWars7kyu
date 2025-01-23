using CodeWars7kyu;

namespace CodeWarsTest;

public class SpeedControl
{
    [Test]
    public void SpeedControlTest()
    {
        Assert.AreEqual(41, SpeedControlTask.Gps(20, new double[] { 0.0, 0.23, 0.46, 0.69, 0.92, 1.15, 1.38, 1.61 }));
        Assert.AreEqual(219, SpeedControlTask.Gps(12, new double[] { 0.0, 0.11, 0.22, 0.33, 0.44, 0.65, 1.08, 1.26, 1.68, 1.89, 2.1, 2.31, 2.52, 3.25 }));
        Assert.AreEqual(80, SpeedControlTask.Gps(20, new double[] { 0.0, 0.18, 0.36, 0.54, 0.72, 1.05, 1.26, 1.47, 1.92, 2.16, 2.4, 2.64, 2.88, 3.12, 3.36, 3.6, 3.84 }));
        Assert.AreEqual(90, SpeedControlTask.Gps(14, new double[] { 0.0, 0.01, 0.36, 0.6, 0.84, 1.05, 1.26, 1.47, 1.68, 1.89, 2.1, 2.31, 2.52, 2.73, 2.94, 3.15 }));
        Assert.AreEqual(72, SpeedControlTask.Gps(17, new double[] { 0.0, 0.02, 0.36, 0.54, 0.72, 0.9, 1.08, 1.26, 1.44, 1.62, 1.8 }));
        Assert.AreEqual(72, SpeedControlTask.Gps(12, new double[] { 0.0, 0.24, 0.48, 0.72, 0.96, 1.2, 1.44, 1.68, 1.92, 2.16, 2.4 }));
        Assert.AreEqual(88, SpeedControlTask.Gps(17, new double[] { 0.0, 0.02, 0.44, 0.66, 0.88, 1.1, 1.32, 1.54, 1.76 }));
        Assert.AreEqual(76, SpeedControlTask.Gps(16, new double[] { 0.0, 0.2, 0.4, 0.6, 0.8, 1.0, 1.32, 1.54, 1.76, 1.98, 2.2, 2.42, 2.76, 2.99, 3.22, 3.45 }));
        Assert.AreEqual(82, SpeedControlTask.Gps(17, new double[] { 0.0, 0.01, 0.36, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0, 3.25, 3.5, 3.75, 4.0, 4.25, 4.5, 4.75 }));
        Assert.AreEqual(58, SpeedControlTask.Gps(19, new double[] { 0.0, 0.2, 0.4, 0.69, 0.92, 1.15, 1.38, 1.61, 1.92, 2.16, 2.4, 2.64, 2.88, 3.12, 3.36 }));
        Assert.AreEqual(0, SpeedControlTask.Gps(19, new double[] { }));
        Assert.AreEqual(0, SpeedControlTask.Gps(19, new double[] { 0.0 }));
    }
}