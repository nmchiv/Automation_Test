using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project 
{
    class Program
    {

        IWebDriver driver = new ChromeDriver(@"C:\Users\i57197\Downloads\chromedriver_win32");

        public static void Main(string[] args)
        {

        }
        public void GoToURL(string URL) {
        driver.Navigate().GoToUrl(URL);
        }

        public void ClickID (string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public void EnterTxt(string id, string jobName)
        {
            driver.FindElement(By.Id(id)).SendKeys(jobName);
        }

        public void ClearTxt(string id)
        {
            driver.FindElement(By.Id(id)).Clear();
        }

        public void FindPartialLinkTxt(string linkTxt)
        {
            driver.FindElement(By.PartialLinkText(linkTxt));
        }

        public void CloseWindow()
        {
            driver.Close();
        }

        public void FindId(string id)
        {
            driver.FindElement(By.Id(id));
        }



    }
}
