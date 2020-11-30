using Bilyoner.Entities;
using Bilyoner.PageModel;
using Bilyoner.Service;
using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Bilyoner.Test
{
    
    [TestFixture]
    [Binding, Scope(Feature = "Bilyoner")]
    public class BilyonerTest
    {
        public IWebDriver webDriver;
        public WebDriverService webDriverService;
        public HomePage homePage;
        public FootballPage footballPage;
        private string driverPath = string.Empty;
        public BetSlipEntity betSlipEntity;
        public MyBetSlipsPage MyBetSlipsPage;


        public BilyonerTest()
        {
            driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            webDriverService = new WebDriverService();
            betSlipEntity = new BetSlipEntity();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }

        [StepDefinition(@"'(.*)' driver ile browser acilir")]
        public void OpenBrowser(string requestedDriver){
            
            switch (requestedDriver) {
                case "Chrome": { webDriver = webDriverService.SetWebDriverAsChrome(driverPath);  break; }
                case "Firefox": { webDriver = webDriverService.SetWebDriverAsFirefox(driverPath); break; }
                case "InternetExplorer": { webDriver = webDriverService.SetWebDriverAsInternetExplorer(driverPath); break; }
            }
            homePage = new HomePage(webDriver);
            footballPage = new FootballPage(webDriver);
            MyBetSlipsPage = new MyBetSlipsPage(webDriver);
        }

        [StepDefinition(@"Bilyoner sitesine gidilir")]
        public void OpenTrendyol()
        {
            webDriver.Navigate().GoToUrl("https://www.bilyoner.com/");
        }      

        [StepDefinition(@"Giris yap butonuna tiklanir")]
        public void ClickLoginButton()
        {
            homePage.ClickLoginButton();
        }

        [StepDefinition(@"TC Kimlik numarasi alanina '(.*)' girilir")]
        public void SetCitizenshipNumber(long citizenshipNumber)
        {
            homePage.SetCitizenshipNumber(citizenshipNumber.ToString());
        }

        [StepDefinition(@"Sifre alanina '(.*)' girilir")]
        public void SetPassword(string password)
        {
            homePage.SetPassword(password);
        }

        [StepDefinition(@"Giris yap butonuna tiklanarak kullanici girisi yapilir")]
        public void ClickLogonButton()
        {
            homePage.ClickLogonButton();
        }

        [StepDefinition(@"Futbol basligina tiklanir")]
        public void ClickFootballBulletin()
        {
            homePage.ClickLblFootballBulletin();
        }

        [StepDefinition(@"Ustten ilk '(.*)' maca bahis yapilir")]
        public void BetFootballMatches(int bettedMatchCount)
        {            
            betSlipEntity.BettedMatchCount = bettedMatchCount;
            footballPage.BetMatch(bettedMatchCount);
            betSlipEntity.BettedMatchesList = footballPage.GetBettedMatchName(bettedMatchCount);
        }

        [StepDefinition(@"Bahis Kuponuna tiklanir")]
        public void ClickBetSlip()
        {
            footballPage.ClickBetSlip();
        }

        [StepDefinition(@"Bahis kuponunda kaydet butonuna tiklanir")]
        public void ClickButtonSaveMyBetSlip()
        {
            footballPage.ClickButtonSaveBetSlip();
        }

        [StepDefinition(@"Kuponlarım secenegine tiklanir")]
        public void ClickMyBetSlips()
        {
            footballPage.ClickButtonMyBetSlips();
        }

        [StepDefinition(@"Bahis yapilan maclar ile kupondaki maclarin ayni oldugu gorulur")]
        public void CompareBettedMatchesAndBettedMatchesInMyBetSlips()
        {
            betSlipEntity.BettedMatchesListInMyBetSlips = MyBetSlipsPage.GetBettedMatchesListInMyBetSlips(betSlipEntity.BettedMatchCount);
            for(int matchCount=0; matchCount < betSlipEntity.BettedMatchCount; matchCount++)
            {
                Assert.AreEqual(betSlipEntity.BettedMatchesList[matchCount], betSlipEntity.BettedMatchesListInMyBetSlips[matchCount], betSlipEntity.BettedMatchesList[matchCount] + " ile " + betSlipEntity.BettedMatchesListInMyBetSlips[matchCount] + " maclari ayni degildir!");
            }            
        }

        [StepDefinition(@"Kupon silinir")]
        public void DeleteBetSlip()
        {
            MyBetSlipsPage.ClickButtonsDelete();
        }
    }
}