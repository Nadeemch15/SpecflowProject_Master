using Framework_Specflow_new_.BasePage;
using Framework_Specflow_new_.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.PageObject
{
    public class RegisterUser :PageBase
    {
        IWebDriver driver;
        public RegisterUser(IWebDriver _driver) : base (_driver)
        {
            this.driver = _driver;
        }
        #region Element
        [FindsBy(How = How.LinkText, Using = "Sign up")]
        private IWebElement SignUpLink;

        [FindsBy(How = How.Id, Using = "sign-username")]
        private IWebElement UserName;

        [FindsBy(How = How.Id, Using = "sign-password")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Sign up')]")]
        private IWebElement SignUpBtn;

        [FindsBy(How = How.ClassName, Using = "btn btn-secondary")]
        private IWebElement CloseBtn;
        #endregion

        #region Action
        public void SignUp()
        {
            SignUpLink.Click();
        }
        public void UserDetails(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            SignUpBtn.Click();
        }

        public void verification()
        {
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            var text = alert.Text;
            Console.WriteLine(text);
            alert.Accept();
        }
        #endregion
    }
}
