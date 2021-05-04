using Marsinternship.SpecflowPages;
using Marsinternship.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Marsinternship.Stepdefinitions
{
    [Binding]
    public class SigninSteps:Commondriver
    {
        [Given(@"enter the account details")]
        public void GivenEnterTheAccountDetails()
        {
            LoginPage lp = new LoginPage();
            lp.CreateAccount(driver);
        }
        
        [Given(@"enter the username and password")]
        public void GivenEnterTheUsernameAndPassword()
        {
            LoginPage lp = new LoginPage();
            lp.Login(driver);
        }
    }
}
