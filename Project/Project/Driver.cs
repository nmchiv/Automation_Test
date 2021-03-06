﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace IndeedAutomation 
{

    public class Driver
    {

        public static IWebDriver driver = new ChromeDriver(@"C:\Users\i57197\Downloads\chromedriver_win32");
        //SelectElement select;

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

        public void FindByClassEnterText(string className, string email)
        {
            driver.FindElement(By.ClassName(className)).SendKeys(email);
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

        public void FindByClassAndClick(string className)
        {
            driver.FindElement(By.ClassName(className)).Click();
        }

        public void FindByXpathAndClick(string xpath)
        {
            driver.FindElement(By.Id(xpath)).Click();
        }

        public void FindByCSSAndClick(string selector)
        {
            driver.FindElement(By.CssSelector(selector)).Click();
        }

        public void ConfirmAlertPopUp()
        {
            driver.SwitchTo().Alert().Accept();
        }


        //public void SelectByText(string selText)
        //{
        //    select.SelectByText(selText);
        //}

        
    }
}
