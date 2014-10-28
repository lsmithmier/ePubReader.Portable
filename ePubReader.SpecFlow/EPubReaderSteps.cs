using eBdb.EpubReader;
using ICSharpCode.SharpZipLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace ePubReader.SpecFlow
{
    [Binding]
    public class EPubReaderSteps
    {
        [Given(@"I have set the file system")]
        public void GivenIHaveSetTheFileSystem()
        {
            VFS.SetCurrent(new WindowsVFS());
        }

        [Given(@"an ePub file named ""(.*)""")]
        public void GivenAnEPubFileNamed(string p0)
        {
            ScenarioContext.Current.Add("FileName", p0);
        }

        [When(@"I open the file using ePubReader")]
        public void WhenIOpenTheFileUsingEPubReader()
        {
            string fileName = ScenarioContext.Current
                .Get<string>("FileName");
            Epub epub = new Epub(fileName);
            ScenarioContext.Current.Add("Epub", epub);
        }

        [Then(@"the title is ""(.*)""")]
        public void ThenTheTitleIs(string p0)
        {
            Epub epub = ScenarioContext.Current
                .Get<Epub>("Epub");
            Assert.AreEqual<string>(p0, epub.Title[0]);
        }

        [Then(@"the start of chapter 2 is ""(.*)""")]
        public void ThenTheStartOfChapter2Is(string p0)
        {
            Epub epub = ScenarioContext.Current
                .Get<Epub>("Epub");
            Assert.AreEqual<string>(p0, epub.TOC[1].ContentData.Content.Replace("\n", "").Replace("\r", "").Substring(0, 255).Trim());
        }

        [Then(@"the text start of chapter 2 is ""(.*)""")]
        public void ThenTheTextStartOfChapter2Is(string p0)
        {
            Epub epub = ScenarioContext.Current
                .Get<Epub>("Epub");
            Assert.AreEqual<string>(p0, epub.TOC[1].ContentData.GetContentAsPlainText().Replace("\n", "").Replace("\r", "").Substring(0, 255).Trim());
        }
    }
}
