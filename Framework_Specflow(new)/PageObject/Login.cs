using Framework_Specflow_new_.BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.PageObject
{
    public class Login :PageBase
        
    {

        //IWebDriver driver; // not used yet
        public Login(IWebDriver _driver): base (_driver)
        {
            //this.driver = _driver;  // not used yet
        }

        [FindsBy(How = How.Id, Using = "login2")]
        private IWebElement LoginLink;
        
        [FindsBy(How = How.Id, Using = "loginusername")]
        private IWebElement Username;

        [FindsBy(How = How.Id, Using = "loginpassword")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = " //button[contains(text(),'Log in')]")]
        private IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='logInModal']/div[1]/div[1]/div[3]/button[1]")]
        private IWebElement CloseBtn;

        public void Loginlink()
        {
            LoginLink.Click();
        }
        public void LoginDetials(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();            
        }
    }


}
