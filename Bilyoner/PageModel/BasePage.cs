using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace Bilyoner.PageModel
{
    public class BasePage
    {
        private IWebDriver webDriver;
        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(webDriver, this);
        }

        public IWebElement Find(By by)
        {
            return webDriver.FindElement(by);
        }

        public void Click(IWebElement btn)
        {            
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btn));
            btn.Click();
        }       

        public void SetText(IWebElement txt, string text)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(txt));
            txt.SendKeys(text);
        } 

        public IJavaScriptExecutor GetScriptExecutor()
        {
            return (IJavaScriptExecutor)webDriver;
        }

        public void DismissModalAlert(){
            IAlert alert = webDriver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public void InitElements(object elementLocator)
        {
            PageFactory.InitElements(webDriver, elementLocator);
        }

        public void CloseBrowser()
        {
            webDriver.Quit();
        }

        public void WaitStatically(int second)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(second);

        }
    }
}