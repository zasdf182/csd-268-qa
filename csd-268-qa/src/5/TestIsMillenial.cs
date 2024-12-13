namespace TestIsMillenial;
using static Helper5.Generation;

//////////////////////
// ASSIGNMENT START //
//////////////////////

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public partial class MidtermP1
{
    // Your code starts here

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MINIMUM ##################### //
    // ##################################################################### //

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod1()
    {
        IsMillenial(int.MinValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod2()
    {
        IsMillenial(int.MinValue + 1);
    }

    // ##################################################################### //
    // ### BOUNDARY: 1582 (THE YEAR GREGORIAN CALENDAR WENT INTO EFFECT) ### //
    // ##################################################################### //

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestMethod3()
    {
        IsMillenial(1582 - 1);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.IsFalse(IsMillenial(1582));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.IsFalse(IsMillenial(1582 + 1));
    }
    
    // ##################################################################### //
    // ######## BOUNDARY: 1981 (LOWER BOUND OF MILLENIAL GENERATION) ####### //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod6()
    {
        Assert.IsFalse(IsMillenial(1981 - 1));
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.IsTrue(IsMillenial(1981));
    }

    [TestMethod]
    public void TestMethod8()
    {
        Assert.IsTrue(IsMillenial(1981 + 1));
    }


    // ##################################################################### //
    // ######## BOUNDARY: 1996 (UPPER BOUND OF MILLENIAL GENERATION) ####### //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod9()
    {
        Assert.IsTrue(IsMillenial(1996 - 1));
    }

    [TestMethod]
    public void TestMethod10()
    {
        Assert.IsTrue(IsMillenial(1996));
    }

    [TestMethod]
    public void TestMethod11()
    {
        Assert.IsTrue(IsMillenial(1996 + 1));
    }

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MAXIMUM ##################### //
    // ##################################################################### //

    [TestMethod]
    public void TestMethod12()
    {
        Assert.IsFalse(IsMillenial(int.MaxValue - 1));
    }

    [TestMethod]
    public void TestMethod13()
    {
        Assert.IsFalse(IsMillenial(int.MaxValue));
    }

    // Your code ends here

}
