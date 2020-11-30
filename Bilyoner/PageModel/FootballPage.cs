using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Bilyoner.PageModel
{
    public class FootballPage : BasePage
    {
        public FootballPage(IWebDriver webDriver) : base (webDriver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='event-row-prematch-v2__header']//span")]
        public IList<IWebElement> LblMatchList { get; set; }        

        [FindsBy(How = How.XPath, Using = "//*[@class='odd__value']")]
        public IList<IWebElement> BtnBetValueList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='atrium-value']")]
        public IWebElement BtnBetSlip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='icon ic_save betslip__header__save']")]
        public IWebElement BtnSaveBetSlip { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn--outline btn--half-round']")]
        public IWebElement BtnMyBetSlips { get; set; }

        public List<string> GetBettedMatchName(int matchCount)
        {
            string bettedMatch = string.Empty;
            List<string> bettedMatchesList = new List<string>();
            
            for(int count=0; count<matchCount; count++)
            {
                bettedMatch = LblMatchList[count].Text;                
                bettedMatchesList.Add(bettedMatch);
            }
            return bettedMatchesList;
        }

        public void BetMatch(int matchCount)
        {
            WaitStatically(4);
            for (int index = 0; index < matchCount * 6; index=index+6) {
                if(BtnBetValueList[index].Text == string.Empty)
                {
                    Click(BtnBetValueList[index + 1]);
                }
                else
                {
                    Click(BtnBetValueList[index]);
                }
            }
        }

        public void ClickBetSlip()
        {
            Click(BtnBetSlip);
        }

        public void ClickButtonSaveBetSlip()
        {
            Click(BtnSaveBetSlip);
        }

        public void ClickButtonMyBetSlips()
        {
            Click(BtnMyBetSlips);
        }
    }
}