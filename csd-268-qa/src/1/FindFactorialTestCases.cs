namespace FindFactorialTestCases;
using static Helper.Math;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public partial class UnitTests
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(1, Factorial(0));
    }

    //Your code starts here
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod2()
    {
        Factorial(int.MinValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod3()
    {
        Factorial(int.MinValue + 1);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod4()
    {
        Factorial(-1);
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.AreEqual(1, Factorial(1));   
    }

    [TestMethod]
    public void TestMethod6()
    {
        Assert.AreEqual(11*10*9*8*7*6*5*4*3*2*1, Factorial(11));   
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.AreEqual(12*11*10*9*8*7*6*5*4*3*2*1, Factorial(12));   
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod8()
    {
        Factorial(13);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod9()
    {
        Factorial(int.MaxValue - 1); 
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod10()
    {
        Factorial(int.MaxValue);
    }

    //Your code ends here
}
