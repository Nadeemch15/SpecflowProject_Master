using Framework_Specflow_new_.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.BasePage
{
    public class PageBase
    {
        //private IWebDriver driver; // not used yet
        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(ObjectRepository.Driver, this);            
        }
        public void ImplicitWait()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
