using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Test1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void The1Test()
        {
            driver.Navigate().GoToUrl("http://localhost:58552/");
            driver.FindElement(By.Name("iGender")).Click();
            driver.FindElement(By.Name("iGender")).Clear();
            driver.FindElement(By.Name("iGender")).SendKeys("male");
            driver.FindElement(By.Name("iAge")).Click();
            driver.FindElement(By.Name("iAge")).Clear();
            driver.FindElement(By.Name("iAge")).SendKeys("24");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //html | ]]
            driver.FindElement(By.Id("MainContent_TextArea1")).Click();
            try
            {
                Assert.AreEqual("6", driver.FindElement(By.Id("MainContent_TextArea1")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        [Test]
        public void The2Test()
        {
            driver.Navigate().GoToUrl("http://localhost:58552/");
            driver.FindElement(By.Name("iGender")).Click();
            driver.FindElement(By.Name("iGender")).Clear();
            driver.FindElement(By.Name("iGender")).SendKeys("female");
            driver.FindElement(By.Name("iAge")).Click();
            driver.FindElement(By.Name("iAge")).Clear();
            driver.FindElement(By.Name("iAge")).SendKeys("36");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //html | ]]
            driver.FindElement(By.Id("MainContent_TextArea1")).Click();
            try
            {
                Assert.AreEqual("2.5", driver.FindElement(By.Id("MainContent_TextArea1")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        public void The3Test()
        {
            driver.Navigate().GoToUrl("http://localhost:58552/");
            driver.FindElement(By.Name("iGender")).Click();
            driver.FindElement(By.Name("iGender")).Clear();
            driver.FindElement(By.Name("iGender")).SendKeys("abc");
            driver.FindElement(By.Name("iAge")).Click();
            driver.FindElement(By.Name("iAge")).Clear();
            driver.FindElement(By.Name("iAge")).SendKeys("18");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //html | ]]
            driver.FindElement(By.Id("MainContent_TextArea1")).Click();
            try
            {
                Assert.AreEqual("0", driver.FindElement(By.Id("MainContent_TextArea1")).GetAttribute("value"));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
//2.5