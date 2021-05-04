using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marsinternship.Utilities
{
    class Wait
    {
        //custom method to handle wait for a webelement to be visible
        public static void WaitForWebElementVisiblity(IWebDriver driver, string locator, string locatorvalue)
        {
            try
            {
                if (locator == "XPath")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
                }

                if (locator == "Id")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));
                }

                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(locatorvalue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed waiting for an webelement", ex.Message);
            }

        }


        //custom method to handle wait for a webelement to be clickable
        public static void WaitForWebElementClickable(IWebDriver driver, string locator, string locatorvalue)
        {
            try
            {
                if (locator == "XPath")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
                }

                if (locator == "Id")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
                }

                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(locatorvalue)));
                }
            }
            catch (Exception msg)
            {
                Assert.Fail(msg.Message);
            }

        }
    }
}






    
