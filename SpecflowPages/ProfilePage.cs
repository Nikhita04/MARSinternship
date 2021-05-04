using Marsinternship.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marsinternship.SpecflowPages
{
    public class ProfilePage
    {
        public void ProfileName(IWebDriver driver)
        {

            Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "profile");

            //enter the name 
            IWebElement name = driver.FindElement(By.XPath("//div[@class='title']//i[@class='dropdown icon']"));
            name.Click();
            Thread.Sleep(500);
            IWebElement fname = driver.FindElement(By.XPath("//input[@name='firstName']"));
            fname.SendKeys(Excellibhelper.ReadData(2, "firstname"));
            Thread.Sleep(500);

            IWebElement lname = driver.FindElement(By.XPath("//input[@name='lastName']"));
            lname.SendKeys(Excellibhelper.ReadData(2, "lastname"));
            Thread.Sleep(500);
            //save the name
            IWebElement savename = driver.FindElement(By.XPath("//button[normalize-space()='Save']"));
            savename.Click();
            Thread.Sleep(500);

            //To check if the Profile name is displayed

            if (driver.FindElement(By.XPath("//div[@class='ui fluid accordion']//div[@class='content']")).Text == "Nikhita NJ")

            {
                Assert.Pass("Name is displayed,test passed");
            }

            else
            {
                Assert.Fail("Name is not displayed,test failed");

            }






        }
        public void Profiledetails(IWebDriver driver)
        {
            //enter Availability
            IWebElement availability = driver.FindElement(By.XPath("//div[@class='four wide column']//div[2]//div[1]//span[1]//i[1]"));
            availability.Click();
            Thread.Sleep(500);
            IWebElement selectavail = driver.FindElement(By.XPath("//option[@value='0']"));
            selectavail.Click();
            Thread.Sleep(500);
            //remove the selection
            IWebElement remove1 = driver.FindElement(By.XPath("//span[normalize-space()='Part Time']//i[@class='right floated outline small write icon']"));
            remove1.Click();
            Thread.Sleep(500);

            //enter target
            IWebElement target = driver.FindElement(By.XPath("//div[@class='four wide column']//div[4]//div[1]//span[1]//i[1]"));
            target.Click();
            Thread.Sleep(500);
            IWebElement selecttarget = driver.FindElement(By.XPath("//option[@value='1']"));
            selecttarget.Click();
            Thread.Sleep(500);
            //remove the selection
            IWebElement remove3 = driver.FindElement(By.XPath("//span[normalize-space()='Between $500 and $1000 per month']//i[@class='right floated outline small write icon']"));
            remove3.Click();
            Thread.Sleep(500);


            //enter number of hours

            IWebElement hours = driver.FindElement(By.XPath("//span[normalize-space()='Less than 30hours a week']//i[@class='right floated outline small write icon']"));
            hours.Click();
            Thread.Sleep(500);
            IWebElement selecthours = driver.FindElement(By.XPath("//span[normalize-space()='Less than 30hours a week']"));
            selecthours.Click();
            Thread.Sleep(500);
            //remove selection
            IWebElement remove2 = driver.FindElement(By.XPath("//div[@class='extra content']//div[3]//div[1]//span[1]//i[1]"));
            remove2.Click();
            Thread.Sleep(500);
        }

        public void Description(IWebDriver driver)
        {

            Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "profile");
            //enter the description
            IWebElement des = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            des.Click();
            Thread.Sleep(500);

            IWebElement details = driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
            details.SendKeys(Excellibhelper.ReadData(2, "description"));
            Thread.Sleep(500);


            IWebElement Save = driver.FindElement(By.XPath("//button[@type='button']"));
            Save.Click();
            Thread.Sleep(500);

            //check if the description is displayed

            if (driver.FindElement(By.XPath("//span[normalize-space()='I am very artistic and like to paint.']")).Text == "I am very artistic and like to paint.")

            {
                Assert.Pass("Description is displayed,test passed");
            }

            else
            {
                Assert.Fail("Description is not displayed,test failed");

            }

        }






    }
}
