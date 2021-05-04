using Marsinternship.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marsinternship.SpecflowPages
{
    public class LoginPage
    {
         
        
            public void CreateAccount(IWebDriver driver)
            {

                //Launch up the portal 
                driver.Navigate().GoToUrl("http://localhost:5000");
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);

                //click on join button
                Wait.WaitForWebElementClickable(driver, "Xpath", "//button[normalize-space()='Join']");
                IWebElement Join = driver.FindElement(By.XPath("//button[normalize-space()='Join']"));
                Join.Click();

                //enter the account details
                Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "login");

                IWebElement fname = driver.FindElement(By.XPath("//input[@placeholder='First name']"));
                fname.SendKeys(Excellibhelper.ReadData(2, "firstname"));
                Thread.Sleep(500);

                IWebElement lname = driver.FindElement(By.XPath("//input[@placeholder='Last name']"));
                lname.SendKeys(Excellibhelper.ReadData(2, "lastname"));
                Thread.Sleep(500);

                Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\Excel (2).xlsx", "login");
                IWebElement email = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
                email.SendKeys(Excellibhelper.ReadData(2, "username"));
                Thread.Sleep(500);

                IWebElement psword = driver.FindElement(By.XPath("//input[@placeholder='Password']"));
                psword.SendKeys(Excellibhelper.ReadData(2, "password"));
                Thread.Sleep(500);

                IWebElement confirmpsword = driver.FindElement(By.XPath("//input[@placeholder='Confirm Password']"));
                confirmpsword.SendKeys(Excellibhelper.ReadData(2, "password"));
                Thread.Sleep(500);

                //click on checkbox
                Wait.WaitForWebElementClickable(driver, "Xpath", "//input[@name='terms']");
                IWebElement checkbox = driver.FindElement(By.XPath("//input[@name='terms']"));
                checkbox.Click();
                //click on join
                IWebElement join = driver.FindElement(By.XPath("//div[@id='submit-btn']"));
                join.Click();
                Thread.Sleep(500);


            }




            public void Login(IWebDriver driver)
            {

                //Launch up the portal 
                driver.Navigate().GoToUrl("http://localhost:5000");
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);



                //Click on Sign in button

                Wait.WaitForWebElementClickable(driver, "Xpath", "//a[normalize-space()='Sign In']");
                IWebElement Signin = driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
                Signin.Click();



                Excellibhelper.PopulateInCollection("C:\\Users\\nikhi\\Desktop\\Desktop\\VS Projects\\ProjectMARS\\TestData\\ExcelData.xlsx", "login");

                //Enter Username

                IWebElement Username = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
                Username.SendKeys(Excellibhelper.ReadData(2, "username"));
                Thread.Sleep(500);

                //Enter Password

                IWebElement Password = driver.FindElement(By.XPath("//input[@placeholder='Password']"));
                Username.SendKeys(Excellibhelper.ReadData(2, "password"));
                Thread.Sleep(500);

                //Click on login button
                IWebElement Loginbutton = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
                Loginbutton.Click();
                Thread.Sleep(1000);





            }

            internal void LoginSteps(IWebDriver driver)
            {
                throw new NotImplementedException();
            }
        }
    }









