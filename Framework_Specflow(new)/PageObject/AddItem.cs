using Framework_Specflow_new_.BasePage;
using Framework_Specflow_new_.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace Framework_Specflow_new_.PageObject
{
    public class AddItem : PageBase

    {
        public AddItem(IWebDriver driver): base (driver)
        {

        }
        [FindsBy(How = How.LinkText, Using = "Monitors")]
        private IWebElement MonitorLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Apple monitor 24')]")]
        private IWebElement AppleMonitorLink;

        [FindsBy(How = How.LinkText, Using = "Add to cart")]
        private IWebElement Addtocart;

        // Assert

        [FindsBy(How = How.LinkText, Using = "Cart")]
        private IWebElement CartTab;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Apple monitor 24')]")]
        private IWebElement VerifiyMonitor;

        public void AddMonitor()
        {
            MonitorLink.Click();
            //Actions action = new Actions(ObjectRepository.Driver);
            //action.MoveToElement(AppleMonitorLink).Perform();
            ImplicitWait();
            AppleMonitorLink.Click();
            Addtocart.Click();
        }

        public void MonitorDisplayed()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            //var text = alert.Text;
            Console.WriteLine(alert.Text);
            alert.Accept();
        }
        public void verifiyItem()
        {
            CartTab.Click();
            Assert.AreEqual(VerifiyMonitor.Text, "Apple monitor 24");
            Console.WriteLine("Monitor displayed : " + VerifiyMonitor.Text);
        }
    }
}
