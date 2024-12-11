
namespace TestCanDrive;

using static Helper9.Age;
using Microsoft.VisualStudio.TestTools.UnitTesting;




[TestClass]
public partial class AgeTests
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsFalse(CanDrive(int.MinValue));
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.IsFalse(CanDrive(int.MinValue + 1));
    }

    [TestMethod]
    public void TestMethod3()
    {
        Assert.IsFalse(CanDrive(15));
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.IsTrue(CanDrive(16));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.IsTrue(CanDrive(17));
    }

    [TestMethod]
    public void TestMethod6()
    {
        Assert.IsTrue(CanDrive(int.MaxValue - 1));
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.IsTrue(CanDrive(int.MaxValue));
    }
}
