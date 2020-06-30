using System;
using OpenQA.Selenium;

namespace TurnupJune2020
{
    public class LoginPage
    {
        public LoginPage()
        {
        }

        public void LoginSuccess(IWebDriver driver)
        {
            //maximizing the window
            driver.Manage().Window.Maximize();
            //opening the url
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");

            // login to system
            IWebElement webElement = driver.FindElement(By.Id("txtUsername"));
            webElement.SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
        }
    }
}
