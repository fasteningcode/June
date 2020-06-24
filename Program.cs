using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TurnupJune2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // creating an instance of driver/browser
            IWebDriver driver = new ChromeDriver();

            //opening page
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Identify username
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");

            //Identify password
            var passWord = driver.FindElement(By.Name("Password"));
            passWord.SendKeys("123123");

            //Click login
            ////*[@id="loginForm"]/form/div[3]/input[1]
            var loginBtn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            loginBtn.Click();

            //Click Adminstration
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();

            //Click Time and Material
            driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]")).Click();


            //Click create new button
            driver.FindElement(By.XPath("//a[@class='btn btn-primary']")).Click();

            // Enter code
            driver.FindElement(By.Id("Code")).SendKeys("Winter2020");

            // Enter description
            driver.FindElement(By.XPath("//input[@name='Description']")).SendKeys("It gonna be cold");

            //Click save
            driver.FindElement(By.XPath("//input[@class='btn btn-default']")).Click();

            // Implicit Wait
            Thread.Sleep(2000);

            for (int i = 1; i <=10; i++)
            {
                var codeText = driver.FindElement(By.XPath("html/body/div[4]/div/div/div[3]/table/tbody/tr["+i+"]/td[1]"));
                Console.WriteLine(codeText.Text);
            }

            Console.ReadLine();
            //Close browser

            driver.Quit();

        }
    }
}



///html/body/div[4]/div/div/div[3]/table/tbody/tr[i]/td[1].Text
///html/body/div[4]/div/div/div[3]/table/tbody/tr[2]/td[1]