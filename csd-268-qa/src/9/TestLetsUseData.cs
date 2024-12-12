
namespace TestLetsUseData;


using System;
using System.Net.WebSockets;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;



[TestClass]
public class LetsUseDataTests
{
    private static FirefoxDriver driver;
    private StringBuilder verificationErrors;
    private bool acceptNextAlert = true;

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
        verificationErrors = new StringBuilder();
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
            // driver.Quit();
            // driver.Close();
            // driver.Dispose();
        }
        
        catch (Exception)
        {
        }
    }

    [TestCleanup]
    public void CleanupTest()
    {
        Assert.AreEqual("", verificationErrors.ToString());
    }

    // ##################################################################### //
    // ############################### TESTS ############################### //
    // ##################################################################### //

    [TestMethod]
    public void TestLoginSuccess()
    {
        TryLogin("test1", "Test12456");

        try
        {
            TimeSpan timeout = TimeSpan.FromSeconds(5);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(d => d.Url.Contains("CourseSelection"));
        }
        catch (OpenQA.Selenium.WebDriverTimeoutException)
        {
        }
        
        string expectedUrl = "https://letsusedata.com/CourseSelection.html";
        Assert.AreEqual(expectedUrl, driver.Url);
    }

    [TestMethod]
    public void TestLoginFail() {
        TryLogin("test1", "test1234");

        try
        {
            TimeSpan timeout = TimeSpan.FromSeconds(5);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(d => d.Url.Contains("CourseSelection"));
        }
        catch (OpenQA.Selenium.WebDriverTimeoutException)
        {
        }

        string expectedUrl = "https://letsusedata.com/";
        Assert.AreEqual(expectedUrl, driver.Url);
    }
    
    // ##################################################################### //
    // ########################### HELPER METHODS ########################## //
    // ##################################################################### //

    private void TypeInput(IWebElement inputElem, string text)
    {
        inputElem.Click();
        inputElem.Clear();
        inputElem.SendKeys(text);
    }

    private void TryLogin(string username, string password) {
        driver.Navigate().GoToUrl("https://letsusedata.com");

        IWebElement usernameInput = driver.FindElement(By.Id("txtUser"));
        IWebElement passwordInput = driver.FindElement(By.Id("txtPassword"));
        IWebElement loginButton = driver.FindElement(By.Id("javascriptLogin"));

        TypeInput(usernameInput, username);
        TypeInput(passwordInput, password);
        loginButton.Click();
    }
}
