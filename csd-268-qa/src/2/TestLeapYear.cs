namespace TestLeapYear;
using static Helper2.Time;

//////////////////////
// ASSIGNMENT START //
//////////////////////

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public partial class LeapTesting
{
    // Your code starts here

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MINIMUM ##################### //
    // ##################################################################### //

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod1()
    {
        IsLeap(int.MinValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod2()
    {
        IsLeap(int.MinValue + 1);
    }

    // ##################################################################### //
    // ### BOUNDARY: 1582 (THE YEAR GREGORIAN CALENDAR WENT INTO EFFECT) ### //
    // ##################################################################### //

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod3()
    {
        IsLeap(1582 - 1);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.AreEqual(false, IsLeap(1582));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.AreEqual(false, IsLeap(1582 + 1)); // Also 1584 - 1
    }

    // ##################################################################### //
    // ################## BOUNDARY: 1584 (DIVISIBLE BY 4) ################## //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod6()
    {
        Assert.AreEqual(true, IsLeap(1584));
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.AreEqual(false, IsLeap(1584 + 1));
    }

    // ##################################################################### //
    // ################# BOUNDARY: 1600 (DIVISIBLE BY 400) ################# //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod8()
    {
        Assert.AreEqual(false, IsLeap(1600 - 1));
    }

    [TestMethod]
    public void TestMethod9()
    {
        Assert.AreEqual(true, IsLeap(1600));
    }

    [TestMethod]
    public void TestMethod10()
    {
        Assert.AreEqual(false, IsLeap(1600 + 1));
    }

    // ##################################################################### //
    // ################# BOUNDARY: 1700 (DIVISIBLE BY 100) ################# //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod11()
    {
        Assert.AreEqual(false, IsLeap(1700 - 1));
    }

    [TestMethod]
    public void TestMethod12()
    {
        Assert.AreEqual(false, IsLeap(1700));
    }

    [TestMethod]
    public void TestMethod13()
    {
        Assert.AreEqual(false, IsLeap(1700 + 1));
    }

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MAXIMUM ##################### //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod14()
    {
        Assert.AreEqual(false, IsLeap(int.MaxValue - 1));
    }

    [TestMethod]
    public void TestMethod15()
    {
        Assert.AreEqual(false, IsLeap(int.MaxValue));
    }

    // Your code ends here
}
