﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bilyoner.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Bilyoner")]
    public partial class BilyonerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Bilyoner.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Bilyoner", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
testRunner.And("\'Chrome\' driver ile browser acilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BilyonerKuponKontrolu")]
        public virtual void BilyonerKuponKontrolu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BilyonerKuponKontrolu", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 9
 testRunner.And("Bilyoner sitesine gidilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 10
 testRunner.And("Giris yap butonuna tiklanir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 11
 testRunner.And("TC Kimlik numarasi alanina \'12345678912\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 12
 testRunner.And("Sifre alanina \'password\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 13
 testRunner.And("Giris yap butonuna tiklanarak kullanici girisi yapilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 14
 testRunner.And("Futbol basligina tiklanir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 15
 testRunner.And("Ustten ilk \'3\' maca bahis yapilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 16
 testRunner.And("Bahis Kuponuna tiklanir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 17
 testRunner.And("Bahis kuponunda kaydet butonuna tiklanir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 18
 testRunner.And("Kuponlarım secenegine tiklanir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 19
 testRunner.And("Bahis yapilan maclar ile kupondaki maclarin ayni oldugu gorulur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 20
 testRunner.And("Kupon silinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

