using Marsinternship.SpecflowPages;
using Marsinternship.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Marsinternship.Stepdefinitions
{
    [Binding]
    public class LanguageSteps:Commondriver
    {
      

        [Given(@"enter the languages")]
        public void GivenEnterTheLanguages()
        {
            LanguagePage p = new LanguagePage();
            p.Languages(driver);

        }

        [Then(@"Add and update or delete the existing languages")]
        public void ThenAddAndUpdateOrDeleteTheExistingLanguages()
        {
            LanguagePage le = new LanguagePage();
            le.LangEdit(driver);
        }
    }
    }

