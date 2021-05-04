using Marsinternship.SpecflowPages;
using Marsinternship.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Marsinternship.Stepdefinitions
{
    [Binding]
    public class ProfileSteps:Commondriver
    {
        [Given(@"enter the fullname")]
        public void GivenEnterTheFullname()
        {
            driver = new ChromeDriver();
            ProfilePage p = new ProfilePage();
            p.ProfileName(driver);
        }
        
        [Given(@"enter the availability,target and hour")]
        public void GivenEnterTheAvailabilityTargetAndHour()
        {
            ProfilePage p = new ProfilePage();
            p.Profiledetails(driver);
        }
        
        [Given(@"enter the profile descriptions")]
        public void GivenEnterTheProfileDescriptions()
        {

            ProfilePage p = new ProfilePage();
            p.Description(driver);
        }
    }
    }

