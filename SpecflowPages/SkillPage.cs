using Marsinternship.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marsinternship.SpecflowPages
{
    class SkillPage
    {
        public void Skills(IWebDriver driver)
        {

            Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "skills");
            //click on skill button
            IWebElement skill = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skill.Click();
            Thread.Sleep(500);
            //enter the skills
            IWebElement addskill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']]"));
            addskill.SendKeys(Excellibhelper.ReadData(2, "skill"));
            Thread.Sleep(500);
            //select the skill level
            IWebElement skilllevel = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            skilllevel.Click();
            Thread.Sleep(500);
            IWebElement clickadd = driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Add']"));
            clickadd.Click();
            Thread.Sleep(500);

            IWebElement cancelskill = driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Cancel']"));
            cancelskill.Click();
            Thread.Sleep(500);

            //check if the Skill is displayed

            if (driver.FindElement(By.XPath("//input[@placeholder='Add Skill']]")).Text == "Painting")

            {
                Assert.Pass("Skill is displayed,test passed");
            }

            else
            {
                Assert.Fail("Skill is not displayed,test failed");

            }






        }

        public void SkillEdit(IWebDriver driver)
        {
            //edit skill, update and delete 

            IWebElement editskill = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            editskill.Click();
            Thread.Sleep(500);

            IWebElement updateskill = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateskill.Click();
            Thread.Sleep(500);

            IWebElement skillCancel = driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Cancel']"));
            skillCancel.Click();
            Thread.Sleep(500);

            IWebElement deleteskill = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteskill.Click();
            Thread.Sleep(500);





        }




    }
}

    

