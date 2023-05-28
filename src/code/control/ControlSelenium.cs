using OpenQA.Selenium;
using SeleniumTraining.src.code.factoryBrowser;
using SeleniumTraining.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator) 
        {
            this.locator = locator;
        }

        protected void FindControl() 
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click() 
        { 
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public void applyStyle(string element, string style)
        {
            IWebElement divElement = Session.Instance().GetBrowser().FindElement(By.XPath(element));
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Session.Instance().GetBrowser();
            jsExecutor.ExecuteScript(style, divElement);
        }
    }
}
