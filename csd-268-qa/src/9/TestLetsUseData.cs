namespace TestLetsUseData;
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
    /// Attempts to login to https://letsusedata.com/ with credentials: <br/>
    /// - Username: test1 <br/>
    /// - Password: Test12456 <br/>
    /// Should result in a successful login.
    /// </summary>
    [TestMethod]
    public void TestLoginSuccess()
    {
        TryLogin("test1", "Test12456");

        // Wait for page to load before testing assertions
        try
        {
            TimeSpan timeout = TimeSpan.FromSeconds(5);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(d => d.Url.Contains("CourseSelection"));
        }
        catch (OpenQA.Selenium.WebDriverTimeoutException)
        {
        }
        
        // Test assertions
        string expectedUrl = "https://letsusedata.com/CourseSelection.html";
        Assert.AreEqual(expectedUrl, driver.Url);
    }

    /// <summary>
    /// Attempts to login to https://letsusedata.com/ with credentials: <br/>
    /// - Username: test1 <br/>
    /// - Password: test1234 <br/>
    /// Should result in an unsuccessful login.
    /// </summary>
    [TestMethod]
    public void TestLoginFail() {
        TryLogin("test1", "test1234");

        // Wait for page to load before testing assertions
        try
        {
            TimeSpan timeout = TimeSpan.FromSeconds(5);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(d => d.Url.Contains("CourseSelection"));
        }
        catch (OpenQA.Selenium.WebDriverTimeoutException)
        {
        }

        // Test assertions
        string expectedUrl = "https://letsusedata.com/";
        Assert.AreEqual(expectedUrl, driver.Url);
    }
    



    // ##################################################################### //
    // ########################### HELPER METHODS ########################## //
    // ##################################################################### //

    /// <summary>
    /// Click on an input element and type something in it.
    /// </summary>
    private void TypeInput(IWebElement inputElem, string text)
    {
        inputElem.Click();
        inputElem.Clear();
        inputElem.SendKeys(text);
    }

    /// <summary>
    /// Attempt to login to https://letsusedata.com/.
    /// </summary>
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
