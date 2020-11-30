using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Bilyoner.PageModel
{
    public class HomePage : BasePage
    {        
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {            
        } 

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn btn-login']")]
        public IWebElement BtnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn btn--primary btn--block']")]
        public IWebElement BtnLogon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='sub-menu__item' and @href='/iddaa/futbol']")]
        public IWebElement LblFootballBulletin { get; set; }        

        public void ClickLoginButton()
        {
            Click(BtnLogin);
        }       

        public void SetCitizenshipNumber(string citizenshipNumber)
        {
            SetText(TxtUserName, citizenshipNumber);
        }

        public void SetPassword(string password)
        {
            SetText(TxtPassword, password);
        }

        public void ClickLogonButton()
        {
            Click(BtnLogon);
        }

        public void ClickLblFootballBulletin()
        {
            Click(LblFootballBulletin);
        }
    }
}