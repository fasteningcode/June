using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TurnupJune2020
{
    internal class DashBoardPage
    {
        public DashBoardPage()
        {
        }

        internal void ClickUsers(IWebDriver driver)
        {
            // Identfying the user management
            var Admin = driver.FindElement(By.Id("menu_admin_viewAdminModule"));
            Actions action = new Actions(driver);
            action.MoveToElement(Admin).Perform();
            action.MoveToElement(driver.FindElement(By.Id("menu_admin_UserManagement"))).Perform();
            // click on User
            driver.FindElement(By.Id("menu_admin_viewSystemUsers")).Click();

        }
    }
}