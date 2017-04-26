using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndeedAutomation;
using OpenQA.Selenium;

namespace Project
{
    public class JobsPage : Driver
    {
        public static bool IsAt
        {
            get
            {
                var h1s = driver.FindElements(By.TagName("h1"));
                if (h1s.Count > 0)
                { return h1s[0].Text == "software tester jobs in Salt Lake City, UT"; }
                else
                {   return false;   }
            }
        }

        //public static bool VerifyLogo
        //{
        //    get
        //    {
        //        var verifyLogo = driver.FindElements(By.PartialLinkText("/resumes/static/images/indeed"));
        //        if (verifyLogo.Count > 0)
        //        { return verifyLogo[0].FindElement(By.PartialLinkText("") }
        //        else
        //        { return false; }
        //    }
        //}
    }
}
