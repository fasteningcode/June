using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnupJune2020
{
    public static class IWebElementExtensions
    {
        public static IWebElement Wait(IWebDriver driver, TimeSpan time, By element)
        {            
            return new WebDriverWait(driver, time).Until(ExpectedConditions.ElementToBeClickable(element));
        }        
    }
}
