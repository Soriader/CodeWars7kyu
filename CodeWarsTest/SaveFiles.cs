using CodeWars7kyu;

namespace CodeWarsTest;

public class SaveFiles
{
    [Test]
    public void SaveFilesTest()
    {
        Assert.AreEqual(3, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 4, 4, 4, 3, 3 }, 12));
        Assert.AreEqual(2, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 4, 4, 4, 3, 3 }, 11));
        Assert.AreEqual(6, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 4, 8, 15, 16, 23, 42 }, 108));
        Assert.AreEqual(1, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 13 }, 13));
        Assert.AreEqual(4, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 1, 2, 3, 4 }, 250));
        Assert.AreEqual(1, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 100 }, 500));
        Assert.AreEqual(0, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 11, 13, 15, 17, 19 }, 8));
        Assert.AreEqual(0, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 45 }, 12));
    }
}