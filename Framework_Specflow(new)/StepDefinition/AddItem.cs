using Framework_Specflow_new_.PageObject;
using Framework_Specflow_new_.Settings;
using System;
using TechTalk.SpecFlow;

namespace Framework_Specflow_new_.StepDefinition
{
    [Binding]
    public class AddItemSteps
    {
        AddItem item;
        public AddItemSteps()
        {
            item = new AddItem(ObjectRepository.Driver);
        }

        [Given(@"I am on DemoWebsite ""(.*)""")]
        public void GivenIAmOnDemoWebsite(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        [When(@"I click Montors and add to cart")]
        public void WhenIClickMontorsAndAddToCart()
        {
            item.AddMonitor();
            item.MonitorDisplayed();
        }
        
        [Then(@"monitor is add in the Cart")]
        public void ThenMonitorIsAddInTheCart()
        {
            item.verifiyItem();
        }
    }
}
