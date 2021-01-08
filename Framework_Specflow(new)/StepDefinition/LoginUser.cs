using Framework_Specflow_new_.PageObject;
using Framework_Specflow_new_.Settings;
using System;
using TechTalk.SpecFlow;

namespace Framework_Specflow_new_.StepDefinition
{
    [Binding]
    public class LoginUser
        
    {
        Login lg;
        public LoginUser()
        {
            lg = new Login(ObjectRepository.Driver);
        }

        [Given(@"I am on Demoblase ""(.*)""")]
        public void GivenIAmOnDemoblase(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
            ObjectRepository.Driver.Manage().Window.Maximize();

        }
        [Given(@"user click Login link")]
        public void GivenUserClickLoginLink()
        {
            lg.Loginlink();
        }

            
        
        [When(@"I enter Login detials (.*) (.*) and click Login button")]
        public void WhenIEnterLoginDetialsTestAndClickLoginButton(string username, string password)
        {
            lg.LoginDetials(username, password);
            
        }
    }
}
