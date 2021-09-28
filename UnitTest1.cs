using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Betbull1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {

          driver = new FirefoxDriver();
          driver.Manage().Window.Maximize();
            
        }

        [Test]
        [Obsolete]
        public void LoginTest1()
        {
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                
           driver.Navigate().GoToUrl("http://automationpractice.com");

           driver.FindElement(By.LinkText("Sign in")).Click();
            
           driver.FindElement(By.Id("email")).SendKeys("kojo33@aol.com");

           driver.FindElement(By.Id("passwd")).SendKeys("rnasante");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement sub = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name = 'SubmitLogin']")));
            sub.Submit();

           Assert.Pass();
        }

      
    }
}