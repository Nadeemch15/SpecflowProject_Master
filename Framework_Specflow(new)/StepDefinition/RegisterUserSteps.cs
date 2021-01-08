using Framework_Specflow_new_.PageObject;
using Framework_Specflow_new_.Settings;
using System;
using TechTalk.SpecFlow;

namespace Framework_Specflow_new_.StepDefinition
{
    [Binding]
    public class RegisterUserSteps
    {
        RegisterUser Register;
        public RegisterUserSteps()
        {
            Register = new RegisterUser(ObjectRepository.Driver);
        }

      

        [Given(@"I am on Demoblase websit ""(.*)""")]
        public void GivenIAmOnDemoblaseWebsit(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        [Given(@"I click Sing up link")]
        public void GivenIClickSingUpLink()
        {
            Register.SignUp();
        }
        
        [When(@"I enter user detials (.*) (.*) and click Sign up button")]
        public void WhenIEnterUserDetialsAndClickSignUpButton(string username, string password)
        {
            Register.UserDetails(username, password);
        }
        
        //[Then(@"user created successflly")]
        //public void ThenUserCreatedSuccessflly()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
