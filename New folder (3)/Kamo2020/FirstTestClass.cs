using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Kamo2020
{
    [TestClass]
    public class FirstTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void ChromeMethod1()
        {
            string ActualResult;
            string ExpectedResult = "Google";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            ActualResult = driver.Title;
            if(ActualResult.Contains(ExpectedResult))
            {
                Console.WriteLine("Test Case Passed");
            }
            else
            {
                Console.WriteLine("Test Case Failed");
            }
            Thread.Sleep(4000);
            driver.Close();
            driver.Quit();
        }

        [TestMethod]

        public void wikisearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.Id("searchInput")).SendKeys("Billie Eilish");
            //driver.FindElement(By.XPath("//*[@id='search-form']/fieldset/button/i")).Click();
            List<string> textofanchors = new List<string>();
            ReadOnlyCollection<IWebElement> Anchorlists = driver.FindElements(By.TagName("a"));
            foreach(IWebElement anchor in Anchorlists)
            {

               try
                {
                    if (anchor.Text.Length > 0)
                    {
                        if (anchor.Text.Contains("English"))
                        {
                            textofanchors.Add(anchor.Text);
                            anchor.Click();
                        }
                    }
                }

                catch (Exception)
                {
                }
                
                        
                
            }

            driver.Close();
            driver.Quit();

        }

        [TestMethod]

        public void wikisearch2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org");
            driver.Manage().Window.Maximize();
            List<string> CentralLanguages = new List<string>();
            ReadOnlyCollection<IWebElement> Languages = driver.FindElements(By.ClassName("central-featured-lang"));
          
            SelectElement selectLanguage = new SelectElement(driver.FindElement(By.Id("searchLanguage")));
            selectLanguage.SelectByText("Asturianu");
            Thread.Sleep(4000);
            selectLanguage.SelectByValue("de");
            Thread.Sleep(4000);
            selectLanguage.SelectByIndex(0);
            Thread.Sleep(4000);

            driver.Close();
            driver.Quit();
        }

        [TestMethod]

        public void RadioButton()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("u_0_6")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("u_0_7")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("u_0_8")).Click();
            Thread.Sleep(3000);

            driver.Close();
            driver.Quit();
        }

        [TestMethod]

        public void TwitterLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://twitter.com/login");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/div[2]/main/div/div/form/div/div[1]/label/div/div[2]/div/input")).SendKeys("thandoxaba40@gmail.com");
            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/div[2]/main/div/div/form/div/div[2]/label/div/div[2]/div/input")).SendKeys("kamogelo123");
            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/div[2]/main/div/div/form/div/div[3]/div/div")).Click();
            Thread.Sleep(3000);
            //after login, composing tweet
            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/div[2]/main/div/div/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div/div/div[1]/div/div/div/div[2]/div/div/div/div")).SendKeys("Selenium Second test at:" + DateTime.Now.ToShortTimeString());
            driver.FindElement(By.XPath("//*[@id='react-root']/div/div/div[2]/main/div/div/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div/div[2]/div[2]/div/div/div[2]/div[3]/div/span/span")).Click();
            Thread.Sleep(3000);

            //Selecting different elements
            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(1)>div")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(2)>div>div>svg")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(3)>div>div>svg")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(4)>div")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(5)>div>div>svg")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(6)>div>div>svg")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#react-root>div>div>div.css-1dbjc4n.r-18u37iz.r-1pi2tsx.r-13qz1uu.r-417010>header>div>div>div>div:nth-child(1)>div.css-1dbjc4n.r-1awozwy.r-d0pm55.r-1bymd8e.r-13qz1uu>nav>a:nth-child(7)>div>div>svg")).Click();
            Thread.Sleep(3000);

            driver.Close();
            driver.Quit();
        }

    }
}