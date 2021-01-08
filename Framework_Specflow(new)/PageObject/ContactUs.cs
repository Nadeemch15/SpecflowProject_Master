using Framework_Specflow_new_.BasePage;
using Framework_Specflow_new_.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.PageObject
{
    public class ContactUs : PageBase
    {
        public ContactUs(IWebDriver _driver) :base (_driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//a[text()='Contact']")]
        private IWebElement ContactLink;

        [FindsBy(How = How.Id, Using = "recipient-email")]
        private IWebElement ContactEmail;

        [FindsBy(How = How.Id, Using = "recipient-name")]
        private IWebElement ContactName;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Send message')]")]
        private IWebElement MessageBtn;

        [FindsBy(How = How.Id, Using = "message-text")]
        private IWebElement Message;

        [FindsBy(How = How.Id, Using = "")]
        private IWebElement CloseBtn;

        public void ClickContactLink()
        {
            ContactLink.Click();
        }
        public void MessageDetail(string email, string name)
        {
            ContactEmail.SendKeys(email);
            ContactName.SendKeys(name);
            Message.SendKeys("This is master branch");
            ImplicitWait();
            

            MessageBtn.Click();

        }

        public void MessageSent()
        {
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            var text = alert.Text;
            Console.WriteLine(text);
            alert.Accept();
        }

    }
}
