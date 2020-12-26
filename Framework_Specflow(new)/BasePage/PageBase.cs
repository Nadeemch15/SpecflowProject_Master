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
        private IWebDriver driver;
        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
        }
    }
}
