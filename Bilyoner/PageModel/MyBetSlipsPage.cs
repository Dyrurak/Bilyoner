using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Bilyoner.PageModel
{
    public class MyBetSlipsPage : BasePage
    {
        public MyBetSlipsPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='coupon-row__participants']")]
        public IList<IWebElement> LblBettedMacthesListInMyBetSlips { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon ic_trash coupon-row__header__trash'])[1]")]
        public IWebElement BtnDelete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn--primary btn--half-round-group']")]
        public IWebElement BtnDeleteOption { get; set; }        


        public List<string> GetBettedMatchesListInMyBetSlips(int bettedMatchCount)
        {
            string bettedMatch = string.Empty;
            string editedbettedMatch = string.Empty;            
            List<string> bettedMatchesListInMyBetSlips = new List<string>();
            for (int count = 0; count < bettedMatchCount; count++)
            {
                bettedMatch = LblBettedMacthesListInMyBetSlips[count].Text;
                editedbettedMatch = bettedMatch.Replace("\r\n", " ");                
                bettedMatchesListInMyBetSlips.Add(editedbettedMatch);
            }
            return bettedMatchesListInMyBetSlips;
        }

        public void ClickButtonsDelete()
        {
            Click(BtnDelete);
            Click(BtnDeleteOption);
        }
    }
}