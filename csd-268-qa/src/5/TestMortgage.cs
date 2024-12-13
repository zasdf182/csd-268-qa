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

    /// <summary>
    /// Tests the mortgage calculator
    /// on https://www.moneyunder30.com/mortgage-calculator
    /// with these values: <br/>
    /// - Home value: 100000 <br/>
    /// - Down payment: 0 <br/>
    /// - Interest rate: 3.50 <br/>
    /// - Length of loan (years): 30 years <br/>
    /// The calculated loan payment should be 449.04.
    /// </summary>
    [TestMethod]
    public void TestMortgage()
    {
        string url = "https://www.moneyunder30.com/mortgage-calculator/";
        driver.Navigate().GoToUrl(url);

        IWebElement homeValueInput = driver.FindElement(By.Id("fieldname23_1"));
        IWebElement downPayInput = driver.FindElement(By.Id("fieldname24_1"));
        IWebElement interestInput = driver.FindElement(By.Id("fieldname25_1"));
        IWebElement lengthInput = driver.FindElement(By.Id("fieldname19_1"));
        IWebElement submitButton = driver.FindElement(By.Id("fieldname26_1"));
        IWebElement loanField = driver.FindElement(By.Id("fieldname20_1"));

        homeValueInput.Clear();
        homeValueInput.SendKeys("$100,000.00");

        downPayInput.Clear();
        downPayInput.SendKeys("$0.00");

        interestInput.Clear();
        interestInput.SendKeys("3.50%");

        lengthInput.Clear();
        lengthInput.SendKeys("30");

        submitButton.Click();
        Assert.AreEqual("$449.04", loanField.GetAttribute("value"));
    }

    /// <summary>
    /// Version of TestMortgage that compiles when submitted to letsusedata.com
    /// </summary>
    public void TestMortgageLUD()
    {
        driver.FindElement(By.Id("fieldname23_1")).Clear();
        driver.FindElement(By.Id("fieldname23_1")).SendKeys("$100,000.00");

        driver.FindElement(By.Id("fieldname24_1")).Clear();
        driver.FindElement(By.Id("fieldname24_1")).SendKeys("$0.00");

        driver.FindElement(By.Id("fieldname25_1")).Clear();
        driver.FindElement(By.Id("fieldname25_1")).SendKeys("3.50%");

        driver.FindElement(By.Id("fieldname19_1")).Clear();
        driver.FindElement(By.Id("fieldname19_1")).SendKeys("30");

        driver.FindElement(By.Id("fieldname26_1")).Click();
        Assert.AreEqual("$449.04", driver.FindElement(By.Id("fieldname20_1")).GetAttribute("value"));
    }
}
