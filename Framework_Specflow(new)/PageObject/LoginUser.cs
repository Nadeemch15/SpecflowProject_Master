using Framework_Specflow_new_.BasePage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.PageObject
{
    public class LoginUser : PageBase
    {
        IWebDriver driver;
        public LoginUser(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Webelement
        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement SignInLink;


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement Password;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement SignInButton;

        [FindsBy(How = How.XPath, Using = "my-account")]
        private IWebElement MyAccount;

        [FindsBy(How = How.ClassName, Using = "account")]
        public IWebElement VerifyUser { get; set; }
     

        #endregion


        #region Action
        public void Login(string email, string password)
        {
            SignInLink.Click();
            Email.SendKeys(email);
            Password.SendKeys(password);
            SignInButton.Click();
        }

        public void Verify_User()
        {
            Assert.AreEqual("Asif khan", VerifyUser.Text);
            Console.WriteLine(VerifyUser.Text + " Displayed");
        }

        #endregion
    }
}
