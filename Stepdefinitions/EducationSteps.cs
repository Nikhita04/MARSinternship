using Marsinternship.SpecflowPages;
using Marsinternship.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Marsinternship.Stepdefinitions
{
    [Binding]
    public class EducationSteps:Commondriver
    {
        [Given(@"enter the education details")]
        public void GivenEnterTheEducationDetails()
        {
            EducationPage ep = new EducationPage();
            ep.Education(driver);

        }

        [Then(@"add and update or delete the existing skill")]
        public void ThenAddAndUpdateOrDeleteTheExistingSkill()
        {
            EducationPage ep = new EducationPage();
            ep.Educationedit(driver);
        }
    }
}
