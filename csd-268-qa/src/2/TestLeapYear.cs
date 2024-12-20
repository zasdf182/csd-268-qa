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
        Assert.IsFalse(IsLeap(1582));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.IsFalse(IsLeap(1582 + 1)); // Also 1584 - 1
    }

    // ##################################################################### //
    // ################## BOUNDARY: 1584 (DIVISIBLE BY 4) ################## //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod6()
    {
        Assert.IsTrue(IsLeap(1584));
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.IsFalse(IsLeap(1584 + 1));
    }

    // ##################################################################### //
    // ################# BOUNDARY: 1600 (DIVISIBLE BY 400) ################# //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod8()
    {
        Assert.IsFalse(IsLeap(1600 - 1));
    }

    [TestMethod]
    public void TestMethod9()
    {
        Assert.IsTrue(IsLeap(1600));
    }

    [TestMethod]
    public void TestMethod10()
    {
        Assert.IsFalse(IsLeap(1600 + 1));
    }

    // ##################################################################### //
    // ################# BOUNDARY: 1700 (DIVISIBLE BY 100) ################# //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod11()
    {
        Assert.IsFalse(IsLeap(1700 - 1));
    }

    [TestMethod]
    public void TestMethod12()
    {
        Assert.IsFalse(IsLeap(1700));
    }

    [TestMethod]
    public void TestMethod13()
    {
        Assert.IsFalse(IsLeap(1700 + 1));
    }

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MAXIMUM ##################### //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod14()
    {
        Assert.IsFalse(IsLeap(int.MaxValue - 1));
    }

    [TestMethod]
    public void TestMethod15()
    {
        Assert.IsFalse(IsLeap(int.MaxValue));
    }

    // Your code ends here
}
