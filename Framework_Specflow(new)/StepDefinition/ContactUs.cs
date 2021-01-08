using Framework_Specflow_new_.PageObject;
using Framework_Specflow_new_.Settings;
using System;
using TechTalk.SpecFlow;

namespace Framework_Specflow_new_.StepDefinition
{
    [Binding]
    public class ContactUsSteps
    {
        ContactUs Contact;
        public ContactUsSteps()
        {
            Contact = new ContactUs(ObjectRepository.Driver);
        }

        [Given(@"I am on WebSite ""(.*)""")]
        public void GivenIAmOnWebSite(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        [Given(@"I click Contact us link")]
        public void GivenIClickContactUsLink()
        {
            Contact.ClickContactLink();
        }
        [When(@"I provide the test(.*) (.*) and click Send message button")]
        public void WhenIProvideTheAndClickSendMessageButton(string Email, string Name)
        {
            Contact.MessageDetail(Email, Name);
        }


        //[When(@"I provide the (.*) (.*) (.*) and click Send message button")]
        //public void WhenIProvideTheAndClickSendMessageButton(string Email, string Name, string Message)
        //{
        //    Contact.MessageDetail(Email, Name, Message);
        //}
        
        [Then(@"message is sent")]
        public void ThenMessageIsSent()
        {
            Contact.MessageSent();
        }
    }
}
