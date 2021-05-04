using Marsinternship.SpecflowPages;
using Marsinternship.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Marsinternship.Stepdefinitions
{
    [Binding]
    public class SkillsSteps:Commondriver
    {
        [Given(@"enter the skills")]
        public void GivenEnterTheSkills()
        {
            SkillPage s = new SkillPage();
            s.Skills(driver);
        }
        
        [Then(@"add and update or delete the existing skills")]
        public void ThenAddAndUpdateOrDeleteTheExistingSkills()
        {
            SkillPage s = new SkillPage();
            s.SkillEdit(driver);
        }
    }
    }

