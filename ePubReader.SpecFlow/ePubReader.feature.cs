﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ePubReader.SpecFlow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ePubReader")]
    public partial class EPubReaderFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ePubReader.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ePubReader", "In order to read books\r\nAs a computer user\r\nI want to be able to view the content" +
                    " of an ePub file", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
 testRunner.Given("I have set the file system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get ePub title")]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Building a Release Pipeline with Team Foundation Server 2012 - EPUB.epub", "Building a Release Pipeline with Team Foundation Server 2012", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\CloudDesignPatternsEPUBebook.epub", "Cloud Design Patterns", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\DependencyInjectionWithUnity.epub", "Dependency Injection with Unity", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Deploying an ASP.NET Web Application to a Hosting Provider using Visual S" +
            "tudio.epub", "Deploying an ASP.NET Web Application to a Hosting Provider using Visual Studio", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Deployment-guide-for-SharePoint-2013.epub", "Deployment-guide-for-SharePoint-2013", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Developer\'s Guide to Microsoft Enterprise Library - 2nd Edition.epub", "Developer\'s Guide to Microsoft Enterprise Library, 2nd Edition", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Explore-SharePoint-2013.epub", "Explore-SharePoint-2013", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2011.epub", "Free Nonfiction 2011", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2012.epub", "Free Nonfiction 2012", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2013.epub", "Free Nonfiction 2013", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2014.epub", "Free Nonfiction 2014", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2012.epub", "Free Stories 2012", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2013.epub", "Free Short Stories 2013", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2014.epub", "Free Stories 2014", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Azure_EPUB.epub", "Introducing Windows Azure For IT Professionals", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Microsoft_SQL_Server_2014_EPUB.epub", "Introducing Microsoft SQL Server 2014 Technical Overview", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_System_Center_2012_epub.epub", "Introducing Microsoft System Center 2012 R2", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Windows_ITPro_EPUB.epub", "Introducing Windows 8.1 for IT Professionals", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Windows_Server_2012_R2_EPUB.epub", "Introducing Windows Server 2012 R2 Technical Overview", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_eBook_Programming_Windows_8_Apps_HTML_CSS_JavaScript_2E_E" +
            "PUB.epub", "Programming Windows Store Apps with HTML, CSS, and JavaScript", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_eBook_Rethinking_Enterprise_Storage_A_Hybrid_Cloud_Model_" +
            "EPUB.epub", "Rethinking Enterprise Storage: A Hybrid Cloud Model", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterConfMgrFieldExperience_EPUB.epub", "Microsoft System Center", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterDesigningOrchestratorRunbooks_EPUB.epub" +
            "", "Microsoft System Center Designing Orchestrator Runbooks", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterOptimizingServiceManager_EPUB.epub", "Microsoft System Center Optimizing Service Manager", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_System_Center_Integrated_Cloud_Platform_EPUB.epub", "Microsoftr System Center: Integrated Cloud Platform", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_System_Center_Network_Virtualization_and_Cloud_Computing_EPUB.e" +
            "pub", "Microsoft System Center: Network Virtualization and Cloud Computing", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Prime_Palaver.epub", "Prime Palaver", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Reading_Guides_2013.epub", "Reading Guides 2013", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\SystemCenterBuildingAVirtualizedNetwork_EPUB.epub", "Microsoft System Center", null)]
        public virtual void GetEPubTitle(string filename, string title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get ePub title", exampleTags);
#line 9
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 10
 testRunner.Given(string.Format("an ePub file named \"{0}\"", filename), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When("I open the file using ePubReader", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("the title is \"{0}\"", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get ePub content")]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Building a Release Pipeline with Team Foundation Server 2012 - EPUB.epub", "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?><!DOCTYPE html PUBLIC \"-//W" +
            "3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html dir=" +
            "\"ltr\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xlink=\"http://www.w3.org/1999/x" +
            "link\">  <head>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\CloudDesignPatternsEPUBebook.epub", "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?><!DOCTYPE html PUBLIC \"-//W" +
            "3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html dir=" +
            "\"ltr\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xlink=\"http://www.w3.org/1999/x" +
            "link\">  <head>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\DependencyInjectionWithUnity.epub", "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?><!DOCTYPE html PUBLIC \"-//W" +
            "3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html dir=" +
            "\"ltr\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xlink=\"http://www.w3.org/1999/x" +
            "link\">  <head>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Deploying an ASP.NET Web Application to a Hosting Provider using Visual S" +
            "tudio.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xmlns=\"http://www.w3" +
            ".org/1999/xhtml\"><head><title>Deploying an ASP.NET Web Application to a Hosting " +
            "Provider using", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Deployment-guide-for-SharePoint-2013.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"Microsoft Word 14 (filtered)\" name=\"Generator\"/>    <" +
            "title>Unknown</title>    <meta http-equiv=\"Content-Type\" content=\"text/html; cha" +
            "rset=utf-8\"/>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Developer\'s Guide to Microsoft Enterprise Library - 2nd Edition.epub", "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?><!DOCTYPE html PUBLIC \"-//W" +
            "3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html dir=" +
            "\"ltr\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:xlink=\"http://www.w3.org/1999/x" +
            "link\">  <head>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Explore-SharePoint-2013.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"Microsoft Word 14 (filtered)\" name=\"Generator\"/>    <" +
            "title>Unknown</title>    <meta http-equiv=\"Content-Type\" content=\"text/html; cha" +
            "rset=utf-8\"/>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2011.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta name=\"Author\" content=\"LJOHNSON\"/>    <meta name=\"Generator\" c" +
            "ontent=\"Cocoa HTML Writer\"/>    <meta name=\"CocoaVersion\" content=\"1038.35\"/>   " +
            " <meta content", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2012.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Free Nonfiction 2012</title>    <meta content=\"chc\" name=\"Author\"/>    <meta co" +
            "ntent=\"Cocoa H", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2013.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Baen Books: Free Nonfiction 2013</title>    <meta content=\"Jenny Cunningham\" na" +
            "me=\"Author\"/>", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2014.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Free Nonfiction 2014</title>    <meta content=\"Becky Catchings\" name=\"Author\"/>" +
            "    <meta cont", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2012.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Free Short Stories 2012</title>    <meta content=\"owner\" name=\"Author\"/>    <me" +
            "ta content=\"Mi", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2013.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Unknown</title>    <meta content=\"Jenny Cunningham\" name=\"Author\"/>    <meta co" +
            "ntent=\"Princip", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2014.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Free Stories 2014</title>    <meta content=\"Becky Catchings\" name=\"Author\"/>   " +
            " <meta content", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Azure_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Introducing Windows Azure For IT " +
            "Professionals<", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Microsoft_SQL_Server_2014_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Introducing Microsoft SQL Server " +
            "2014 Technical", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_System_Center_2012_epub.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Introducing Microsoft System Cent" +
            "er 2012 R2</ti", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Windows_ITPro_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Introducing Windows 8.1 for IT Pr" +
            "ofessionals</t", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Windows_Server_2012_R2_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Introducing Windows Server 2012 R" +
            "2 Technical Ov", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_eBook_Programming_Windows_8_Apps_HTML_CSS_JavaScript_2E_E" +
            "PUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Programming Windows Store Apps wi" +
            "th HTML, CSS,", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_eBook_Rethinking_Enterprise_Storage_A_Hybrid_Cloud_Model_" +
            "EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?><!DOCTYPE html><html xmlns=" +
            "\"http://www.w3.org/1999/xhtml\" xmlns:epub=\"http://www.idpf.org/2007/ops\" xmlns:m" +
            "=\"http://www.w3.org/1998/Math/MathML\" xmlns:pls=\"http://www.w3.org/2005/01/pronu" +
            "nciation-lexic", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterConfMgrFieldExperience_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Microsoft System Center</title><l" +
            "ink rel=\"style", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterDesigningOrchestratorRunbooks_EPUB.epub" +
            "", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Microsoft System Center Designing" +
            " Orchestrator", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterOptimizingServiceManager_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Microsoft System Center</title><l" +
            "ink rel=\"style", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_System_Center_Integrated_Cloud_Platform_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Microsoftr System Center: Integra" +
            "ted Cloud Plat", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_System_Center_Network_Virtualization_and_Cloud_Computing_EPUB.e" +
            "pub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Microsoft System Center: Network " +
            "Virtualization", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Prime_Palaver.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Unknown</title>    <meta content=\"Becky Catchings\" name=\"Author\"/>    <meta con" +
            "tent=\"Principl", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Reading_Guides_2013.epub", "<?xml version=\'1.0\' encoding=\'utf-8\'?><html xmlns=\"http://www.w3.org/1999/xhtml\">" +
            "  <head>    <meta content=\"text/css\" http-equiv=\"Content-Style-Type\"/>    <title" +
            ">Reading Guides 2013</title>    <meta content=\"Felecia McDuffie\" name=\"Author\"/>" +
            "    <meta cont", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\SystemCenterBuildingAVirtualizedNetwork_EPUB.epub", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1." +
            "1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"><html xml:lang=\"en-gb\" xml" +
            "ns=\"http://www.w3.org/1999/xhtml\"><head><title>Microsoft System Center</title><l" +
            "ink rel=\"style", null)]
        public virtual void GetEPubContent(string filename, string chapter2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get ePub content", exampleTags);
#line 46
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 47
 testRunner.Given(string.Format("an ePub file named \"{0}\"", filename), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.When("I open the file using ePubReader", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then(string.Format("the start of chapter 2 is \"{0}\"", chapter2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get ePub text content")]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Building a Release Pipeline with Team Foundation Server 2012 - EPUB.epub", "Contents       Summary    Foreword by Anutthara Bharadwaj    1 – You Want It When" +
            "?    2 – The Beginning    3 – Orchestrating the Release Pipeline    4 – Automati" +
            "ng the Release Pipeline    5 – Getting Good Feedback    6 – Improving the Pipeli" +
            "ne    Appen", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\CloudDesignPatternsEPUBebook.epub", "Contents        Preface    Patterns    Cache-aside Pattern    Circuit Breaker Pat" +
            "tern    Compensating Transaction Pattern    Competing Consumers Pattern    Compu" +
            "te Resource Consolidation Pattern    Command and Query Responsibility Segregatio" +
            "n (CQRS) Pa", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\DependencyInjectionWithUnity.epub", "Copyright      This document is provided “as-is”. Information and views expressed" +
            " in this document, including URL and other Internet Web site references, may cha" +
            "nge without notice.  Some examples depicted herein are provided for illustration" +
            " only and a", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Deploying an ASP.NET Web Application to a Hosting Provider using Visual S" +
            "tudio.epub", "Deploying an ASP.NET Web Application to a Hosting Provider using Visual Studio  T" +
            "om Dykstra  Summary: This series of tutorials shows you how to make an ASP.NET w" +
            "eb application available over the internet by deploying it to a third-party host" +
            "ing provider", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Deployment-guide-for-SharePoint-2013.epub", "Add a RefinementWeb Part to a page  You can addrefiners to a page to narrow the i" +
            "tems that are shown in a Content Search WebPart, and help users quickly browse t" +
            "o specific content. Refiners are based onmanaged properties from the search inde" +
            "x. To displa", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Developer\'s Guide to Microsoft Enterprise Library - 2nd Edition.epub", "Contents       Foreword by S. Somasegar    Foreword to the 1st Edition by Scott G" +
            "uthrie    1 - Welcome to the Library: Introduction to the Microsoft Enterprise L" +
            "ibrary    2 - Much ADO about Data Access: Using the Data Access Application Bloc" +
            "k     3 - E", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Explore-SharePoint-2013.epub", "Abstract  This book provides information about what\'s new in SharePoint 2013.The " +
            "audiences for this book include application specialists, line-of-businessapplica" +
            "tion specialists, and IT administrators who want to know more aboutSharePoint 20" +
            "13.  The con", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2011.epub", "Terraforming Ganymede with Robert A. Heinlein by Gregory Benford     Discovering " +
            "Heinlein, for most who have, is like having sex or dropping acid: you don’t forg" +
            "et your first time.  – Adrienne Martini , Locus 2011    There it is. Gosh, $2.50" +
            ". But ... I", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2012.epub", "Putting the Science in Science Fiction by Tedd Roberts   Thirty-five years ago I " +
            "entered college with a plan: I would major in pre-med, go to medical school, stu" +
            "dy neurosurgery and specialize in bionics.  It was 1976 and The Six Million Doll" +
            "ar Man had b", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2013.epub", "On the Road to the Brainships: A Look at the Current Science of Interfacing the B" +
            "rain   by Tedd Roberts  There are many science fiction (SF) stories in which the" +
            " characters have some form of direct brain-to-computer connection, but none quit" +
            "e rivals", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Nonfiction_2014.epub", "Training for War, Part IV  by Tom Kratman   Vignette Seven: oh, of course the ene" +
            "my will always set himself up for maximum vulnerability to your drills and stand" +
            "ard operating procedures.  (The following is extracted from Carnifex , Volume II" +
            " in the Car", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2012.epub", "Grayson Navy Letters Home by Joelle Presby  (artwork by Thomas Pope)    [Post to " +
            "Tester’s Blessings on the GSN private forum.] [October 1921]  Everyone, Ladies, " +
            "and Whoever,  My sister, Ensign Cecelie Rustin, Grayson Navy sent this. Cecelie " +
            "just got her", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2013.epub", "Seven Miles   by T.C. McCarthy   Kostya held his breath. When the airlock door hi" +
            "ssed open, the suit\'s scanner whined to life.  \"Clear,\" its voice chimed.  \"Come" +
            ".\" He adjusted the incinerator straps, flicked off the safety, and angled his bo" +
            "dy so tha", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Free_Stories_2014.epub", "The Aristocrat and the Free Man  by Robert Conroy   My latest novel, Liberty: 178" +
            "4 , takes place in a dark world where the British have won the Revolution and ar" +
            "e hell bent on imposing a harsh regime mirroring England’s. This is a short stor" +
            "y dealing w", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Azure_EPUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2013 Microsoft Corporation  All righ" +
            "ts reserved. No part of the contents of this book may be reproduced or transmitt" +
            "ed in any fo", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Microsoft_SQL_Server_2014_EPUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2014 by Microsoft Corporation  All r" +
            "ights reserved. No part of the contents of this book may be reproduced or transm" +
            "itted in any", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_System_Center_2012_epub.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2013 Microsoft Corporation  All righ" +
            "ts reserved. No part of the contents of this book may be reproduced or transmitt" +
            "ed in any fo", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Windows_ITPro_EPUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2013 Microsoft Corporation  All righ" +
            "ts reserved. No part of the contents of this book may be reproduced or transmitt" +
            "ed in any fo", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_Introducing_Windows_Server_2012_R2_EPUB.epub", "Contents  Introduction  Chapter 1 Cloud OS  The big picture  Journey to the Cloud" +
            " OS  Let s begin!  Chapter 2 Hyper-V  Previous enhancements to Hyper-V  Generati" +
            "on 2 virtual machines  Automatic Virtual Machine Activation  Remote access over " +
            "VMBus  Cross", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_eBook_Programming_Windows_8_Apps_HTML_CSS_JavaScript_2E_E" +
            "PUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2014Microsoft Corporation  All right" +
            "s reserved. No part of the contents of this book may be reproduced or transmitte" +
            "d in any for", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_eBook_Rethinking_Enterprise_Storage_A_Hybrid_Cloud_Model_" +
            "EPUB.epub", "Foreword When I started my career in IT, storage was incredibly boring and someth" +
            "ing that most people tried to avoid. Enterprise data storage was the domain of s" +
            "trange people interested in tracks, cylinders, and data placements; they did not" +
            " write code—t", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterConfMgrFieldExperience_EPUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2013 by Microsoft Corporation (All) " +
            " All rights reserved. No part of the contents of this book may be reproduced or " +
            "transmitted", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterDesigningOrchestratorRunbooks_EPUB.epub" +
            "", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2013 Microsoft Corporation  All righ" +
            "ts reserved. No part of the contents of this book may be reproduced or transmitt" +
            "ed in any fo", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_Press_ebook_SystemCenterOptimizingServiceManager_EPUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399 Copyright 2013 by Microsoft Corporation (All) A" +
            "ll rights reserved. No part of the contents of this book may be reproduced or tr" +
            "ansmitted in", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_System_Center_Integrated_Cloud_Platform_EPUB.epub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2014 Microsoft Corporation (All)  Al" +
            "l rights reserved. No part of the contents of this book may be reproduced or tra" +
            "nsmitted in", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Microsoft_System_Center_Network_Virtualization_and_Cloud_Computing_EPUB.e" +
            "pub", "PUBLISHED BY Microsoft Press A Division of Microsoft Corporation One Microsoft Wa" +
            "y Redmond, Washington 98052-6399  Copyright 2014 by Microsoft Corporation (All) " +
            " All rights reserved. No part of the contents of this book may be reproduced or " +
            "transmitted", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Prime_Palaver.epub", "Prime Palaver # 2  Letters to the Librarian  Eric Flint  January 16, 2000   Since" +
            " an article got published in slashdot.org, the Library has been flooded with hit" +
            "s and I received about 200 letters within 24 hours.  But even before that happen" +
            "ed, I was r", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\Reading_Guides_2013.epub", "Teacher’s Guide to Rising Sun      Contents:   recommended reading level  plot su" +
            "mmary  character sketches  guides to each chapter, including: \t \t prepare to rea" +
            "d… \t\t \t \t vocabulary \t\t\t focus questions and initiating activities \t\t\t suggested" +
            " “supportive", null)]
        [NUnit.Framework.TestCaseAttribute("C:\\test\\SystemCenterBuildingAVirtualizedNetwork_EPUB.epub", "Contents  Introduction  Chapter 1 Key concepts  Introducing Contoso Ltd  Architec" +
            "ture  Virtualized network components  Logical network  IP and MAC address pools " +
            " Uplink port profiles  Network adapter port profiles  Port classifications  Logi" +
            "cal switches", null)]
        public virtual void GetEPubTextContent(string filename, string chapter2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get ePub text content", exampleTags);
#line 83
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 84
 testRunner.Given(string.Format("an ePub file named \"{0}\"", filename), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
 testRunner.When("I open the file using ePubReader", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then(string.Format("the text start of chapter 2 is \"{0}\"", chapter2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
