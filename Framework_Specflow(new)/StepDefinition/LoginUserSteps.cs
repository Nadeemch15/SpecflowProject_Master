using Framework_Specflow_new_.PageObject;
using Framework_Specflow_new_.Settings;
using System;
using TechTalk.SpecFlow;

namespace Framework_Specflow_new_.StepDefinition
{
    [Binding]
    public class LoginUserSteps
    {
        LoginUser login;
        public LoginUserSteps()
        {
            login = new LoginUser(ObjectRepository.Driver);
        }
        [Given(@"I am on login page")]
        public void GivenIAmOnLoginPage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        [When(@"User entere the login details (.*) (.*)")]
        public void WhenUserEntereTheLoginDetails(string email, string password)
        {
            login.Login(email, password);
        }
      
        [Then(@"User logged in successfully")]
        public void ThenUserLoggedInSuccessfully()
        {
            login.Verify_User();
        }


    }
}
