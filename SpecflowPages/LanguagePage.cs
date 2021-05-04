using Marsinternship.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marsinternship.SpecflowPages
{
    class LanguagePage
    {
        public void Languages(IWebDriver driver)
        {

            Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "language");
            //enter the languages
            IWebElement lang = driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));
            lang.Click();
            Thread.Sleep(500);

            IWebElement addnew = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addnew.SendKeys(Excellibhelper.ReadData(2, "languages"));
            Thread.Sleep(500);

            IWebElement langlevel = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            langlevel.Click();
            Thread.Sleep(500);

            IWebElement addlang = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            addlang.Click();

            IWebElement cancellang = driver.FindElement(By.XPath("//div[@class='six wide field']//input[@value='Cancel']"));
            cancellang.Click();
            Thread.Sleep(500);
            //check if the language is displayed

            if (driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Text == "Hindi")

            {
                Assert.Pass("Language is displayed,test passed");
            }

            else
            {
                Assert.Fail("Language is not displayed,test failed");

            }

        }

        public void LangEdit(IWebDriver driver)
        {

            // Edit and update the existing language or delete
            IWebElement editlan = driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            editlan.Click();
            Thread.Sleep(500);

            IWebElement updatelan = driver.FindElement(By.XPath("//input[@value='Update']"));
            updatelan.Click();
            Thread.Sleep(500);

            IWebElement langCancel = driver.FindElement(By.XPath("//tbody//input[@value='Cancel']"));
            langCancel.Click();
            Thread.Sleep(500);

            IWebElement deletelan = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            deletelan.Click();
            Thread.Sleep(500);

        }





    }
}
