using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Assessment.Steps
{
    [Binding]
    public class GoogleNewsFeatureSteps : IDisposable
    {
        private ChromeDriver _chromeDriver;

        [Given(@"I have navigated to google news website")]
        public void GivenIHaveNavigatedToGoogleWebsite()
        {
            var options = new ChromeOptions();
            // var proxy = new Proxy {Kind = ProxyKind.Manual, IsAutoDetect = false, SslProxy = "35.220.130.255:80"};
            // options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            _chromeDriver = new ChromeDriver(options);
            _chromeDriver.Navigate().GoToUrl("https://news.google.com/");
            Assert.IsTrue(_chromeDriver.Title.ToLower().Contains("google"));
        }

        [When(@"I have loaded into the page successfully")]
        public void WhenIPressTheSearchButton()
        {
            var body = _chromeDriver.FindElementByCssSelector("body");
            Assert.IsTrue(body.Displayed);

            IJavaScriptExecutor js = (IJavaScriptExecutor)_chromeDriver;

            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

        }

        [Then(@"I should pull down all headline titles")]
        public void ThenIShouldPullDownAllHeadlineTitles()
        {
            IList<IWebElement> headline = _chromeDriver.FindElements(By.CssSelector("article > h3 > a"));

            foreach (var headlines in headline)
            {
                Assert.IsTrue(headlines.Displayed);
                if (!string.IsNullOrEmpty(headlines.Text))
                    Console.WriteLine(headlines.Text);
            }
        }



        public void Dispose()
        {
            if (_chromeDriver != null)
            {
                _chromeDriver.Dispose();
                _chromeDriver = null;
            }
        }
    }
}