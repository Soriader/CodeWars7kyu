using CodeWars7kyu;

namespace CodeWarsTest;

public class CharCodeCalculation
{
    [Test]
    public void CharCodeCalculationTest()
    {
        Assert.AreEqual(0, CharCodeCalculationTask.Calc(""));
        Assert.AreEqual(6, CharCodeCalculationTask.Calc("abc"));
        Assert.AreEqual(6, CharCodeCalculationTask.Calc("ABC"));
        Assert.AreEqual(6, CharCodeCalculationTask.Calc("abcdef"));
        Assert.AreEqual(6, CharCodeCalculationTask.Calc("ifkhchlhfd"));
        Assert.AreEqual(6, CharCodeCalculationTask.Calc("jfmgklf8hglbe"));
        Assert.AreEqual(12, CharCodeCalculationTask.Calc("jaam"));
        Assert.AreEqual(18, CharCodeCalculationTask.Calc("AFHJD"));
        Assert.AreEqual(18, CharCodeCalculationTask.Calc("CodeWars"));
        Assert.AreEqual(24, CharCodeCalculationTask.Calc("FVJFVDF"));
        Assert.AreEqual(24, CharCodeCalculationTask.Calc("AOUCUAOF"));
        Assert.AreEqual(30, CharCodeCalculationTask.Calc("aaaaaddddr"));
        Assert.AreEqual(36, CharCodeCalculationTask.Calc("XLdNDcAbUkMnkV"));
        Assert.AreEqual(42, CharCodeCalculationTask.Calc("cSuLifxDQkOiypJsxOJSE"));
        Assert.AreEqual(48, CharCodeCalculationTask.Calc("ZHAUnSGoIbgPSezhjePIbHFrHUOv"));
        Assert.AreEqual(54, CharCodeCalculationTask.Calc("VFhSMbZETZVHxYiiYsBMrWuecDN"));
        Assert.AreEqual(60, CharCodeCalculationTask.Calc("sphPoGbicTCLbiuUcwFMEGaFmy"));
        Assert.AreEqual(72, CharCodeCalculationTask.Calc("oXoQKiCflHIHFyGizCYCuaHhX"));
        Assert.AreEqual(84, CharCodeCalculationTask.Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"));
    }
}