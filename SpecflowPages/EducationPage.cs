using Marsinternship.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marsinternship.SpecflowPages
{
    public class EducationPage
    {
        public void Education(IWebDriver driver)
        {
            Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "education");
            //click on Education button
            IWebElement edu = driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
            edu.Click();
            Thread.Sleep(500);

            //add the new education details
            IWebElement addedu = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            addedu.Click();
            Thread.Sleep(500);

            IWebElement college = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
            college.SendKeys(Excellibhelper.ReadData(2, "University"));
            Thread.Sleep(500);

            IWebElement country = driver.FindElement(By.XPath("//option[@value='India']"));
            country.Click();
            Thread.Sleep(500);


            IWebElement title = driver.FindElement(By.XPath("//option[@value='B.Tech']"));
            title.Click();
            Thread.Sleep(500);

            IWebElement degree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            degree.SendKeys(Excellibhelper.ReadData(2, "Degree"));
            Thread.Sleep(500);

            IWebElement year = driver.FindElement(By.XPath("  //option[@value='2016']"));
            year.SendKeys(Excellibhelper.ReadData(2, "Graduation Year"));
            Thread.Sleep(500);

            IWebElement addingedu = driver.FindElement(By.XPath("//input[@value='Add']"));
            addingedu.Click();
            Thread.Sleep(500);

            IWebElement canceledu = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            canceledu.Click();
            Thread.Sleep(500);


        }

        internal void Education(object driver)
        {
            throw new NotImplementedException();
        }

        public void Educationedit(IWebDriver driver)
        {
            //edit the existing education details, update and delete 

            IWebElement editedu = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[1]/i[1]"));
            editedu.Click();
            Thread.Sleep(500);

            IWebElement eduupdate = driver.FindElement(By.XPath("//input[@value='Update']"));
            eduupdate.Click();
            Thread.Sleep(500);

            IWebElement eduCancel = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            eduCancel.Click();
            Thread.Sleep(500);

            IWebElement deleteedu = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[2]/i[1]"));
            deleteedu.Click();
            Thread.Sleep(500);







        }
    }
}
    

