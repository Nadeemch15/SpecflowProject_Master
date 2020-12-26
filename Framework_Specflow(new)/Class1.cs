using Framework_Specflow_new_.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void Test1()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());

        }
    }
}
