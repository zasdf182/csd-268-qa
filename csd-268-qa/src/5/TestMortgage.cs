namespace TestMortgage;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;




[TestClass]
public class LetsUseDataTests
{
    private static FirefoxDriver driver;




    // ##################################################################### //
    // ################################ INIT ############################### //
    // ##################################################################### //

    [ClassInitialize]
    public static void InitializeClass(TestContext testContext)
    {
        driver = new FirefoxDriver();
    }

    [TestInitialize]
    public void InitializeTest()
    {
    }




    // ##################################################################### //
    // ############################## CLEANUP ############################## //
    // ##################################################################### //

    [ClassCleanup]
    public static void CleanupClass()
    {
        try
        {
            // Comment out to leave browser open
            driver.Quit();
            driver.Close();
            driver.Dispose();
        }
        catch (Exception)
        {
        }
    }

    [TestCleanup]
    public void CleanupTest()
    {
    }




    // ##################################################################### //
    // ############################### TESTS ############################### //
    // ##################################################################### //

    [TestMethod]
    public void TestMortgage()
    {
    }




    // ##################################################################### //
    // ########################### HELPER METHODS ########################## //
    // ##################################################################### //
}
